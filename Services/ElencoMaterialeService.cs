using inventory_tool.Data;
using System.Collections.Generic;
using System.Linq;

namespace inventory_tool.Services
{
    public class ElencoMaterialeService
    {
        public static List<MaterialeViewModel> GetElencoMateriale()
        {
            using (var db = new AppDbContext())
            {
                var elencoMateriale = (
                    from m in db.Materiali
                    join a in db.Amministratori on m.IdAmministratore equals a.Id
                    where a.Username == UserSession.Username
                    select new MaterialeViewModel // Usiamo la classe creata sopra
                    {
                        Id = m.Id,
                        Descrizione = m.Descrizione,
                        Quantita = m.Quantita,
                        Amministratore = a.Nome + " " + a.Cognome
                    }
                ).ToList();

                return elencoMateriale;
            }
        }
    }
}