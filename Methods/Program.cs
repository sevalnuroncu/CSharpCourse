using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine("----------------------");
            var result=Add2(20, 30);
            Console.WriteLine(result);
            Console.WriteLine("----------------------");
            var result2 = Add3(40);
            Console.WriteLine(result2);
            Console.WriteLine("----------------------");
            int number1 = 20;
            int number2 = 100;
            var result3=Add4(number1, number2);
            Console.WriteLine("Result3: "+result3);
            Console.WriteLine("Number1: "+number1);
            Console.WriteLine("----------------------");
            int number3 = 20;
            int number4 = 100;
            var result4 = Add5(ref number3, number4);
            Console.WriteLine("Result4: " + result4);
            Console.WriteLine("Number3: " + number3);
            Console.WriteLine("----------------------");
            int number5;
            int number6 = 100;
            var result5 = Add6(out number5, number6);
            Console.WriteLine("Result5: " + result5);
            Console.WriteLine("Number5: " + number5);
            Console.WriteLine("----------------------");
            Console.WriteLine("Multiply: " + Multiply(2, 4));
            Console.WriteLine("----------------------");
            Console.WriteLine("Multiply: " + Multiply(2, 4,5));
            Console.WriteLine("----------------------");
            Console.WriteLine("Sum: "+Add7(1,2,3,4,5,6));//1 ilk parametredir. Diğerleri params'a ait.

            Console.ReadLine();
        }
        //method oluşturma
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        //parametreli method
        static int Add2(int number1, int number2)
        {
            var result=number1+number2;
            return result;
        }

        //default parametre ile 
        //default değerlerin her zaman methodun son parametresi olması gerekir
        //birden fazla default değer verilebir
        static int Add3(int number1=80, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        //DEğer tip
        static int Add4(int number1, int number2)
        {
            number1 = 30;
            return number1+number2;
        }

        //ref keyword ile değertipi referans tip gibi kullanmak
        //ref yerine out keyword de kullanılabilir
        //ref de farklı olarak number1 set edilmelidir
        //out olarak gönderilen parametrede method içinde set edilmelidir
        static int Add5(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //out
        static int Add6(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2* number3;
        }

        //params keyword
        //istediğimiz kadar parametreyi dizi şeklinde göndermemize yarar
        //parametre sayısına göre overload method yazmamıza gerek kalmaz
        //params son parametre olmalı
        static int Add7(int number, params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
