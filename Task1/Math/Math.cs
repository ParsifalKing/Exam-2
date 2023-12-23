
namespace Task1;


public class Math
{
    const double PI = 3.14;
    const double E = 2.71;

    public double _Pi { get; set; }
    public double _E { get; set; }

    public double Abs(double value)
    {
       if(value < 0)
       {
        return value * (-1); 
       }
       else return value;
    }

    public float Abs(float value)
    {
        if(value < 0)
       {
        return value * (-1); 
       }
       else return value;
    }
    public int Abs(int value)
    {
       if(value < 0)
       {
        return value * (-1); 
       }
       else return value; 
    }
    public double Pow(double x, double y)
    {
      double x1=1;
      for (double i = 1; i <= y; i++)
      {
        x1 = x1*x;
      }
      return x1;
    }
    public double Sqrt(double d)
    {
       return System.Math.Sqrt(d);
    }
    public int Max(int val1, int val2)
    {
       if (val1 > val2)
       {
        return val1;
       } 
       else return val2;
    }
    public int Min(int val1, int val2)
    {
       if (val1 < val2)
       {
        return val1;
       } 
       else return val2;
    }



}
