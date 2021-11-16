using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practice1_XML.Tests
{
    [TestClass]
    public class PasswordCheckerTest
    {   
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml", "Password", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Check_DataFromXML_Equal()
        {
            int expected, actual;
            string password;
            PasswordChecker checker;

            expected = Convert.ToInt32(TestContext.DataRow["score"]);
            password = Convert.ToString(TestContext.DataRow["data"]);
            checker = new PasswordChecker();
            actual = checker.Check(password);

            Assert.AreEqual(expected, actual);
        }
    }
}