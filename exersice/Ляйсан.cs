using System;
namespace exersice
{
    class Ляйсан
    {
        private ПодчиненныеЛяйсан подчиненный;
        public ПодчиненныеЛяйсан Подчиненный
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
            Console.WriteLine($"\n{подчиненный} получил от Ляйсан задачу: разработать программу.\n{подчиненный} берет задачу");
        }
    }
}
