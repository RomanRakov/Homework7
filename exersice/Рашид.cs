﻿using System;
namespace exersice
{
    class Рашид
    {
        private ПодчиненныеРашида подчиненный;
        public ПодчиненныеРашида Подчиненный
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
            Console.WriteLine($"\n{подчиненный} получил от Рашида задачу предоставить отчет о работе бухгалтерии\n{подчиненный} берет задачу");
        }
    }
}
