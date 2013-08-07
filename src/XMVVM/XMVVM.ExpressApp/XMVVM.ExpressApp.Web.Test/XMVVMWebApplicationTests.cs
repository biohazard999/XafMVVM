using DevExpress.ExpressApp.Web;
using FakeItEasy;
using FluentAssertions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable SuggestUseVarKeywordEvident

namespace XMVVM.ExpressApp.Web.Test
{
    [TestClass]
    public class XMVVMWebApplicationTests
    {
        [TestMethod]
        public void Constructor_ToEnsureExpressAppCompability_ShouldBeXafApplication()
        {
            WebApplication application = new XMVVMWebApplication(A.Fake<IServiceLocator>());

            application.Should().BeAssignableTo<WebApplication>();
        }

        [TestMethod]
        public void GetServiceLocator_WithCustomConstructor_ShouldReturnServiceLocator()
        {
            var expected = A.Fake<IServiceLocator>();

            XMVVMWebApplication application = new XMVVMWebApplication(expected);

            application.ServiceLocator.Should().Be(expected);
        }

        [TestMethod]
        public void GetServiceLocator_WithDefaultConstructor_ShouldReturnStaticServiceLocator()
        {
            var expected = A.Fake<IServiceLocator>();

            ServiceLocator.SetLocatorProvider(() => expected);

            XMVVMWebApplication application = new XMVVMWebApplication();

            application.ServiceLocator.Should().Be(expected);
        }
    }
}