using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plug_Host.Provider_Host;
using System.Diagnostics;

namespace Test
{
    [TestClass]
    public class ProviderHostTest
    {
        IProvider provider = ProviderHost.getInstance() as IProvider;

        [TestMethod]
        public void TestProvider()
        {
            Assert.AreEqual(Services.SeriesManager.getSeasonNumberXOf(0, null), 1);
        }
    }
}
