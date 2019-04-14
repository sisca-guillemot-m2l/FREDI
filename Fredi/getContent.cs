using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Fredi
{
    class getContent
    {
        public string getPassword()
        {
            using (StreamReader srPassword = new StreamReader(@"c:\Users\Fabien\Source\Repos\Fredi\password.txt"))
            {
                String Password = srPassword.ReadToEnd();
                return Password;
            }
        }

        public string getId()
        {
            using (StreamReader srId = new StreamReader(@"c:\Users\Fabien\Source\Repos\Fredi\id.txt"))
            {
                String Id = srId.ReadToEnd();
                return Id;
            }
        }

        public string getServer()
        {
            using (StreamReader srServer = new StreamReader(@"c:\Users\Fabien\Source\Repos\Fredi\server.txt"))
            {
                String Server = srServer.ReadToEnd();
                return Server;
            }
        }

        public string getDb()
        {
            using (StreamReader srDb = new StreamReader(@"c:\Users\Fabien\Source\Repos\Fredi\db.txt"))
            {
                String Db = srDb.ReadToEnd();
                return Db;
            }
        }

        public string getIdM()
        {
            using (StreamReader srIdM = new StreamReader(@"c:\Users\Fabien\Source\Repos\Fredi\idM.txt"))
            {
                String IdM = srIdM.ReadToEnd();
                return IdM;
            }
        }

        public string getpwdM()
        {
            using (StreamReader srPwdM = new StreamReader(@"c:\Users\Fabien\Source\Repos\Fredi\pwdM.txt"))
            {
                String PwdM = srPwdM.ReadToEnd();
                return PwdM;
            }
        }
    }
}
