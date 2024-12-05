using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BromoAirlines {
    public class Repo {
        public static BromoAirlinesEntities db = new BromoAirlinesEntities();
        public static Akun logged = null;

        public static void login(string username, string password) {
            logged = db.Akuns.Where(r => r.username.Equals(username) && r.password.Equals(password)).FirstOrDefault();
        }

        public static bool isUnique(string username) {
            Akun isUnique = db.Akuns.Where(r => r.username.Equals(username)).FirstOrDefault();
            if (isUnique != null) {
                return false;
            } else {
                return true;
            }
        }
    }
}
