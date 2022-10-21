using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    class MajorWork
    {
        private string Data_first_number; //вхідні дані
        private string Data_second_number; //вхідні дані
        private string Data_third_number; //вхідні дані

        private string SaveFileName;
        private string OpenFileName;

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

        public void SetTime()
        {
            TimeBegin = DateTime.Now;
        }

        public DateTime GetTime()
        {
            return TimeBegin;
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
        }



    }
}
