using inventory_tool.Data;
using inventory_tool.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace inventory_tool.Services
{
    public class ElencoMaterialeService
    {
        public static List<MaterialeViewModel> GetElencoMateriale(string searchTerm = null)
        {
            using (var db = new AppDbContext())
            {
                var elencoMateriale =
                    from m in db.Materiali
                    join a in db.Amministratori on m.IdAmministratore equals a.Id
                    where a.Username == UserSession.Username
                    select new MaterialeViewModel
                    {
                        Id = m.Id,
                        Descrizione = m.Descrizione,
                        Quantita = m.Quantita,
                        Amministratore = a.Nome + " " + a.Cognome
                    };

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    var term = searchTerm.Trim();
                    elencoMateriale = elencoMateriale.Where(m => m.Descrizione.Contains(term));
                }

                return elencoMateriale.ToList();
            }
        }

        public static bool UpdateMateriale(int id, string descrizione, int quantita)
        {
            if (string.IsNullOrWhiteSpace(descrizione))
            {
                throw new ArgumentException("La descrizione è obbligatoria.", "descrizione");
            }

            if (quantita <= 0)
            {
                throw new ArgumentOutOfRangeException("quantita", "La quantità deve essere maggiore di zero.");
            }

            using (var db = new AppDbContext())
            {
                var amministratore = db.Amministratori.FirstOrDefault(a => a.Username == UserSession.Username);
                if (amministratore == null)
                {
                    return false;
                }

                var materiale = db.Materiali.FirstOrDefault(m =>
                    m.Id == id && m.IdAmministratore == amministratore.Id);
                if (materiale == null)
                {
                    return false;
                }

                materiale.Descrizione = descrizione.Trim();
                materiale.Quantita = quantita;
                db.SaveChanges();
                return true;
            }
        }

        public static bool DeleteMateriale(int id)
        {
            using (var db = new AppDbContext())
            {
                var amministratore = db.Amministratori.FirstOrDefault(a => a.Username == UserSession.Username);
                if (amministratore == null)
                {
                    return false;
                }

                var materiale = db.Materiali.FirstOrDefault(m =>
                    m.Id == id && m.IdAmministratore == amministratore.Id);
                if (materiale == null)
                {
                    return false;
                }

                db.Materiali.Remove(materiale);
                db.SaveChanges();
                return true;
            }
        }
    }
}