﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Finance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static DataTable loginDt;

        public static string  TempTxt;

        public static DataTable GlobalDT;


        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new PL.FRM_LOGIN());
           // Application.Run(new PL.Add.FRM_Transfer());
            Application.Run(new PL.Add.FRM_Transfer());

        }
    }
}
