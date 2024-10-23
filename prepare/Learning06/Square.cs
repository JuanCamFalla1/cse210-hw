public class Square : Shape
{
    private double _side;

    public Square (double side,string color) :base(color)
    {   
        _side = side;
    }

    public override double GetArea()
    {
        return _side * 2;
    }

    public void GetSide (double side)
    {   
         _side =side;
    }
}