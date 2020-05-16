using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Stack<double> memory;
        public Form1()
        {
            InitializeComponent();
            this.point.Enabled = false;
            this.squrt.Enabled = false;
            this.cubert.Enabled = false;
            this.sin.Enabled = false;
            this.cos.Enabled = false;
            this.tan.Enabled = false;
            this.catg.Enabled = false;
            this.minus.Enabled = true;
            this.remember.Enabled = false;
            this.extract.Enabled = false;
            this.memory = new Stack<double>();
        }
        private void numeral_Click(object sender, EventArgs e)
        {
            if(this.Monitor.Text.Length<10) this.Monitor.Text += ((Button)sender).Text;
            this.minus.Enabled = false;
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
            if (this.Monitor.Text.Contains("-"))
            {
                this.minus.Enabled = false;
                this.squrt.Enabled = false;
                this.cubert.Enabled = true;
            }
            else
            {
                this.cubert.Enabled = true;
                this.squrt.Enabled = true;
            }
            this.sin.Enabled = true;
            this.cos.Enabled = true;
            this.tan.Enabled = true;
            this.catg.Enabled = true;
            this.remember.Enabled = true;
        }
        private void C_Click(object sender, EventArgs e)
        {
            this.Monitor.Text = "";
            this.Prev.Text = "";
            this.point.Enabled = false;
            this.minus.Enabled = true;
            this.squrt.Enabled = false;
            this.cubert.Enabled = false;
            this.sin.Enabled = false;
            this.cos.Enabled = false;
            this.tan.Enabled = false;
            this.catg.Enabled = false;
            this.remember.Enabled = false;
        }
        private void point_Click(object sender, EventArgs e)
        {
            this.Monitor.Text += ',';
            this.point.Enabled = false;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            this.Monitor.Text += "-";
            this.minus.Enabled = false;
        }

        private void squrt_Click(object sender, EventArgs e)
        {
            this.Prev.Text = "";
            this.Prev.Text += this.Monitor.Text + "^(1/2)=";
            float x;
            if(float.TryParse(this.Monitor.Text, out x))
            {
                this.Monitor.Text = Math.Pow(x, 0.5).ToString();
            }
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
        }

        private void cubert_Click(object sender, EventArgs e)
        {
            this.Prev.Text = "";
            this.Prev.Text = this.Monitor.Text + "^(1/3)=";
            float x;
            if (float.TryParse(this.Monitor.Text, out x))
            {
                if (x < 0) this.Monitor.Text = "-";
                if(this.Monitor.Text.Equals("")) this.Monitor.Text = Math.Pow(x, (double)1/3).ToString();
                else this.Monitor.Text = Math.Pow(Math.Abs(x), (double)1 / 3).ToString();
            }
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
        }

        private void sin_Click(object sender, EventArgs e)
        {
            this.Prev.Text = "";
            this.Prev.Text += "sin("+this.Monitor.Text + ")=";
            float x;
            if (float.TryParse(this.Monitor.Text, out x))
            {
                this.Monitor.Text = Math.Sin(x).ToString();
            }
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            this.Prev.Text = "";
            this.Prev.Text += "cos(" + this.Monitor.Text + ")=";
            float x;
            if (float.TryParse(this.Monitor.Text, out x))
            {
                this.Monitor.Text = Math.Cos(x).ToString();
            }
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            this.Prev.Text = "";
            this.Prev.Text += "tg(" + this.Monitor.Text + ")=";
            float x;
            if (float.TryParse(this.Monitor.Text, out x))
            {
                this.Monitor.Text = Math.Tan(x).ToString();
            }
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
        }

        private void catg_Click(object sender, EventArgs e)
        {
            this.Prev.Text = "";
            this.Prev.Text += "ctg(" + this.Monitor.Text + ")=";
            float x;
            if (float.TryParse(this.Monitor.Text, out x))
            {
                this.Monitor.Text = ((double)(1/Math.Tan(x))).ToString();
            }
            if (!this.Monitor.Text.Contains(",")) this.point.Enabled = true;
            else this.point.Enabled = false;
        }

        private void remember_Click(object sender, EventArgs e)
        {
            float x;
            if (float.TryParse(this.Monitor.Text, out x))
            {
                this.memory.Push(x);
            }
            this.extract.Enabled = true;
        }

        private void extract_Click(object sender, EventArgs e)
        {
            double x;
            if(this.memory.Count !=0)
            {
                x = this.memory.Peek();
                this.memory.Pop();
                this.Monitor.Text = x.ToString();
            }
            if (this.memory.Count == 0) this.extract.Enabled = false;
        }

        private void form2_start_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
