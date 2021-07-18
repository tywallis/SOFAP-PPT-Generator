using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace SOFAP_PPT_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
        }

        private void songNumberInput_TextChanged(object sender, EventArgs e)
        {
            addPreMadeButton.Visible = false;
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
            addPreMadeButton.Visible = true;
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(songNumberInput.Text);
        }

        private void addPreMadeButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(preMadeSlidesSelector.SelectedItem.ToString());
        }

        private void removeSlidesButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = this.listBox1.IndexFromPoint(point);
            if (index < 0) index = this.listBox1.Items.Count - 1;
            object data = e.Data.GetData(typeof(String));
            this.listBox1.Items.Remove(data);
            this.listBox1.Items.Insert(index, data);
        }
    }
}
