using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actors_Trivia
{
    public partial class Home : Form
    {
       
        
        public Home()
        {
            InitializeComponent();
        }

       




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void topHomeBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form ActorManager = new Form();
            ActorManager.Show();
        }

        private void AddFromCode(object sender, EventArgs e)
        {
            lstItems.Items.Add

            else (txtInput.Text != "")
            {

                lstItems.Items.Add(txtInput.Text);

            }
        }

        private void AddFromArray(object sender, EventArgs e)
        {
            string[] data = { "D", "E", "F" };
            lstItems.Items.AddRange(data);
        }

        private void getSelectedIndex(object sender, EventArgs e)
        {
            MessageBox.Show(lstItems.SelectedIndex.ToString());

        }

        private void getSelectedItem(object sender, EventArgs e)
        {
            MessageBox.Show(lstItems.SelectedItem.ToString());
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AccessActorManger(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

