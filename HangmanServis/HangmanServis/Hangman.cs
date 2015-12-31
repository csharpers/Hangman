using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace HangmanServis
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Hangman : IHangman
    {
        private string rec;

        public int PokreniNovuPartiju()
        { 
            try
            {
                using (SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["HangmanConnectionString"].ToString()))
                {
                    konekcija.Open();
                    //Console.WriteLine("Veza ka bazi podataka 'Hangman' je otvorena.");

                    Random random = new Random();
                    int filmId = random.Next(1, 31);

                    string naredba = "SELECT nazivFilma FROM igra WHERE igraID = " + filmId + ";";
                    using(SqlCommand komanda = new SqlCommand(naredba, konekcija))
                    {
                        using(SqlDataReader citac = komanda.ExecuteReader())
                        {
                            if (citac.HasRows)
                            {
                                while(citac.Read())
                                    rec = citac["nazivFilma"].ToString();
                            }                              
                        }
                    }
                }

                return rec.Length;
            }
            catch(Exception e)
            {
                throw new FaultException<string>(e.Message);
            }
        }

        public int[] ProveriUnetoSlovo(char slovo)
        {
            char[] zadataRec = rec.ToCharArray(0, rec.Length);
            int[] indeksiSlova = new int[rec.Length];
            int j = 0;

            for (int i = 0; i < indeksiSlova.Length; i++)
                indeksiSlova[i] = -1;                

            for (int i = 0; i < rec.Length; i++)
            {
                if (zadataRec[i] == slovo)
                    indeksiSlova[j++] = i;
                else if (zadataRec[i] == Char.ToUpper(slovo))
                    indeksiSlova[j++] = i;
            }

            if (j != 0)
                return indeksiSlova;
            else
                return null;
        }

        public bool SacuvajRezultat(int brojPogresnihSlova, int vreme, string ime)
        {
            try
            {
                using(SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["HangmanConnectionString"].ToString()))
                {
                    konekcija.Open();
                    //Console.WriteLine("Veza ka bazi podataka 'Hangman' je otvorena.");

                    string naredba = "INSERT INTO rezultat (ime, brojPogresnihSlova, vreme) VALUES(N'" + ime + "', " + brojPogresnihSlova + ", " + vreme + ");";
                    using(SqlCommand komanda = new SqlCommand(naredba, konekcija))
                    {
                        int brojIzvrsenihRadnji = komanda.ExecuteNonQuery();
                        //Console.WriteLine("Uspesno upisan {0} rezultat.", brojIzvrsenihRadnji);

                        if (brojIzvrsenihRadnji != 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch(Exception e)
            {
                throw new FaultException<string>(e.Message);              
            }
        }

        public List<Rezultat> IspisiSveRezultate(int izbor)
        {
            List<Rezultat> rezultati = new List<Rezultat>();
            string naredba = " ";

            try
            {
                using(SqlConnection konekcija = new SqlConnection(ConfigurationManager.ConnectionStrings["HangmanConnectionString"].ToString()))
                {
                    konekcija.Open();

                    if (izbor == 1)
                        naredba = "SELECT * FROM rezultat;";
                    else if (izbor == 2)
                        naredba = "SELECT TOP 10 * FROM rezultat ORDER BY brojPogresnihSlova;";
                    else if (izbor == 3)
                        naredba = "SELECT TOP 10 * FROM rezultat ORDER BY vreme;";
                    else
                        return null;

                    using(SqlCommand komanda = new SqlCommand(naredba, konekcija))
                    {
                        using(SqlDataReader citac = komanda.ExecuteReader())
                        {
                            if (citac.HasRows)
                            {
                                while (citac.Read())
                                    rezultati.Add(new Rezultat(citac["ime"].ToString(), (int)citac.GetValue(2), (int)citac.GetValue(3)));
                            }
                        }
                    }
                }

                return rezultati;
            }
            catch(Exception e)
            {
                throw new FaultException<string>(e.Message);
            }
        }
    }
}