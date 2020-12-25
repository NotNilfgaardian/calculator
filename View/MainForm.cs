using Model;
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
    public partial class MainForm : Form
    {
        private readonly MainPresenter mainPresenter = new MainPresenter();
        int maxcount = 1;
        int choise;

        public MainForm()
        {
            InitializeComponent();
            string data = mainPresenter.GetData(0);
            dataField.Items.Add(data);
            dataField.SelectedItem = data;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
        }

        private void ExportBTN_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool result = mainPresenter.FileDataExport(saveFileDialog.FileName, dataField.SelectedIndex);
                if (result)
                {
                    MessageBox.Show("Export success", "Congratulations", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Wrong path", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataField_SelectedIndexChanged(object sender, EventArgs e)
        {
            count_label.Text = (dataField.SelectedIndex+1).ToString() + "/" + maxcount.ToString();
        }

        private void UndoBTN_Click(object sender, EventArgs e)
        {
            int bass = dataField.SelectedIndex;
            if (bass != 0) dataField.SelectedIndex = bass - 1;
        }



        private void SumButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 1;
        }

        private void SubButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 2;
        }

        private void MultButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 3;
        }

        private void DivButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 4;
        }

        private void Pow2Button_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = false;
            DLC_ok_BTN.Enabled = true;
            choise = 5;
        }

        private void PowButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 6;
        }

        private void sq2Button_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = false;
            DLC_ok_BTN.Enabled = true;
            choise = 7;
        }

        private void SqButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 8;
        }

        private void LogButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = true;
            if (DLCfield.Text.Length > 0)
                DLC_ok_BTN.Enabled = true;
            else
                DLC_ok_BTN.Enabled = false;
            choise = 9;
        }

        private void FactButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = false;
            DLC_ok_BTN.Enabled = true;
            choise = 10;
        }

        private void MedButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = false;
            DLC_ok_BTN.Enabled = true;
            choise = 11;
        }

        private void DispButton_CheckedChanged(object sender, EventArgs e)
        {
            DLCfield.Enabled = false;
            DLC_ok_BTN.Enabled = true;
            choise = 12;
        }

        private void DLCfield_TextChanged(object sender, EventArgs e)
        {
            if (DLCfield.Enabled == true && DLCfield.Text.Length > 0)
            {
                DLC_ok_BTN.Enabled = true;
            }
            else DLC_ok_BTN.Enabled = false;
        }

        private void CheckHistory()
        {
            int delCount = dataField.Items.Count - (dataField.SelectedIndex + 1);
            maxcount -= delCount;
            for (int i = dataField.Items.Count; i > (dataField.SelectedIndex + 1); i--)
            {
                dataField.Items.RemoveAt(i - 1);
            }
            mainPresenter.DeleteLast(delCount);
        }

        private void DoOperation()
        {
            maxcount++;
            count_label.Text = (dataField.SelectedIndex + 1).ToString() + "/" + maxcount.ToString();
        }

        private void DLC_ok_BTN_Click(object sender, EventArgs e)
        {
            repeatBTN.Enabled = true;
            string result;
            try
            {
                if (maxcount > dataField.SelectedIndex + 1) CheckHistory();
                result = mainPresenter.DoMath(dataField.SelectedIndex, choise, DLCfield.Text);
                DLCfield.Clear();
                DoOperation();
                dataField.Items.Add(result);
                dataField.SelectedIndex = maxcount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void RepeatBTN_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (maxcount > dataField.SelectedIndex + 1) CheckHistory();
                result = mainPresenter.RepeatMath(dataField.SelectedIndex);
                DLCfield.Clear();
                DoOperation();
                dataField.Items.Add(result);
                dataField.SelectedIndex = maxcount - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }


    }

}


