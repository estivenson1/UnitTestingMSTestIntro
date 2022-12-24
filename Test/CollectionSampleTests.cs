using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMSTestIntro;

namespace Test
{
    [TestClass]
    public class CollectionSampleTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //Arrange
            Customer[] customers = new Customer[2]
            {
                new Customer() {FirsName="Estivenson", LastName="Ortega"},
                new Customer() {FirsName="Jose", LastName="Perez"}
            };
            int index = 1;
            Customer expected = customers[1];

            //Act
            Customer actual =CollectionsSample.GetCustomer(customers, index);            

            //Assert  
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomeru_ShouldThrowIndexOutfRsngerExeocion()
        {
            //Arrange
            Customer[] customers = new Customer[2]
            {
                new Customer() {FirsName="Estivenson", LastName="Ortega"},
                new Customer() {FirsName="Jose", LastName="Perez"}
            };
            int index = 3; 

            //Act
            Customer actual = CollectionsSample.GetCustomer(customers, index);

            //Assert   
        }
    }
}
