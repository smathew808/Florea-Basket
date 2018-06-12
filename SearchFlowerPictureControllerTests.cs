using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS325_broadSword_flowerProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject.Tests
{
    [TestClass()]
    public class SearchFlowerPictureControllerTests
    {

        [TestMethod()]
        public void calculateChiSquareTest()
        {
            //make stubs
            double ChiValue1 = (0.0);
            double ChiValue2 = (8);
            double ChiValue3 = (1);
            //fail test
            double ChiValue4 = (-0.12);
            double ChiValue5 = (1.02);

            SearchFlowerPictureController controller = new SearchFlowerPictureController();

            //make bin list, and the DB lists
            int[] UserBinList = new int[17] { 0, 5, 5, 4, 0, 7, 4, 3, 0, 4, 4, 25, 0, 18, 25, 10, 0 };

            int[] dbBinList1 = new int[17] { 0, 5, 6, 4, 0, 7, 4, 3, 0, 4, 4, 25, 0, 18, 25, 10, 0 };
            int[] dbBinList2 = new int[17] { 0, 5, 3, 4, 0, 7, 4, 3, 0, 5, 4, 25, 0, 18, 25, 10, 0 };
            int[] dbBinList3 = new int[17] { 0, 5, 8, 5, 0, 7, 4, 7, 0, 4, 4, 25, 0, 18, 25, 10, 0 };
            int[] dbBinList4 = new int[17] { 0, 5, 8, 6, 0, 7, 4, 3, 0, 4, 4, 25, 0, 18, 25, 10, 0 };
            int[] dbBinList5 = new int[17] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            double testChiValue1 = controller.calculateChiSquare(UserBinList, dbBinList1);
            double testChiValue2 = controller.calculateChiSquare(UserBinList, dbBinList2);
            double testChiValue3 = controller.calculateChiSquare(UserBinList, dbBinList3);
            double testChiValue4 = controller.calculateChiSquare(UserBinList, dbBinList4);
            double testChiValue5 = controller.calculateChiSquare(UserBinList, dbBinList5);

            Assert.AreEqual((int)(10 * testChiValue1), ChiValue1);
            Assert.AreEqual((int)(100 * testChiValue2), ChiValue2);
            Assert.AreEqual((int)(10 * testChiValue3), ChiValue3);

            //failed tests
           // Assert.AreEqual((int)(10 * testChiValue4), ChiValue4);
           // Assert.AreEqual((int)(10 * testChiValue1), ChiValue5);
        }
    }
}