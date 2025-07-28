using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SOLID, Interface Segregation
            IWorker[] workers = new IWorker[3]
            {
                    new Manager(),
                    new Worker(),
                    new Robot()
            };
            //Tüm elemanlara çalış(Work) dedim.
            foreach (var worker in workers)
            {
                worker.Work();
            }



            Console.WriteLine();

            //IEat çalıştırılması:
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach(var items in eats) 
            {
                items.Eat();
            }

            Console.WriteLine();

            //ISalary çalıştırılması
            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }

    //Multiple İmplement
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

    //---------------------------------------
    class Manager : IWorker, IEat, ISalary
    {

        public void Work()
        {
            Console.WriteLine("Manager Working !");
        }
        public void Eat()
        {
            Console.WriteLine("Manager eating !");

        }
        public void GetSalary()
        {
            Console.WriteLine("Manager got salary !");

        }
    }
    class Worker : IWorker, IEat, ISalary
    {

        public void Work()
        {
            Console.WriteLine("Worker Working !");

        }
        public void Eat()
        {
            Console.WriteLine("Worker eating !");

        }
        public void GetSalary()
        {
            Console.WriteLine("Worker got salary!");

        }
    }

    class Robot : IWorker
    {

        public void Work()
        {
            Console.WriteLine("Robot Working !");

        }

    }

}
