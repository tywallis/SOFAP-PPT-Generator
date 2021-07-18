using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFAP_PPT_Generator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void songNumberInput_TextChanged(object sender, EventArgs e)
        {
            addPreMadeButton.Visible = false;
            addSongNotInBookButton.Visible = false;
            addSongButton.Visible = true;
            if (System.Text.RegularExpressions.Regex.IsMatch(songNumberInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                songNumberInput.Text = songNumberInput.Text.Remove(songNumberInput.Text.Length - 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            songNumberInput.Text = "";
            addSongButton.Visible = false;
            addSongNotInBookButton.Visible = false;
            addPreMadeButton.Visible = true;
        }

        private void notInBookSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            songNumberInput.Text = "";
            addSongButton.Visible = false;
            addPreMadeButton.Visible = false;
            addSongNotInBookButton.Visible = true;
        }
    }
}
