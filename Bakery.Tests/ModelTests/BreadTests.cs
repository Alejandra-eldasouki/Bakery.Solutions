using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTest
    {
        [TestMethod]
        public void BreadConst_CreatesInstanceOfBread_Bread()
        {
            Bread addBread = new Bread(1,5);
            Assert.AreEqual(typeof(Bread), addBread.GetType());

        }
        [TestMethod] 
        public void BreadPrice_returnPrice_Int()
        {
            Bread addBread0 = new Bread(0,0);
            Bread addBread1 = new Bread(1,5);
            Bread addBread2 = new Bread(2,10);
            Bread addBread3= new Bread(3,10);
            Bread addBread4= new Bread(7,25);
            Assert.AreEqual(0, addBread0.BreadPrice());
            Assert.AreEqual(5, addBread1.BreadPrice());
            Assert.AreEqual(10, addBread2.BreadPrice());
            Assert.AreEqual(10, addBread3.BreadPrice());
            Assert.AreEqual(25, addBread4.BreadPrice());
        }
        [TestMethod]
        public void pastries_ReturnPastryOrPastries_String()
        {
            Bread addBread1  = new Bread(1,5);
            Bread addBread2  = new Bread(2,10);
            Assert.AreEqual("loaf", addBread1.Loaf());
            Assert.AreEqual("loaf", addBread2.Loaf());
        }
    }
}