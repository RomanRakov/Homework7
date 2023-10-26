using System;
namespace exersice
{
    class Иваныч
    {
        private ПодчиненныеИваныча подчиненный;
        public ПодчиненныеИваныча Подчиненный
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
            Console.WriteLine($"\n{подчиненный} получил от Иваныча задачу: настроить сеть.\n{подчиненный} берет задачу");
        }
    }
}
