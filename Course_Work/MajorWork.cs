using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Course_Work
{
    class MajorWork
    {
        private string Data_first_number; //вхідні дані
        private string Data_second_number; //вхідні дані
        private string Data_third_number; //вхідні дані

        private string SaveFileName;
        private string OpenFileName;

        public bool Modify;

        private int Key;

        public void WriteSaveFileName(string s)
        {
            SaveFileName = s;
        }

        public void WriteOpenFileName(string s)
        {
            OpenFileName = s;
        }

        private DateTime TimeBegin;

        private string Result; // Поле результату

        public void Write_first_number(string D)
        {
            Data_first_number = D;
        }
        public void Write_second_number(string D)
        {
            Data_second_number = D;
        }
        public void Write_third_number(string D)
        {
            Data_third_number = D;
        }

        // метод відображення результату
        public string Read()
        {
            return Result;
        }

        public void NewRec()
        {
            this.Data_first_number = "";
            this.Result = null;
        }

        public void SetTime()
        {
            TimeBegin = DateTime.Now;
        }

        public DateTime GetTime()
        {
            return TimeBegin;
        }

        public void ReadFromFile (System.Windows.Forms.DataGridView DG)
        {
            try
            {
                if(!File.Exists(this.OpenFileName))
                {
                    MessageBox.Show("There is no file with such name");
                }

                Stream S;

                S = File.Open(this.OpenFileName, FileMode.Open);

                Buffer D;
                object O;

                BinaryFormatter BF = new BinaryFormatter();

                System.Data.DataTable MT = new System.Data.DataTable();
                System.Data.DataColumn cKey = new System.Data.DataColumn("Ключ");
                System.Data.DataColumn cInput = new System.Data.DataColumn("Вхідні дані");
                System.Data.DataColumn cResult = new System.Data.DataColumn("Результат");

                MT.Columns.Add(cKey);
                MT.Columns.Add(cInput);
                MT.Columns.Add(cResult);



                while (S.Position <S.Length)
                {
                    O = BF.Deserialize(S);
                    D = O as Buffer;
                    if (D == null)
                        break;

                    System.Data.DataRow MR;
                    MR = MT.NewRow();
                    MR["Ключ"] = D.Key;
                    MR["Вхідні дані"] = D.Data;
                    MR["Результат"] = D.Result;
                    MT.Rows.Add(MR);
                }

                DG.DataSource = MT;

                S.Close();
            }
            catch
            {
                MessageBox.Show("File Error");
            }

        }
        public bool SaveFileNameExists()
        {
            if (this.SaveFileName == null)
                return false;
            else return true;
        }

        public void Generator()
        {
            try
            {
                if (!File.Exists(this.SaveFileName))
                {
                    Key = 1;
                    return;
                }

                Stream S;

                S = File.Open(this.SaveFileName, FileMode.Open);

                Buffer D;
                object O;

                BinaryFormatter BF = new BinaryFormatter();

                while (S.Position < S.Length)
                {
                    O = BF.Deserialize(S);
                    D = O as Buffer;
                    if (D == null)
                        break;
                    Key = D.Key;
                }

                Key++;
                S.Close();
            }
            catch
            {
                MessageBox.Show("File Error");
            }

        }

        public void SaveToFile()
        {
            if (!this.Modify)
                return;

            try
            {
                Stream S;
                if (File.Exists(this.SaveFileName))
                    S = File.Open(this.SaveFileName, FileMode.Append);
                else
                    S = File.Open(this.SaveFileName, FileMode.Create);

                Buffer D = new Buffer();
                D.Data = this.Data_first_number;
                D.Result = this.Result;
                D.Key = this.Key;
                Key++;

                BinaryFormatter BF = new BinaryFormatter();
                BF.Serialize(S, D);
                S.Flush();
                S.Close();
            }
            catch
            {
                MessageBox.Show("Error with file");
            }

            Modify = false;
        }



        //Визначити найбільше середнє арифметичне чисел, що становлять три
        //заданих числа.
        public void Task()
        {
            double first = Convert.ToDouble(Data_first_number);
            double second = Convert.ToDouble(Data_second_number);
            double third = Convert.ToDouble(Data_third_number);

            double result = (first + second + third) / 3;

            Result = Convert.ToString(result);

            this.Modify = true;
        }



    }
}
