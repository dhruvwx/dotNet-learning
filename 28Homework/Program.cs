


Debugg.Logic();
internal class Debugg
{
    internal static void Logic()
    {

        double i = W(45);
        Console.WriteLine(i);
        Console.ReadLine();
    }

    internal static double W(double e)
    {
        double n = 1;
        n = J(e) + 4;
        return n;
    }
    internal static double P(double v)
    {
        double o = 0;
        o = F(v) + 2;
        return o;
    }
    internal static double F(double x)
    {
        double y = 0;
        y = x / 5;
        return y;
    }
    //here 3(input) / 5 is giving 0 therefore avg value issue has to be double

    internal static double J(double a)
    {
        double c = 0;

        a = a - 1;

        c = R(a);

        c = P(c) / 3;
        return c;
    }
    internal static double R(double v)
    {
        double z = 5;

        z = 3 / v;

        return z;

        //return v;
    }
}
//in R -1 input output should be -3 but ist -1 so error