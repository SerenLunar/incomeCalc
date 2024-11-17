using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string gelir = richTextBoxGelir.Text;
            string xerc = richTextBoxXerc.Text;
            string budce = labelBudce.Text;
            int gelirInt = Convert.ToInt32(gelir);
            int xercInt = Convert.ToInt32(xerc);
            int budceInt = Convert.ToInt32(budce);
            budceInt = budceInt + (gelirInt - xercInt);
            labelBudce.Text = budceInt.ToString();
        }
    }
}
