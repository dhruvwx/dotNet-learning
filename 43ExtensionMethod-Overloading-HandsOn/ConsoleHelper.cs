public static class ConsoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";


        if (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }

        return output;

    }

    public static int RequestInt(this string message , int max , int min)
    {
        return message.RequestInt(true, min, max);
    }
    public static int RequestInt(this string message)
    {

        return message.RequestInt(false);
        ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //return RequestInt(message , false);

        ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //bool isValid = false;
        //int output = 0;

        //while (isValid == false)
        //{
        //    Console.Write(message);
        //    isValid = int.TryParse(Console.ReadLine(), out output);

        //}
        //return output;
    }

    public static int RequestInt(this string message, bool useMinMax, int min = 0, int max = 0)
    { 
        bool isValid = false;
        int output = 0;
        bool isRangeValid = true;

        while (isValid == false || isRangeValid == false)
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out output);

            if (useMinMax == true)
            {
                isRangeValid = (output >= min && output <= max); //below code does the same

                //if(output>=min &&  output<=max)
                //{
                //    isRangeValid = true;
                //}
                //else 
                //{ isRangeValid = false; }
            }
        }

        return output;
    }
}

