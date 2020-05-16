using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void AddForm_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Show();
        }

        private void ShowLib_Click(object sender, EventArgs e)
        {
            LibraryForm lf = new LibraryForm();
            lf.Show();
        }
    }
}
