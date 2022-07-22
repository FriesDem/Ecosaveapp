using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouncilGamingClub
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }
        public static string Hashpassword(string password)
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sbuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sbuilder.Append(data[i].ToString("x2"));
            }
            return sbuilder.ToString();
        }
        public static string DefaultHashpassword()
        {
            SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("123456789"));

            StringBuilder sbuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sbuilder.Append(data[i].ToString("x2"));
            }
            return sbuilder.ToString();
        }
       
    }


}
