using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests.ModelTests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry addPastry = new Pastry(1,2);
      Assert.AreEqual(typeof(Pastry), addPastry.GetType());
    }
    [TestMethod]
    public void PastryTotal_ReturnPriceOfPastry_Int()
    {
      Pastry addPastry0 = new Pastry(0,0);
      Pastry addPastry1 = new Pastry(1,2);
      Pastry addPastry2 = new Pastry(2,4);
      Pastry addPastry3 = new Pastry(3,6);
      Pastry addPastry4 = new Pastry(4,6);
      Pastry addPastry5 = new Pastry(5,8);
      Pastry addPastry6 = new Pastry(7, 12);
      Pastry addPastry7 = new Pastry(8, 12);
      Pastry addPastry8 = new Pastry(16, 24);
      Assert.AreEqual(0, addPastry0.PastryTotal());
      Assert.AreEqual(2, addPastry1.PastryTotal());
      Assert.AreEqual(4, addPastry2.PastryTotal());
      Assert.AreEqual(5, addPastry3.PastryTotal());
      Assert.AreEqual(7, addPastry4.PastryTotal());
      Assert.AreEqual(9, addPastry5.PastryTotal());
    }  
     [TestMethod]
    public void Pastries_ReturnPastryOrPastries_String()   
    {
      Pastry addPastry1 = new Pastry(1,20);
      Pastry addPastry2 = new Pastry(2,4);
      Assert.AreEqual("pastry", addPastry1.Pastries());
      Assert.AreEqual("pastries", addPastry2.Pastries());
    }
    }
}