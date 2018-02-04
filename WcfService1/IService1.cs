using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void DodajNauczyciela(TNauczyciel tn);

        [OperationContract]
        void EdytujNauczyciela(TNauczyciel tn);

        [OperationContract]
        void UsunNauczyciela(int id);

        [OperationContract]
        IEnumerable<TNauczyciel> WyswietlNauczycieli();

        [OperationContract]
        void DodajUcznia(TUczen tu);

        [OperationContract]
        void EdytujUcznia(TUczen tu);

        [OperationContract]
        void UsunUcznia(int id);

        [OperationContract]
        IEnumerable<TUczen> WyswietlUczniow();

        [OperationContract]
        void DodajPrzedmiot(TPrzedmiot tp);

        [OperationContract]
        void EdytujPrzedmiot(TPrzedmiot tp);

        [OperationContract]
        IEnumerable<TPrzedmiot> WyswietlPrzedmioty();

        [OperationContract]
        void DodajKlase(TKlasa tk);

        [OperationContract]
        void EdytujKlase(TKlasa tk);

        [OperationContract]
        List<TKlasa> WyswietlKlasy();

        [OperationContract]
        void DodajOcene(TOcena to);

        [OperationContract]
        void EdytujOcene(TOcena to);

        [OperationContract]
        void UsunOcene(int id);

        [OperationContract]
        IEnumerable<TOcena> WyswietlOceny();

        [OperationContract]
        List<TKlasa> wyswietlKlase(int id);

        [OperationContract]
        List<TNauczyciel> wyswietlNauczyciela(int id);

        [OperationContract]
        List<TPrzedmiot> wyswietlPrzedmiot(int id);

        [OperationContract]
        List<TUczen> wyswietlUczen(int id);

        [OperationContract]
        List<TUczen> wyswietlUczenKlasa(int idklasy);

        [OperationContract]
        List<PrzedmiotOceny> wyswietlPrzedOceny(int iducznia);


        [OperationContract]
        List<TOcena> wyswietlOcene(int pid, int uid);

        [OperationContract]
        List<TOcena> wyswietlOcene2(int id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
