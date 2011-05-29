//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace TUVANLAPTOP
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Class chay program
    /// </summary>
    
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
            Application.Run(new MANHINHCHINH());
        }
    }
}
