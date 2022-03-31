using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_classes
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void SettingValues()
        {
            Room room = new Room();
            room.Length = 12;
            room.Width = 12;
            room.Height = 18;

            Assert.AreEqual(144,
                room.CalculateSQFootage());

            Assert.AreEqual(room.LsurfaceArea(),
                room.Calculate2());

            Room room2 = new Room(12, 12, 25);
            Assert.AreEqual(144,
               room2.CalculateSQFootage());


        }

        //check sqaure footage output
        [TestMethod]
        public void CheckSquareFootage_ShouldReturnCorrectDouble()
        {
            Room room = new Room(10, 7, 10);
            double expected = 70; //10*7
            double actual = room.CalculateSQFootage();

        }
        // check lateral area output
        [TestMethod]
        public void CheckLateralSurfaceArea_ShouldReturnCorrectDouble()
        {
            Room room = new Room(10, 7, 10);
            Assert.AreEqual(340, room.CalculateTotalLateralSurfaceArea());
        }
        // check invalid values
        //check invalid length
        [DataTestMethod]
        [DataRow(4, 8, 12)] // check min length
        [DataRow(40, 30, 12)] // check max length
        public void CreateInvalidLength_ShouldThrowException(double l, double w, double h)
        {
            Exception thrownException = null;
            try
            {
                //attempt this
                Room room = new Room(l, w, h);
            }
            //grab the exception
            catch (Exception err)
            {
                //run this code
                thrownException = err;
            }
            Assert.IsNotNull(thrownException);
            Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
        }
        // check invalid width
        [DataTestMethod]
        [DataRow(3, 9, 12)] // check min length
        [DataRow(10, 30, 12)] // check max length
        public void CreateInvalidWidth_ShouldThrowException(double l, double w, double h)
        {
            Exception thrownException = null;
            try
            {
                //attempt this
                Room room = new Room(l, w, h);
            }
            //grab the exception
            catch (Exception err)
            {
                //run this code
                thrownException = err;
            }
            finally // will always run regaurdless of exception thrown or not
            {
                Console.WriteLine("I can not be stopped");
                Assert.IsNotNull(thrownException);
                Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
            }
            Console.WriteLine("I can be");
        }
        //check invalid height
        [DataTestMethod]
        [DataRow(3, 8, 12)] // check min length
        [DataRow(31, 25, 20)] // check max length
        public void CreateInvalidHeight_ShouldThrowException(double l, double w, double h)
        {
            Exception thrownException = null;
            try
            {
                //attempt this
                Room room = new Room(l, w, h);
            }
            //grab the exception
            catch (Exception err)
            {
                //run this code
                thrownException = err;
            }
            finally // will always run regaurdless of exception thrown or not
            {
                Console.WriteLine("I can not be stopped");
                Assert.IsNotNull(thrownException);
                Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
            }
            Console.WriteLine("I can be");

        }
        [DataTestMethod]
        [DataRow(12, 8, 6)] // under min
        [DataRow(8, 13, 25)] // over max
        [ExpectedException(typeof(ArgumentException))] // I am expecting an exception and this test to fail, so it passes

        public void CreateInvalidHeight_ShouldThrowException1(double l, double w, double h)
        {
            Room room = new Room(l, w, h);
        }

    }
}
