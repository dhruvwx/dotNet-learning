using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Debugging_Homeworks
{
    internal class AdvException
    {
        internal static void CatchException()
        {
            string name = "";
            try
            {
                Console.WriteLine("enter your name:  ");
                name = Console.ReadLine();

                AdvException.Undeclared();

                AdvException.IfElse(name);

                //AdvException.Invalid();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine("this is not implemented exception");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
            //IF ANYTHING EXCEPT SHARMA IS TYPED IT WILL GO IN GENERAL EXCEPTON FOR SHARMA ONLY THIS WILL RUN
            catch (Exception ex) when (name.ToLower() == "sharma")
            {
                Console.WriteLine("you are not dhruv SHARMA");

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex);
                Console.WriteLine("this is the general exception");
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("it will always run even if fail or pass");
            }

        }
        internal static void Invalid()
        {
            throw new InvalidOperationException("this is an invalid operation exception");
            //at ex.msg this will go 
        }

        internal static void Undeclared()
        {
            Console.WriteLine("works");
            //throw new NotImplementedException();
            //at ex.msg pre built msg is built
        }

        internal static void IfElse(string names)
        {
            if(names.ToLower() == "dhruv")
            {
                throw new InsufficientMemoryException("Dhruv is too handsome");
            }
            else
            {
                throw new IndexOutOfRangeException("you are not dhruv");
            } 
        }
    }
}
