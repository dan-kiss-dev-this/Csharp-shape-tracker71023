namespace ShapeTracker.Models
{
  public class Rectangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }

    public Rectangle(int side1, int side2)
    {
      Side1 = side1;
      Side2 = side2;
    }

    public int GetArea()
    {
      int rectangleArea = Side1 * Side2;
      return rectangleArea;
    }
    // side1, side2, instances, GetInstances
    //CalculateArea function
  }
}
