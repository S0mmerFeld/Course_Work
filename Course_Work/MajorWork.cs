using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    class MajorWork
    {
        private string Data; //вхідні дані

        private string Result; // Поле результату

        public void Write(string D)
        {
            Data = D;
        }

        // метод відображення результату
        public string Read()
        {
            return Result;
        }

        public void Task()
        {
            Result = Convert.ToString(Data.Length);
        }



    }
}
