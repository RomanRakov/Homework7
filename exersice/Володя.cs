using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice
{
    class Володя
    {
        private ПодчиненныеВолоди подчиненный;
        public ПодчиненныеВолоди Подчиненный
        {
            get
            {
                return подчиненный;
            }
            set
            {
                подчиненный = value;
            }
        }
        public void ВывестиИнформацию()
        {
            Console.WriteLine($"\n{подчиненный} получил от Володи задачу предоставить отчет о работе своего сектора\n{подчиненный} берет задачу");
        }
    }
}
