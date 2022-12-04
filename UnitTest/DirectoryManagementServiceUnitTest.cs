using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModManager.StarCraft.Services;
using System;
using UnitTest.Mock;

namespace UnitTest
{
    [TestClass]
    public class DirectoryManagementServiceUnitTest
    {
        DirectoryManagementService service = new DirectoryManagementService(LoggerMock.Log);
        [TestMethod]
        public void CleanupBadPathTest()
        {
            service.ClearDirectory("nonexisting");
        }

        [TestMethod]
        public void CleanupBadPathReturnsFalseTest()
        {
            Assert.IsFalse(service.ClearDirectory("nonexisting"));
        }
    }
}
