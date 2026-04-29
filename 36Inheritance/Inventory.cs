using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _37Inventory
{

    public interface IInventory
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    public class Inventory 
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

    public class Vehicle : Inventory , IRent ,IBuy
    {
        public int DealerFee { get; set; }

        public void Purchase()
        {
            Quantity -= 1;
            Console.WriteLine($"{ProductName} has been bought");
        }

        public void Rent()
        {
            Quantity -= 1;
            Console.WriteLine($"{ProductName} has been rented");
        }

        public void ReturnItem()
        {
            Quantity += 1;
            Console.WriteLine($"{ProductName} has been returned");
        }
    }

    public class Book : Inventory, IBuy
    {
        public int PageNo { get; set; }

        public void Purchase()
        {
            Quantity -= 1;
            Console.WriteLine($"{ProductName} has been bought");
        }
    }

    public class Excavator : Inventory, IRent
    {
        public void dig()
        {
            Console.WriteLine("JCB KI KHUDAI");
        }

        public void Rent()
        {
            Quantity -= 1;
            Console.WriteLine($"{ProductName} has been rented");
        }

        public void ReturnItem()
        {
            Quantity += 1;
            Console.WriteLine($"{ProductName} has been returned");
        }
    }
    public interface IRent : IInventory
    {
        void Rent();

        void ReturnItem();
    }

    public interface IBuy : IInventory
    {
        void Purchase();
    }
}
