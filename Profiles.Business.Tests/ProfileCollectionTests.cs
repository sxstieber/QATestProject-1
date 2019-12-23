using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Profiles.Business;

namespace Profiles.Business.Tests
{
    [TestClass]
    public class ProfileCollectionTests
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod, TestCategory("Functional"), TestCategory("BVT")]
        public void ProfileCollection_Test_GetProfile()
        {
            // Arrange
            TestContext.WriteLine("Beginning Test");


            // Action


            // Assert


        }
    }
}
