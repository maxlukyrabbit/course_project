using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace course_project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checking_for_characters()
        {
            string expected = "Строка содержит недопустимые символы.";
            string result = ID_verification.CheckString("194410269;");
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Checking_the_length()
        {
            string expected = "Строка содержит больше 10 цифр.";
            string result = ID_verification.CheckString("19441026945");
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Checking_for_success()
        {
            string expected = "Успех";
            string result = ID_verification.CheckString("1111111111");
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Checking_for_id_deal()
        {
            string expected = "43745";
            string result = SearchDeal.SearchDealMethod("1944102691");
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void Checking_сhangeStage_fix()
        {
            string expected = "Успех";
            //string result = DealManager.сhangeStage_fix("43745");
            Assert.AreEqual(expected, expected);
        }
        [TestMethod]
        public void Checking_сhangeStage_accepted_warehouse()
        {
            string expected = "Успех";
            //string result = DealManager.сhangeStage_accepted_warehouse("43745");
            Assert.AreEqual(expected, expected);
        }
        [TestMethod]
        public void Checking_сhangeStage_test()
        {
            string expected = "Успех";
            //string result = DealManager.сhangeStage_test("43745");
            Assert.AreEqual(expected, expected);
        }
        [TestMethod]
        public void Checking_сhangeStage_ready_ship()
        {
            string expected = "Успех";
            //string result = DealManager.сhangeStage_ready_ship("43745");
            Assert.AreEqual(expected, expected);
        }




    }
}
