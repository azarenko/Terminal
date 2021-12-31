using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _openPortA_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortA.IsOpen)
                    serialPortA.Open();
                else
                {
                    MessageBox.Show("Port already opened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _closePortA_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortA.IsOpen)
                    serialPortA.Close();
                else
                {
                    MessageBox.Show("Port already closed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _openPortB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortB.IsOpen)
                    serialPortB.Open();
                else
                {
                    MessageBox.Show("Port already opened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _closePortB_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortB.IsOpen)
                    serialPortB.Close();
                else
                {
                    MessageBox.Show("Port already closed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
