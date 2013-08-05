using DevExpress.ExpressApp;
using FakeItEasy;
using FluentAssertions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMVVM.ExpressApp.Tests.TestMothers;

// ReSharper disable SuggestUseVarKeywordEvident

namespace XMVVM.ExpressApp.Tests
{
    [TestClass]
    public class XMVVMApplicationTests
    {
        [TestMethod]
        public void Constructor_ToEnsureExpressAppCompability_ShouldBeXafApplication()
        {
            XafApplication application = new XMVVMApplicationMockedInstance();

            application.Should().BeAssignableTo<XafApplication>();
        }

        [TestMethod]
        public void GetServiceLocator_ToProvideInfrastructure_ShouldReturnServiceLocator()
        {
            XMVVMApplicationMockedInstance application = new XMVVMApplicationMockedInstance();

            var expected = A.Fake<IServiceLocator>();

            application._ServiceLocator = expected;

            IServiceLocator serviceLocator = application.GetServiceLocator();

            serviceLocator.Should().Be(expected);
        }
    }
}
