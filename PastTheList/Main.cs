using PastTheListLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastTheList
{
    public partial class Main : Form
    {
        private ListProcessor list = new ListProcessor();

        public Main()
        {
            InitializeComponent();
            timer1.Start();
            SetParameters();
        }

        private void SetParameters()
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            preview.Text ="";
        }
    }
}
