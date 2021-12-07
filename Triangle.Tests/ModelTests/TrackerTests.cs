using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TrackerTests
  {
    [TestMethod]
    public void IsTriangle_ChecksIfATriangle_True()
    {
      Tracker triangle1 = new Tracker();
      Assert.AreEqual(true, triangle1.IsTriangle(1, 2, 1));
    }

    [TestMethod]
    public void IsTriangle_CheckIfScalene_True()
    {
      Tracker triangle2 = new Tracker();
      Assert.AreEqual(true, triangle2.IsScalene(1, 2, 3));
    }
  }
}