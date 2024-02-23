using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();  
            }

            Console.WriteLine("----------------------");
            
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats) 
            { 
                eat.Eat();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("manager eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("manager gets salary");
        }

        public void Work()
        {
            Console.WriteLine("manager works");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("worker eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("worker gets salary");
        }

        public void Work()
        {
            Console.WriteLine("worker works");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("robot works");
        }
    }
}
