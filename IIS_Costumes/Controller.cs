using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Security.Cryptography;

namespace IIS_Costumes
{
    class Controller
    {
        /*public static Form ShowForm(Form form, bool showDialog = false, params object[] parameters)
        {
            if (form.IsDisposed)
            {
                // form = (Form)Activator.CreateInstance(form.GetType());
                var constructorInfo = form.GetType().GetConstructor(new Type[] { });
                form = (Form)constructorInfo.Invoke(new object[] { });
            }
            if (showDialog) form.ShowDialog();
            else form.Show();
            form.Activate();
            return form;
        }*/

        public static string GetMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static string GetSaltedMD5Hash(string salt, string input)
        {
            string hash = GetMD5Hash(input);
            return GetMD5Hash(salt + hash);
        }
    }
}
