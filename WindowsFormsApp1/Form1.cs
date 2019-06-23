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
    public partial class frmSummingApp : Form
    {
        public frmSummingApp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int answer = int.Parse(tbx1.Text) + int.Parse(tbx2.Text);
            //    MessageBox.Show(answer.ToString());
            //}

            //catch
            //{
            //    MessageBox.Show("An error occurred. Please enter a number into each box.");
            //}

            if (int.TryParse(tbx1.Text, out int num1) && int.TryParse(tbx2.Text, out int num2)) {
                MessageBox.Show((num1 + num2).ToString());

            }
        }
    }
}
