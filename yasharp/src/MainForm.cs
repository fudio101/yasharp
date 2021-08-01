using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yasharp.src
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WashingPole.autoAccept = true;
            WashingPole.autoLock = true;
        }

        private void pickButton_Click(object sender, EventArgs e)
        {
            if (pickCheckBox.Checked)
            {
                String input = this.textBox.Text;

                if (input.Trim().Length > 0)
                {
                    var args = input.ToLower().Split(' ');

                    WashingPole.champIds.Clear();
                    dataGridView.Rows.Clear();

                    if (args.Length > 0)
                    {
                        var champs = LastBreath.GetPlayableChamps();
                        foreach (var _n in args)
                        {
                            var name = WashingPole.DecodeName(_n).ToLower();
                            var champ = WashingPole.GetChampFromList(champs, name);
                            if (champ != null)
                            {
                                if (!WashingPole.champIds.Contains(champ))
                                {
                                    WashingPole.champIds.Add(champ);
                                    dataGridView.Rows.Add("", champ.name);
                                    MessageBox.Show(WashingPole.msgChampOK + champ.name + ".", "Yasharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show(WashingPole.msgChampNotFound + $"'{_n}'.", "Yasharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void autoCheckBox_Click(object sender, EventArgs e)
        {
            WashingPole.autoAccept = this.acceptCheckBox.Checked;
        }

        private void lockCheckBox_Click(object sender, EventArgs e)
        {
            WashingPole.autoLock = this.lockCheckBox.Checked;

        }

        private void pickCheckBox_Click(object sender, EventArgs e)
        {

            if (!pickCheckBox.Checked)
            {
                dataGridView.Rows.Clear();
                WashingPole.champIds.Clear();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LastBreath.Quit();
            Environment.Exit(0);
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Cells["stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pickButton_Click(sender, e);
            }
        }
    }
}
