using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoding
{
    class Coding
    {

        //public string messege = "";
        private char carriage; //объявление приватных переменных которые используются только внутри этого класса
        private string kodmessege = "";
        private int key;
        private string messege = "";
        // public int key;

        //классы зваписи и чтения ключей
        public void Setkey(int k)
        {
            key= k;
        }
        public int Getkey()
        {
            return key;
        }
        public void Setmessege()
        {
            messege = Console.ReadLine(); //Запись в строку введённого сообщения

            if (messege.Length > 250)
            {
                Console.WriteLine("Введено более 250 символов");
                Setmessege(); //попробую в случае неверных данных снова вызывать этот метод
            };

        }
        //метода get не делаю для защиты


        public string Cmesseege() ///создание публичного метода, который будет возвращать строку
        {
            for (int i = 0; i < messege.Length; i++) //разбиваем строку на сиволы
            {
                carriage = (char)(messege[i] ^ key);  //делаем операцию поразрядно исключающего лии для каждого символа приводим полученное число в чар и записываем в переменную
                kodmessege = kodmessege + carriage; // записывем символы в новую строку, тюкю при обращении к элекментам строки в неё нельзя делать запись
            }
            //декодирование
            /*for (int i = 0; i < str.Length; i++)
            {
                carriage = (char)(kodmessege[i] ^ k); 
                kodmessege = kodmessege + carriage;
            }*/
            return kodmessege;
        }
    }
}
