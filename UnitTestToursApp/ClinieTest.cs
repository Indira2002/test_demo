using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToursApp;
namespace UnitTestToursApp
{
    [TestClass]
    public class ClinieTest
    {
        private Diagno ds = new Diagno();
        private Doctor dr = new Doctor();
        private Patient pt = new Patient();
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            DailyReception dr1 = new DailyReception();
            DailyReception dr2 = new DailyReception();
            DailyReception dr3 = new DailyReception();
            DailyReception dr4 = new DailyReception();
            DailyReception dr5 = new DailyReception();
            DailyReception dr6 = new DailyReception();
            dr1.CouponNum = "a-204";
            dr2.Data = "29.11.2021";
            dr3.Cost = "20";
            dr4.Diagno = ds;
            dr5.Doctor1 = dr;
            dr6.Patient1 = pt;
            // Act
            string result1 = DailyReceptions.Check(dr1);
            string result2 = DailyReceptions.Check(dr2);
            string result3 = DailyReceptions.Check(dr3);
            string result4 = DailyReceptions.Check(dr4);
            string result5 = DailyReceptions.Check(dr5);
            string result6 = DailyReceptions.Check(dr6);
            //Assert
            Assert.AreNotEqual(result1, string.Empty);
            Assert.AreNotEqual(result2, string.Empty);
            Assert.AreNotEqual(result3, string.Empty);
            Assert.AreNotEqual(result4, string.Empty);
            Assert.AreNotEqual(result5, string.Empty);
            Assert.AreNotEqual(result6, string.Empty);          
        }       
    }
}
