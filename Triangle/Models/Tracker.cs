namespace Triangle 
{
  public class Tracker
  {
    public bool IsTriangle( int side1, int side2, int side3)
    {
      if ((side1 > (side2 + side3)) || (side2 > (side1 + side3)) || (side3 > (side1 + side2))) 
      {
        return false;
      } 
      else
      {
        return true;
      }
    }
  }
}