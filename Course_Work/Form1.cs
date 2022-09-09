using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class Form1 : Form
    {
        private bool Mode; // Режим дозволу / заборони введення даних

        public Form1()
        {
            this.Mode = true;
            InitializeComponent();
        }






        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Attention. 25 second has passed. Do something!", "Warning");
            tClock.Start();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if(Mode == true)
            {
                bStart.Text = "Стоп";
                tClock.Start();
                tbInput.Enabled = true;
                Mode = false;
                tbInput.Focus();
            }
            else
            {
                bStart.Text = "Старт";
                tClock.Stop();
                tbInput.Enabled = false;
                Mode = true;
            }

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();

            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') | (e.KeyChar >= 'A' && e.KeyChar <= 'Z') | (e.KeyChar == (char) 8) | (e.KeyChar == ' '))
            {
               
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("Please enter only alphabetic chars", "ERROR");
                tClock.Start();
                e.KeyChar = (char)0;
            }


            
        }
    }
}
