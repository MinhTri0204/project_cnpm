using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.gui;
using System.Data.SqlClient;
using System.Configuration;

namespace DoAn
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
            Application.Run(new frmConnectSystem());

            //SqlConnection cnn = null;

            //string sFilePath = Application.ExecutablePath + ".config";
            //if (!System.IO.File.Exists(sFilePath))
            //{
            //    frmConnectSystem frmCnn = new frmConnectSystem();
            //    if (frmCnn.ShowDialog() == DialogResult.Cancel)
            //        Application.Exit();
            //    else
            //        Application.Restart();

            //    return;
            //}
            //else
            //{
            //    string sCNN = ConfigurationManager.ConnectionStrings["DoAn.Properties.Settings.QL_BSachConnectionString"].ConnectionString;
            //    cnn = new SqlConnection(sCNN);
            //    try
            //    {
            //        cnn.Open();
            //        cnn.Close();
            //        frmDangNhap dn = new frmDangNhap();
            //        dn.ShowDialog();
            //    }
            //    catch
            //    {
            //        frmConnectSystem frmCnn = new frmConnectSystem();
            //        frmCnn.ShowDialog();
            //    }
            //}
        }
    }
}
