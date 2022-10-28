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
        private MajorWork MajorObject;

        public Form1()
        {
            this.Mode = true;
            MajorObject = new MajorWork();
            MajorObject.SetTime();
            MajorObject.Modify = false;

            About A = new About();
            A.tAbout.Start();
            A.ShowDialog();


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
                пускToolStripMenuItem.Text = "Стоп";
                bStart.Text = "Стоп";
                tClock.Start();
                tbInput_first_num.Enabled = true;
                tbInput_second_num.Enabled = true;
                tbInput_third_num.Enabled = true;
                Mode = false;
                tbInput_first_num.Focus();
            }
            else
            {
                пускToolStripMenuItem.Text = "Пуск";
                bStart.Text = "Пуск";
                tClock.Stop();
                tbInput_first_num.Enabled = false;
                tbInput_second_num.Enabled = false;
                tbInput_third_num.Enabled = false;
                Mode = true;
                MajorObject.Write_first_number(tbInput_first_num.Text);
                MajorObject.Write_second_number(tbInput_second_num.Text);
                MajorObject.Write_third_number(tbInput_third_num.Text);


                MajorObject.Task();
                label1.Text = MajorObject.Read();

            }

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') | (e.KeyChar == (char) 8) )
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

        private void tbInput_second_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') | (e.KeyChar == (char)8) )
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

        private void tbInput_third_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') | (e.KeyChar == (char)8))
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s;
            s = (DateTime.Now - MajorObject.GetTime()).ToString();

            MessageBox.Show(s, "Час роботи програми");
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.ShowDialog();
        }

        private void проНакопичувачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] disks = System.IO.Directory.GetLogicalDrives();

            string disk = "";
            for (int i = 0; i < disks.Length; i++)
            {
                try
                {
                    System.IO.DriveInfo D = new System.IO.DriveInfo(disks[i]);
                    disk += D.Name + "-" + D.TotalSize.ToString() + "-" + D.TotalFreeSpace.ToString() + (char)13;// змінній присвоюється ім’я диска, загальна кількість місця и вільне                     місце на диску
                }
                catch
                {
                    disk += disks[i] + "- не готовий" + (char)13; // якщо пристрій не готовий, то виведення на екран ім’я пристрою і повідомлення «не готовий»
                }
            }
            MessageBox.Show(disk, "Накопичувачі");
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdOpen.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofdOpen.FileName);
            }
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sfdSave.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName);
                MajorObject.SaveToFile();
            }
        }
    }
}
