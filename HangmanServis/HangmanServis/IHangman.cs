using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace HangmanServis
{
    [ServiceContract]
    interface IHangman
    {
        [OperationContract]
        [FaultContract(typeof(string))]
        int PokreniNovuPartiju();

        [OperationContract]
        int[] ProveriUnetoSlovo(char slovo);

        [OperationContract]
        [FaultContract(typeof(string))]
        bool SacuvajRezultat(int brojPogresnih, int sekunde, string ime);

        [OperationContract]
        [FaultContract(typeof(string))]
        List<Rezultat> IspisiSveRezultate(int izbor);
    }
}
