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
    }
}