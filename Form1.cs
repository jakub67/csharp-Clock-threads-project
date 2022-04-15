using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadsFormTime.Implementace;                 //doplneno

namespace ThreadsFormTime {
    public partial class Form1 : Form {
        private Clock c;

        //internal Clock C { get => c; set => c = value; }

        public Form1() {
            InitializeComponent();
        }
        public Form1(Clock c) :this() {            //INTERNAL MUSI BYT, pokud je clock private
            this.c = c;
        }

        private void btEnd_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btShow_Click(object sender, EventArgs e) {
            this.c.show();
        }

        private void btDoNotShow_Click(object sender, EventArgs e) {
            this.c.doNotShow();
        }
    }
}
