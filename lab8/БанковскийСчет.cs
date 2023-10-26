using System;
namespace lab8
{
    class БанковскийСчет
    {
        private uint number;
        private double balance;
        private ТипБанковскогоСчета type;
        public uint Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public ТипБанковскогоСчета Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public void ПеревестиДеньги(БанковскийСчет отправитель, БанковскийСчет получатель, double сумма)
        {
            if (сумма > отправитель.balance)
            {
                Console.WriteLine("Недостаточно средств");
                return;
            }
            else 
            {
                отправитель.balance -= сумма;
                получатель.balance += сумма;
                Console.WriteLine("Перевод успешно выполнен");
            }
        }
        public void ВывестиИнформацию()
        {
            Console.WriteLine($"Номер счета: {number}\nБаланс: {balance}\nТип счета: {type}");
        }
    }
}

