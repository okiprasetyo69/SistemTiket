using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SistemTiket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Add Form
            //Application.Run(new SistemTiket.view.Frm_pegawai());
           // Application.Run(new SistemTiket.view.Frm_games());
            //Application.Run(new SistemTiket.view.Frm_kasir());
            //Application.Run(new SistemTiket.view.Frm_utama_parent());
           Application.Run(new SistemTiket.view.Frm_login());
            //Application.Run(new SistemTiket.view.Frm_kasir());
            //Application.Run(new SistemTiket.view.Frm_utama_kasir());
        }
    }
}
