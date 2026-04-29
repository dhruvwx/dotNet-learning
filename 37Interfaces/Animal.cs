using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37Interfaces
{
    internal class Animal : IRun
    {
        public void Legs()
        {
            
        }

        public void Walk()
        {
            
        }

        public void Species()
        {

        }
    }
}

public interface IRun
{
    void Legs();

    void Walk();
}