using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleTest.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void NameTest()
        {
            Student student = new Student("Marc");
            //Student.Name = "Marc";
            Assert.AreEqual("Marc", student.Name);

            //Assert.ThrowsException<ArgumentException>(() => student.Name = "");
        }

        [TestMethod()]
        public void AddressTest()
        {
            Student student = new Student("Marc");
            student.Address = "Brinken 10";
            Assert.AreEqual("Brinken 10", student.Address);
        }

        [TestMethod()]
        public void SemesterTest()
        {
            Student student = new Student("Marc");
            student.Semester = 3;
            Assert.AreEqual(3, student.Semester);
        }


        [TestMethod()]
        public void ToStringTest()
        {
        }
    }
}