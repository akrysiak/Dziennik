using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DodajNauczyciela(TNauczyciel tn)
        {
            ModelDziennik md = new ModelDziennik();

            md.TNauczyciel.Add(tn);
            md.SaveChanges();
        }

        public void EdytujNauczyciela(TNauczyciel tn)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TNauczyciel
                             where n.Id == tn.Id
                             select n).First();
            zapytanie.Nauczyciel = tn.Nauczyciel;
            md.SaveChanges();
        }

        public void UsunNauczyciela(int id)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TNauczyciel
                             where n.Id == id
                             select n).First();
            md.TNauczyciel.Remove(zapytanie);
            md.SaveChanges();
        }

        public IEnumerable<TNauczyciel> WyswietlNauczycieli()
        {
            ModelDziennik md = new ModelDziennik();
            List<TNauczyciel> nauczyciel = new List<TNauczyciel>();
            nauczyciel = md.TNauczyciel.ToList();
            return nauczyciel;

        }

        public void DodajUcznia(TUczen tu)
        {
            ModelDziennik md = new ModelDziennik();

            md.TUczen.Add(tu);
            md.SaveChanges();
        }

        public void EdytujUcznia(TUczen tu)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TUczen
                             where n.Id == tu.Id
                             select n).First();
            zapytanie.Imie = tu.Imie;
            zapytanie.Nazwisko = tu.Nazwisko;
            zapytanie.Ulica = tu.Ulica;
            zapytanie.Kod = tu.Kod;
            zapytanie.Kontakt = tu.Kontakt;
            zapytanie.Miejscowosc = tu.Miejscowosc;
            md.SaveChanges();
        }

        public void UsunUcznia(int id)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TUczen
                             where n.Id == id
                             select n).First();
            md.TUczen.Remove(zapytanie);
            md.SaveChanges();
        }

        public IEnumerable<TUczen> WyswietlUczniow()
        {
            ModelDziennik md = new ModelDziennik();
            List<TUczen> uczen = new List<TUczen>();
            uczen = md.TUczen.ToList();
            return uczen;
        }

        public void DodajPrzedmiot(TPrzedmiot tp)
        {
            ModelDziennik md = new ModelDziennik();

            md.TPrzedmiot.Add(tp);
            md.SaveChanges();
        }

        public void EdytujPrzedmiot(TPrzedmiot tp)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TPrzedmiot
                             where n.Id == tp.Id
                             select n).First();
            zapytanie.Nazwa = tp.Nazwa;
            zapytanie.IdNauczyciela = tp.IdNauczyciela;
            md.SaveChanges();
        }

        public IEnumerable<TPrzedmiot> WyswietlPrzedmioty()
        {
            ModelDziennik md = new ModelDziennik();
            List<TPrzedmiot> przedmiot = new List<TPrzedmiot>();
            przedmiot = md.TPrzedmiot.ToList();
            return przedmiot;
        }

        public void DodajKlase(TKlasa tk)
        {
            ModelDziennik md = new ModelDziennik();
            md.TKlasa.Add(tk);
            md.SaveChanges();
        }

        public void EdytujKlase(TKlasa tk)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TKlasa
                             where n.Id == tk.Id
                             select n).First();
            zapytanie.Nazwa = tk.Nazwa;
            zapytanie.Id_Wychowawcy = tk.Id_Wychowawcy;
            md.SaveChanges();
        }

        public List<TKlasa> WyswietlKlasy()
        {
            ModelDziennik md = new ModelDziennik();
            return md.TKlasa.ToList();
        }

        public void DodajOcene(TOcena to)
        {
            ModelDziennik md = new ModelDziennik();
            md.TOcena.Add(to);
            md.SaveChanges();
        }

        public void EdytujOcene(TOcena to)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TOcena
                             where n.Id == to.Id
                             select n).First();
            zapytanie.IdKlasy = to.IdKlasy;
            zapytanie.IdNauczyciela = to.IdNauczyciela;
            zapytanie.IdUcznia = to.IdUcznia;
            zapytanie.IdPrzedmiot = to.IdPrzedmiot;
            zapytanie.Ocena = to.Ocena;
            md.SaveChanges();
        }

        public void UsunOcene(int id)
        {
            ModelDziennik md = new ModelDziennik();

            var zapytanie = (from n in md.TOcena
                             where n.Id == id
                             select n).First();
            md.TOcena.Remove(zapytanie);
            md.SaveChanges();
        }

        public IEnumerable<TOcena> WyswietlOceny()
        {
            ModelDziennik md = new ModelDziennik();
            List<TOcena> ocena = new List<TOcena>();
            ocena = md.TOcena.ToList();
            return ocena;
        }

        public List<TKlasa> wyswietlKlase(int id)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from kl in md.TKlasa
                         where kl.Id == id
                         select kl).ToList();
            return query;
        }

        public List<TNauczyciel> wyswietlNauczyciela(int id)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from na in md.TNauczyciel
                         where na.Id == id
                         select na).ToList();
            return query;
        }

        public List<TPrzedmiot> wyswietlPrzedmiot(int id)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from pr in md.TPrzedmiot
                         where pr.Id == id
                         select pr).ToList();
            return query;
        }

        public List<TUczen> wyswietlUczen(int id)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from u in md.TUczen
                         where u.Id == id
                         select u).ToList();
            return query;
        }

        public List<TUczen> wyswietlUczenKlasa(int idklasy)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from u in md.TUczen
                         where u.IdKlasy == idklasy
                         select u).ToList();
            return query;
        }

        public List<PrzedmiotOceny> wyswietlPrzedOceny(int iducznia)
        {
            ModelDziennik md = new ModelDziennik();
            List<TPrzedmiot> przedmiot = new List<TPrzedmiot>();
            List<PrzedmiotOceny> przoc = new List<PrzedmiotOceny>();
            string sOcena = "";
            przedmiot = (from p in md.TPrzedmiot
                         select p).ToList();
            foreach (var p in przedmiot)
            {
                var q = (from oc in md.TOcena
                         join u in md.TUczen on oc.IdUcznia equals u.Id
                         join prz in md.TPrzedmiot on oc.IdPrzedmiot equals prz.Id
                         where prz.Id == p.Id && u.Id == iducznia
                         select oc).ToList();
                foreach (var item in q)
                {
                    sOcena += item.Ocena.Trim() + ", ";
                }
                if (sOcena.Length > 2)
                    sOcena = sOcena.Remove(sOcena.Length - 2);
                przoc.Add(new PrzedmiotOceny { iID = p.Id, sPrzedmiot = p.Nazwa, sOceny = sOcena });
                sOcena = "";
            }
            return przoc;
        }

        public List<TOcena> wyswietlOcene(int pid, int uid)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from oc in md.TOcena
                         join u in md.TUczen on oc.IdUcznia equals u.Id
                         join kl in md.TKlasa on oc.IdKlasy equals kl.Id
                         where oc.IdPrzedmiot == pid && oc.IdUcznia == uid 
                         select oc).ToList();
            return query;
        }

        public List<TOcena> wyswietlOcene2(int id)
        {
            ModelDziennik md = new ModelDziennik();
            var query = (from oc in md.TOcena
                         where oc.Id == id
                         select oc).ToList();
            return query;
        }
    }
}
