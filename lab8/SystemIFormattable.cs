using System;
namespace lab8
{
    class SystemIFormattable
    {
        public static void systemiformattable(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable formattableobj = obj as IFormattable;
                if (formattableobj != null)
                {
                    Console.WriteLine("Входной параметр метод реализует интерфейс System.IFormattable");
                }
            }
            else
            {
                Console.WriteLine("Входной параметр метода не реализует интерфейс System.IFormattable.");
            }
        }
    }
}
