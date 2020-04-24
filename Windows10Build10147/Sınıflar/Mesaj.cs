using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows10Build10147.Sınıflar
{
    public static class Mesaj
    {
        public static bool MesajVer(string msj)
        {
            Formlar.frmMesaj frmMsj = new Formlar.frmMesaj(msj);
            frmMsj.ShowDialog();
            return frmMsj.cevap;
        }
    }
}
