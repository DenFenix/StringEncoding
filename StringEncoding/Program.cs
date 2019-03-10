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
            string messege = "";
            int key;

            Coding report = new Coding(); //созздание экземпляра класса
            Console.WriteLine("Введите строку для кодирования, не блоее 250 сиволов:");
            messege = Console.ReadLine(); //Запись в строку введённого сообщения

            if (messege.Length > 250) 
            {
                Console.WriteLine("Введено более 250 символов");
                messege = Console.ReadLine();
            };

            Console.WriteLine("Введите ключ");

            key = Convert.ToInt32(Console.ReadLine()); //запись в int введёного значение, которое было преобразовано в инт
            
            
            Console.WriteLine(key + report.Cmesseege(messege, key)); //вывод сообщения, передачу в метод класса исходной строки и ключа
            Console.ReadKey();
        }
    }
}
