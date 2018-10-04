﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace MikroSRZ104
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
            if (!File.Exists("MikroSRZ104Config.ea"))
            {
                Application.Run(new ConfigFilesForm());
                                
                if (File.Exists("MikroSRZ104Config.ea"))
                {
                    Application.Run(new MainForm());
                }
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
