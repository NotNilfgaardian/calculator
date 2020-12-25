using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class InitialForm : Form
    {
        private readonly InitialPresenter initialPresenter = new InitialPresenter();
        public InitialForm()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
        }

        private void ImportBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = initialPresenter.FileDataIni(openFileDialog.FileName);
                if (text.Equals("ERROR"))
                {
                    MessageBox.Show("Wrong path", "ERROR", MessageBoxButtons.OK);
                }
                else {
                    textField.Text = text;
                }
            }
        }

        private void TextField_TextChanged(object sender, EventArgs e)
        {
            if (textField.Text.Length > 0)
            {
                GoNextBTN.Enabled = true;
            }
            else GoNextBTN.Enabled = false;
        }

        private void GoNextBTN_Click(object sender, EventArgs e)
        {
            bool flag = initialPresenter.TextDataIni(textField.Text);
            if (!flag) {
                MessageBox.Show("Wrong data", "ERROR", MessageBoxButtons.OK);
            }
            else {
                MainForm frm2 = new MainForm();
                frm2.Show();
                this.Hide();
            }
        }
    }
}
