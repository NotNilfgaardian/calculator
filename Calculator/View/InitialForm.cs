using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }


        private void InitialForm_Load(object sender, EventArgs e)
        {
            textField.Enabled = true;
            gonextBTN.Enabled = false;

        }

        private void textField_TextChanged(object sender, EventArgs e)
        {
            if (textField.Text.Length > 0)
            {
                gonextBTN.Enabled = true;
            }
            else gonextBTN.Enabled = false;
        }



        private void ImportBTN_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //ImportSchedule?.Invoke(openFileDialog.FileName, feederName);
            }
        }

        private void gonextBTN_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string[] chest = textField.Text.Trim().Split(' ');
            for (int j = 0; j < chest.Length; j++)
            {
                bool result = decimal.TryParse(chest[j], out var number);
                if (result == false)
                {
                    MessageBox.Show("Wrong data", "ERROR", MessageBoxButtons.OK);
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                //MainForm frm2 = new MainForm(textField.Text);
               // frm2.Show();
                //this.Hide();
            }
        }
    }
}
