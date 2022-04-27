using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShoppingStore.Controllers;
using System;

namespace TestShop.UnitTests
{
    [TestClass]
    public class AdminControllerTests
    {
        [TestMethod]
        public void UpdateCategory_UserIsAdmin_ReturnsTrue()
        {
            var AdminController = new AdminController();
           
        }
        public void CategoryEdit_UserIsAdmin_ReturnsTrue()
        {
            var AdminController = new AdminController();

        }
        public void Product_UserIsAdmin_ReturnsTrue()
        {
            var AdminController = new AdminController();

        }

    }
}
