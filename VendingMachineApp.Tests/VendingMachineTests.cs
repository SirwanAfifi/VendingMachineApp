using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachineApp.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void VendingMachine_Has_Beverages()
        {
            var machine = VendingMachinTestHelper.VendingMachine();

            var result = machine.DisplayBeverages().Count;
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void User_Can_Select_An_Item()
        {
            var machine = VendingMachinTestHelper.VendingMachine();

            var selected = machine.SelectAnItem(2);
            Assert.AreEqual("White Coffee with 1 sugar", selected.Name);
        }

        [TestMethod]
        public void Machine_Validates_Inserted_Coin()
        {
            var machine = VendingMachinTestHelper.VendingMachine();

            machine.SelectAnItem(2);
            var result = machine.InsertCoin(2000);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void User_Can_Buy_A_Beverage()
        {
            var machine = VendingMachinTestHelper.VendingMachine();

            machine.SelectAnItem(2);
            machine.InsertCoin(2000);
            var result = machine.Buy();
            Assert.AreEqual("Finished", result);
        }
    }
}