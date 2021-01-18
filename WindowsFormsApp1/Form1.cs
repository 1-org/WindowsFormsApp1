using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked)
            {
                this.label1.Text = "checked";
            }
            else
            {
                this.label1.Text = "not checked";
                var time = this.dateTimePicker1.Value.ToString();
            }
        }

    }
}
