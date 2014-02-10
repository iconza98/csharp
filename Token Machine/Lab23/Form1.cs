using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Lab23
{
    

    public partial class Form1 : Form
    {
        const int FULL = 100;
        // a class level reference to a token machine
        private MyTokenMachine tm;
        bool soundSetting = true;

        public Form1()
        {
            InitializeComponent();

            // Create a token machine object
            tm = new MyTokenMachine();
            tm.Reset();
           
        }

        private void btn_getToken_Click(object sender, EventArgs e)
        {
            tm.GetToken();
            txtBox_qrtrs.Text = Convert.ToString(tm.Quarters);
            txtBox_tokens.Text = Convert.ToString(tm.Tokens);

            if (soundSetting != false)
            {
                SoundPlayer coins = new SoundPlayer(Resources.Resource1.smb3_coin);
                coins.Play();
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tm.Reset();
            txtBox_qrtrs.Text = Convert.ToString(tm.Quarters);
            txtBox_tokens.Text = Convert.ToString(tm.Tokens);
            
            if (soundSetting != false)
                SystemSounds.Asterisk.Play();   

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ikani Samani\nCS1400-003\nLab 23");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            soundSetting = checkBox1.Checked == true ? true : false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
