using inventory_tool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_tool.Services
{
    public class LoginService
    {
        public static bool login(string username, string password)
        {
            using (var db = new AppDbContext())
            {
                var amministratore = (from a in db.Amministratori
                                      where a.Username.Equals(username) && a.Password.Equals(password)
                                      select a).FirstOrDefault();

                if (amministratore == null)
                {
                    return false;
                }
                else
                {
                    UserSession.Username = amministratore.Username;
                    UserSession.Ruolo = "Amministratore";
                    return true;
                }
            }
        }
    }
}
