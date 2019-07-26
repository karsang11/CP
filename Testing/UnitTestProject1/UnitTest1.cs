using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grocery_Management_Systems;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Logincontroller log = new Logincontroller();
        LoginModel login = new LoginModel();
        Itemcontroller item = new Itemcontroller();
        Itemmodel it = new Itemmodel();
        DataTable dt;
        private bool expected, actual;
        private bool check;

        
        [TestMethod]
        public void TestMethod1()
        {
            expected = true;
            login.uname = "gmi";
            login.pswd = "123456";
            check = log.checkuser(login);
            if(check==true)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testmethod2()
        {
            expected = true;
            login.uname = "gmi";
            login.pswd = "1234";
            check = log.checkuser(login);
            if (check == true)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void testmethod3()
        {
            expected = true;
            it.i = "ice cream";
            dt = item.selectitem(it);
            if (dt.Rows.Count>0)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void testmethod4()
        {
            expected = true;
            it.i = "bottle";
            dt = item.selectitem(it);
            if (dt.Rows.Count > 0)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void testmethod5()
        {
            expected = true;
            login.uname = "susan07";
            login.pswd = "susan123";
            check = log.checkuser(login);
            if (check == true)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void testmethod6()
        {
            expected = true;
            login.uname = "admin";
            login.pswd = "admin";
            check = log.checkuser(login);
            if (check == true)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }



    }
}
