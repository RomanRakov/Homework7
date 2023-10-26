using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    enum ТипБанковскогоСчета
    {
        Текущий,
        Сберегательный,
        Кредитный
    }
    internal class Program
    {
        public static void SearchMail(ref string s)
        {
            int index = s.IndexOf('#');
            if (index != -1)
            {
                s = s.Substring(index + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лаборотная работа\nУпражнение 8.1\nВ класс банковский счет добавить метод, который переводит деньги с одного счета на другой");
            БанковскийСчет счет = new БанковскийСчет();
            счет.Number = 1234567890;
            счет.Balance = 1234;
            счет.Type = ТипБанковскогоСчета.Текущий;            
            БанковскийСчет счет2 = new БанковскийСчет();
            счет2.Number = 1234567899;
            счет2.Balance = 12;
            счет2.Type = ТипБанковскогоСчета.Текущий;
            счет.ПеревестиДеньги(счет,счет2,1000);
            Console.WriteLine();
            счет.ВывестиИнформацию();
            Console.WriteLine();
            счет2.ВывестиИнформацию();

            Console.WriteLine("\nУпражнение 8.2\nРеализовать метод,который переворачивает строку");
            string result = Reverse.reverse("eftgwfygwf");
            Console.WriteLine(result);

            Console.WriteLine("\nУпражнение 8.3\nНаписать программу, которая создает новый файл, в котором текст первого файла записан заглавными буквами");
            Console.WriteLine("Введите путь файла:");
            string fileName = Console.ReadLine();
            try
            {
                StreamReader reader = File.OpenText(fileName);
                string outputFileName = fileName + ".upper";
                StreamWriter writer = File.CreateText(outputFileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    writer.WriteLine(line);
                }
                reader.Close();
                writer.Close();
                Console.WriteLine($"Файл '{outputFileName}' успешно создан");
            }
            catch
            {
                Console.WriteLine($"Файл '{fileName}' не существует");
            }

            Console.WriteLine("\nУпражнение 8.4\nРеализовать метод,который проверяет реализует ли входной параметр метода интерфейс System.IFormattable");
            object some = "rgwjkgw";
            SystemIFormattable.systemiformattable(some);

            Console.WriteLine("\nДомашнее задание 8.2\nРеализовать метод,который проверяет реализует ли входной параметр метода интерфейс System.IFormattable.");            
            List<Song> songs = new List<Song>();
            songs.Add(new Song("90", "Pompeya"));
            songs.Add(new Song("Something in the way", "Nirvana"));
            songs.Add(new Song("Stressed out", "Twenty One Pilots"));
            songs.Add(new Song("In the End", "Linkin Park"));
            foreach (Song song in songs)
            {
                song.Info();
            }
            Song firstSong = songs[0];
            Song secondSong = songs[1];
            bool equal = firstSong.Equals(secondSong);
            Console.WriteLine("Первая и вторая песни равны: {0}", equal);
            Console.ReadKey();
        }
    }
}
