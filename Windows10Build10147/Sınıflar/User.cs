using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Build10147.Sınıflar
{
    public static class User
    {
        public static string[] BilgiAl()
        {
            string[] bilgiler = new string[2];
            string dosya_yolu = Application.StartupPath + "//Users//User.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs, Encoding.GetEncoding("iso-8859-9"));
            bilgiler[0] = sw.ReadLine();
            bilgiler[1] = sw.ReadLine();
            sw.Close();
            fs.Close();
            return bilgiler;
        }
        public static string UserName()
        {
            string Name = BilgiAl()[0].ToString().Substring(5);
            return Name;
        }
        public static string UserPassword()
        {
            string Pass = BilgiAl()[1].ToString().Substring(5);
            return Pass;
        }
        public static void UserUpdate(string userName, string userPass, Image userImage)
        {
            //kullanıcı bilgileri güncelleme işlemi
        }
        //public static Image UserProfilImage()
        //{
        //    return "";
        //}
    }
}
