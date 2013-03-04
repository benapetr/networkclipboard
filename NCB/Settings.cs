using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NCB
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Top = groupBox2.Top;
            groupBox3.Height = groupBox2.Height;
            comboBox2.Text = Configuration.ServerPort.ToString();
            comboBox3.Text = Configuration.ServerPort.ToString();
            this.Height = 280;
        }

        public void Select(bool Server)
        {
            if (Server)
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;
                return;
            }
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Select(true);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Select(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Core.ServerThread = new System.Threading.Thread(Core.CreateServer);
                Core.ServerThread.Start();
            }
            catch (Exception fail)
            {
                Core.handleException(fail);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();

            }
            catch (Exception fail)
            {
                Core.handleException(fail);
            }
        }
    }
}
