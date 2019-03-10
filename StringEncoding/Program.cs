using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //добавть декодирующий блок, вынести все условия в отдельные классы, сделать инкапсуляцию  
          
            Coding report = new Coding(); //созздание экземпляра класса
            Console.WriteLine("Введите строку для кодирования, не блоее 250 сиволов:");
            report.Setmessege();
            Console.WriteLine("Введите ключ");
            //key = Convert.ToInt32(Console.ReadLine()); //запись в int введёного значение, которое было преобразовано в инт
            report.Setkey(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine(report.Getkey() + report.Cmesseege()); //вывод сообщения, передачу в метод класса исходной строки и ключа
            Console.ReadKey();
        }
    }
}
