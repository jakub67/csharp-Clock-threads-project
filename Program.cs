using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadsFormTime.Implementace;                 //doplneno
using ThreadsFormTime;
using System.Threading;

namespace ThreadsFormTime {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Clock c = new Clock();

            Thread t1 = new Thread(c.loop);
            t1.Start();
            Application.Run(new Form1(c));
            //c.loop();                 //anonymni instance new Clock.loop();
            t1.Abort();
            
        }
    }
}
