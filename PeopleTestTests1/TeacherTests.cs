using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleTest.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod]
        public void SalaryTest()
        {
            Teacher teacher = new Teacher("Anders");
            teacher.Salary = 100;
            Assert.AreEqual(100, teacher.Salary);

            //teacher.Salary = 0;
            //Assert.AreEqual(0, teacher.Salary);

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.Salary = -1);
        }

        [TestMethod]
        public void NameTest()
        {
            Teacher teacher = new Teacher("Anders");
            //teacher.Name = "Anders";
            Assert.AreEqual("Anders", teacher.Name);

            //teacher.Name = "Anders";
            //Assert.AreEqual("Anders", teacher.Name);

            //Assert.ThrowsException<ArgumentException>(() => teacher.Name = "");
            //Assert.ThrowsException<ArgumentNullException>(() => teacher.Name = null);
        }

        [TestMethod()]
        public void AddressTest()
        {
            Teacher teacher = new Teacher("Anders");
            teacher.Address = "North of West Bumblefuck";
            Assert.AreEqual("North of West Bumblefuck", teacher.Address);
        }

        [TestMethod()]
        public void ToStringTest()
        {

        }
    }
}