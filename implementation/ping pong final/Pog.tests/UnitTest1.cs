using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using Pong.Module;

namespace Pog.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Validation vd = new Validation();
            bool a = vd.checkcredentials("admin", "admin");
            Assert.AreEqual(true, a);

        }



        [TestMethod]
        public void TestMethod2()
        {
            Validation vd = new Validation();
            bool a = vd.checkcredentials("trumustbefalse", "shouldgetfalse");
            Assert.AreEqual(false, a);

        }






        [TestMethod]
        public void TestMethod3()
        {
            Validation vd = new Validation();
            bool a = vd.checkcredentials("adhsjksi", "3456789");
            Assert.AreEqual(false, a);

        }


        [TestMethod]
        public void TestMethod4()
        {
            Validation vd = new Validation();
            bool a = vd.checkcredentials("romaan", "oli");
            Assert.AreEqual(false, a);

        }
    }
}
