using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            //if 
            if (number==10)
            {
                Console.WriteLine("Number is 10");

            }else if(number==20){
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            //single line if
            number = 10;
            Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");
            
            
            //switch
            number = 11;
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine( "Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            Console.WriteLine("-------------------------");

            //Bir sayının 100'lük dilimlerde nereye geldiğini bulma
            number = 201;
            if (number>=0 && number<=100)
            {
                Console.WriteLine("Number is between 0-100");                
            }else if (number>=100 && number<=200)
            {
                Console.WriteLine("Number is between 101-200");
            }else if(number>200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 101-200");
            }

            //içiçe if
            number = 11;
            if (number<100)
            {
                if (number>=90 && number>95)
                {
                    Console.WriteLine("number is between 90-95");
                }
                else
                {
                    Console.WriteLine("number is less than 90");
                }
            }


            Console.ReadLine();

        }
    }
}
