using DevExpress.ExpressApp.Win;
using FakeItEasy;
using FluentAssertions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable SuggestUseVarKeywordEvident

namespace XMVVM.ExpressApp.Win.Test
{
    [TestClass]
    public class XMVVMWinApplicationTests
    {
        [TestMethod]
        public void Constructor_ToEnsureExpressAppCompability_ShouldBeXafApplication()
        {
            WinApplication application = new XMVVMWinApplication(A.Fake<IServiceLocator>());

            application.Should().BeAssignableTo<WinApplication>();
        }

        [TestMethod]
        public void GetServiceLocator_WithCustomConstructor_ShouldReturnServiceLocator()
        {
            var expected = A.Fake<IServiceLocator>();

            XMVVMWinApplication application = new XMVVMWinApplication(expected);

            application.ServiceLocator.Should().Be(expected);
        }

        [TestMethod]
        public void GetServiceLocator_WithDefaultConstructor_ShouldReturnStaticServiceLocator()
        {
            var expected = A.Fake<IServiceLocator>();

            ServiceLocator.SetLocatorProvider(() => expected);

            XMVVMWinApplication application = new XMVVMWinApplication();

            application.ServiceLocator.Should().Be(expected);
        }
    }
}