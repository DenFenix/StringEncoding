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
       // public int key;
        public string Cmesseege(string str, int k) ///создание публичного метода, который будет возвращать строку
        {
            for (int i = 0; i < str.Length; i++) //разбиваем строку на сиволы
            {
                carriage = (char)(str[i] ^ k);  //делаем операцию поразрядно исключающего лии для каждого символа приводим полученное число в чар и записываем в переменную
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
