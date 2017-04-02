using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Core.Chapters.DI;
using Moq;

namespace CSharp.Tests
{
    [TestClass]
    public class AttributeTests
    {
        private IAttributeServices _attributeService;

        //[ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            // this._attributeService = new FakeAttributeService();
        }

        [TestInitialize()]
        public void Start()
        {
            this._attributeService = new FakeAttributeService();
        }

        [TestMethod]
        public void Test_Save()
        {
            AttributeConsumer attribute = new AttributeConsumer(this._attributeService);
            attribute.Save("billa");
        }

        [TestMethod]
        public void Test_Moq_Save()
        {
            var mock = new Mock<IAttributeServices>();

            mock.Setup(x => x.Save(It.IsAny<string>()))
                            .Callback((string s) => {
                                Console.WriteLine(s);
                            });
            //mock.Setup(x => x.Save("billa"));


            var attribute = mock.Object;

            attribute.Save("billa");

            mock.Verify(x => x.Save("billa"), Times.Exactly(1));
        }

        [TestMethod]
        public void AlwaysFail()
        {
            Assert.Fail("Testing TFS build Test");
        }

        [TestCleanup]
        //[ClassCleanup]
        public  void Cleanup()
        {
            _attributeService = null;
        }
    }
}
