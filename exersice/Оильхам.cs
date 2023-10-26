using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice
{
    class Оильхам
    {
        private ПодчиненныеОильхама подчиненный;
        public ПодчиненныеОильхама Подчиненный
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
            Console.WriteLine($"\n{подчиненный} получил от Оильхама задачу предоставить отчет о работе отдела информационных технологий.\n{подчиненный} берет задачу");
        }
    }
}
