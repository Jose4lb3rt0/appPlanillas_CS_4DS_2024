﻿using System;
using System.Windows.Forms;

namespace appPlanilla_CS_4DS_2024
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ui.frmLogin());
        }
    }
}
