using CoursCSharpObjetPartie1.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursTestUnitaire
{
    [TestClass]
    public class ToolsTest
    {
       [TestMethod]
       public void IsBissextileTest_TRUE()
        {
            //Arrange
            Tools tools = new Tools();
            //Act
            bool result = tools.IsBissextile(2020);
            //Assert
            Assert.IsTrue(result);          
        }
        [TestMethod]
        public void IsBissextileTest_FALSE()
        {
            //Arrange
            Tools tools = new Tools();
            //Act
            bool result = tools.IsBissextile(2019);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBissextileTest_FALSE_2()
        {
            //Arrange
            Tools tools = new Tools();
            //Act
            bool result = tools.IsBissextile(1900);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsBissextileTest_TRUE_2()
        {
            //Arrange
            Tools tools = new Tools();
            //Act
            bool result = tools.IsBissextile(2000);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WordCountTest_1()
        {
            //Arrange
            Tools tools = new Tools();

            //Act

            int nb = tools.WordWount("Bonjour");

            Assert.AreEqual(1, nb);
        }

        [TestMethod]
        public void WordCountTest_1_Bis()
        {
            //Arrange
            Tools tools = new Tools();

            //Act

            int nb = tools.WordWount("Bonjour !");

            Assert.AreEqual(1, nb);
        }
        [TestMethod]
        public void WordCountTest_1_Ter()
        {
            //Arrange
            Tools tools = new Tools();

            //Act

            int nb = tools.WordWount("Rendez-vous");

            Assert.AreEqual(1, nb);
        }

        [TestMethod]
        public void WordCountTest_Miltiple()
        {
            //Arrange
            Tools tools = new Tools();

            int nb = tools.WordWount("Bonjour tout le monde");

            Assert.AreEqual(4, nb);
        }

        
        [TestMethod]
        public void WordCountTest_Miltiple_2()
        {
            //Arrange
            Tools tools = new Tools();

            int nb = tools.WordWount("Bonjour tout le monde ");

            Assert.AreEqual(4, nb);
        }
        
        [TestMethod]
        public void WordCountTest_Empty()
        {
            //Arrange
            Tools tools = new Tools();

            int nb = tools.WordWount("");

            Assert.AreEqual(0, nb);
        }
    }
}
