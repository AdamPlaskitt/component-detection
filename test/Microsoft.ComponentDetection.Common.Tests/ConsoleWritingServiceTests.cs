namespace Microsoft.ComponentDetection.Common.Tests
{
    using System;
    using System.IO;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    [TestCategory("Governance/All")]
    [TestCategory("Governance/ComponentDetection")]
    public class ConsoleWritingServiceTests
    {
        private static TestContext testContext;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext inputTestContext)
        {
            testContext = inputTestContext;
        }

        [TestMethod]
        public void Write_Writes()
        {
            var service = new ConsoleWritingService();
            var guid = Guid.NewGuid().ToString();
            var writer = new StringWriter();
            Console.SetOut(writer);
            service.Write(guid);
            var obj = new object();
            writer.ToString()
                .Should().Contain(guid);
        }
    }
}
