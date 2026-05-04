using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44Generics
{
    public class PrintItemModel
    {
        public static void PrintItem<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public class Box<T>
    {
        public T Value { get; set; }

        public void Show()
        {
            Console.WriteLine(Value);
        }
    }


    public interface IEntity
    {
      int Id { get; set; }
    }

    public class User : IEntity
    {
        public string Name { get; set; }
        public int Id { get; set ; }
    }

    public class UseGeneric<T> where T : IEntity
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void PrintId()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
