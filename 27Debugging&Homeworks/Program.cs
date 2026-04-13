using _27Debugging_Homeworks;

//** Console app with for loop that multiplies num by five and adds to total each time.
//int total = 0;
//for (int i = 0; i < 10; i++)
//{
//    total += 5 * i;
//}
//Console.WriteLine(total);



///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~///



//**app that throw exception after five iterations, catch exception.
//for(int i =0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    try
//    {
//        if (i == 4)
//        {
//            throw new Exception();
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex);
//    }
//}


///~~~~~~~~~~~~~~~ADVANCE EXCEPTIONS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~///

//AdvException.CatchException();



///~~~~~~~~~~~~~~~~~~ADVANCE BREAKPOINTS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~///
for (int i =1; i<1000; i++)
{
    //Console.WriteLine(i);
    try
    {
        if (i == 73)
        {
            throw new Exception("73 is error");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

