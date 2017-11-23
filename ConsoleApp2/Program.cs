using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Написать программу, которая считывает символы с клавиатуры, 
пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.
2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
		3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено число 345, то программа должна вывести число 543.
*/
namespace ConsoleApp2
{
    class Program
    {
        static void Task1() {
            int countTab = 0;
            char s ='0';
            while(s!='.')
            {
                s = char.Parse(Console.ReadLine());
                if(s==' ')
                { countTab++; }
            }
            Console.WriteLine(countTab);
        }
        static void Task2()
        {
            Console.WriteLine("take 6 number: ");
            int number = int.Parse(Console.ReadLine());
            int number1 = number / 100000;
            int number2 = number/ 10000 - number1 * 10;
            int number3 = number / 1000 - number / 10000 * 10;
            int number4 = number / 100 - number / 1000 * 10;
            int number5 = number / 10 - number/ 100 * 10;
            int number6 = number % 10;
            if(number1+number2+number3==number4+number5+number6)
            {
                Console.WriteLine(" magic number! ");
            }
            else
            {
                Console.WriteLine(" not magic( ");
            }
            

        }
        static void Task3()
        {
            char s = char.Parse(Console.ReadLine());
            if (s > 'a' && s <'z')
            {
                s -= (char)32;
            }
            else if(s>'A'&&s<'Z')
            {
                s += (char)32;
            }
            Console.WriteLine(s);
        }
        static void Task4()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int i=a;i<=b;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
        }
        static void Task5()
        {
            string number = "";
            int ten = 10;
            int a = int.Parse(Console.ReadLine());
            string b = a.ToString();
            for(int i=0;i<b.Length;i++)
            {
                number += a % ten;a /= ten;
            }
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Console.ReadLine();
        }
    }
}
