using _00_Morning_Challenge.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Morning_Challenge
{
    public class ProgramUI
    {
        private readonly OrdersRepo _repo = new OrdersRepo();
        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool runMenu = true;
            while (runMenu)
            {
                Console.Clear();
                Console.WriteLine("1.See all orders\n+" +
                "2.See an order\n+" +
                "3.Add an order\n+" +
                "4.Remove an order\n+" +
                "5.Exit");

                switch(Console.ReadLine())
                {
                    case "1":
                        VeiwAllOrders(); //read
                        break;
                    case "2":
                        VeiwAnOrders(); //read
                        break;
                    case "3":
                        AddOrder(); //Add
                        break;
                    case "4":
                        RemoveOrder(); //Delete
                        break;
                    case "5":
                    case "exit":
                    case "e":
                        runMenu = false;
                        break;

                }
            }
        }

        private void GetOrders()
        {
            Console.Clear();
            List<OrdersRepo> listOfOrders = _repo.GetOrders();
           
        }


    }
}
