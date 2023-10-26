﻿using System;
namespace exersice
{
    enum ПодчиненныеСемена
    {
        Рашид,
        ОИльхам
    }
    enum ПодчиненныеРашида
    {
        Лукас
    }
    enum ПодчиненныеОильхама
    {
        Оркадий
    }
    enum ПодчиненныеОркадия
    {
        Сергей,
        Ильшат,
        Володя
    }
    enum ПодчиненныеВолоди
    {
        Сергей,
        Ильшат,
    }
    enum ПодчиненныеСергея
    {
        Ляйсан
    }
    enum ПодчиненныеЛяйсан
    {
        Марат, 
        Дина, 
        Ильдар, 
        Антон
    }
    enum ПодчиненныеИльшата
    {
        Иваныч
    }
    enum ПодчиненныеИваныча
    {
        Илья,
        Витя,
        Женя
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Семён рашид = new Семён();
            рашид.Подчиненный = ПодчиненныеСемена.Рашид;
            рашид.ВывестиИнформацию();

            Рашид лукас = new Рашид();
            лукас.Подчиненный = ПодчиненныеРашида.Лукас;
            лукас.ВывестиИнформацию();

            Оильхам оркадий = new Оильхам();
            оркадий.Подчиненный = ПодчиненныеОильхама.Оркадий;
            оркадий.ВывестиИнформацию();

            Оркадий сергей = new Оркадий();
            сергей.Подчиненный = ПодчиненныеОркадия.Сергей;
            сергей.ВывестиИнформацию();

            Володя ильшат = new Володя();
            ильшат.Подчиненный = ПодчиненныеВолоди.Ильшат;
            ильшат.ВывестиИнформацию();

            Сергей ляйсан = new Сергей();
            ляйсан.Подчиненный = ПодчиненныеСергея.Ляйсан;
            ляйсан.ВывестиИнформацию();

            Ляйсан марат = new Ляйсан();
            марат.Подчиненный = ПодчиненныеЛяйсан.Марат;
            марат.ВывестиИнформацию();

            Ильшат иваныч = new Ильшат();
            иваныч.Подчиненный = ПодчиненныеИльшата.Иваныч;
            иваныч.ВывестиИнформацию();

            Иваныч илья = new Иваныч();
            илья.Подчиненный = ПодчиненныеИваныча.Илья;
            илья.ВывестиИнформацию(); 

            Console.ReadKey();
        }     
    }
}