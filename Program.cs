using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{

    class cars
    {
        protected string name;
        protected int priceforrentacar;
        public int setdetailscars(int car01,int car02,int car03)
        {
            
            Console.WriteLine("--------*******WELCOME TO RENT A CAR--------*******");
            Console.WriteLine();
            Console.WriteLine("Whats your name sir/madam");
            name = Console.ReadLine();

            Console.WriteLine("Welcome Mr/Mrs."+name);
            Console.WriteLine();
            Console.WriteLine("WE HAVE---"); 
            Console.WriteLine();

            int carno;
            Console.WriteLine("----[1] FORD GT----     ----[2] NISSAN GTR----     ----[3] LAMBORGHINI HURCAN----");
            Console.WriteLine();
            Console.WriteLine("What car would perfect for you Mr/Mrs." + name);
            carno=Convert.ToInt32(Console.ReadLine());

            if (carno == 1)
            {
                Console.WriteLine("                         Top Speed");
                Console.WriteLine("                        ------|---");
                Console.WriteLine("                        Accelaration");
                Console.WriteLine("FORD GT                 --------|--");
                Console.WriteLine("                          Handling");
                Console.WriteLine("                        ------|-----");
                Console.WriteLine();
                Console.WriteLine("------EXCELENT " + name + " GERMENS ALWAYS DO THEIR JOB TO THE FINEST ;)------");
                Console.WriteLine("                                              PRICE-------$" + car01);

                return car01;
            }
            else if (carno == 2)
            {
                Console.WriteLine("                         Top Speed");
                Console.WriteLine("                        ----------|-");
                Console.WriteLine("                        Accelaration");
                Console.WriteLine("NISSAN GTR               ---------|-");
                Console.WriteLine("                          Handling");
                Console.WriteLine("                        ---------|--");
                Console.WriteLine();
                Console.WriteLine("------BRAVO " + name + " NISSAN NO WORDS TO SAY ALWAYS THE BEST XD------");
                Console.WriteLine("                                              PRICE-------$" + car02);
                return car02;
            }
            else if (carno == 3)
            {
                Console.WriteLine("                         Top Speed");
                Console.WriteLine("                        ----------|-");
                Console.WriteLine("                        Accelaration");
                Console.WriteLine("LAMBORGHINI HURCAN       ------|-----");
                Console.WriteLine("                          Handling");
                Console.WriteLine("                        ---------|--");
                Console.WriteLine();
                Console.WriteLine("------NICE choice " + name+ " ITALY DOES THEIR JOB CLEAN ;)------");
                Console.WriteLine("                                              PRICE-------$" + car03);
                return car03;
            }
            return 0;
   
        }
    }

    class price:cars
    {
        int numberofdays;
        
        public void setnumberofdays()
        {
            Console.WriteLine();
            Console.WriteLine("How many to months Would you like to rent sir/madam");
            numberofdays=Convert.ToInt32(Console.ReadLine());


        }
        public void calpayment(int priceforrentacar)
        {
            Console.WriteLine();
            Console.WriteLine("-------YOUR PAYMENT WOULD BE $"+ numberofdays*priceforrentacar+"-------");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cars cars = new cars();
            price c1=new price();
            int priceforrentacar;

            priceforrentacar = cars.setdetailscars(1200000,500000,6000000);
            c1.setnumberofdays();
            c1.calpayment(priceforrentacar);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------HAVE A GREAT DAY-----------");


            Console.ReadKey();
        }
    }
}
