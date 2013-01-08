using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZusiGraph
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: reintegrate form into Main form
            //TEST: minimize instead
            //this.WindowState = FormWindowState.Minimized;

            //Prevents user from closing the form
            e.Cancel = true;
        }

        private void GraphForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
