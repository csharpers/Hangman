using System;
using System.Runtime.Serialization;

namespace HangmanServis
{
    [DataContract]
    public class Rezultat
    {
        private string ime;
        private int brojPogresnihSlova, vreme;

        [DataMember]
        public Rezultat(string ime, int brojPogresnihSlova, int vreme)
        {
            this.ime = ime;
            this.brojPogresnihSlova = brojPogresnihSlova;
            this.vreme = vreme;
        }

        [DataMember]
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        [DataMember]
        public int BrojPogresnihSlova
        {
            get { return brojPogresnihSlova; }
            set { brojPogresnihSlova = value; }
        }

        [DataMember]
        public int Vreme
        {
            get { return vreme; }
            set { vreme = value; }
        }
    }
}