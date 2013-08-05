using System;
using System.Linq;
using DevExpress.ExpressApp;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xpand.ExpressApp.XafMVVM;
using Xpand.ExpressApp.XafMVVM.Controllers;

// ReSharper disable SuggestUseVarKeywordEvident
namespace Xpand.ExpressApp.XafMVVMTests
{
    [TestClass]
    public class XafMVVMModuleTests
    {
        private XafMVVMModule _Module;

        [TestInitialize]
        public void TestInitialize()
        {
            _Module = new XafMVVMModule();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _Module.Dispose();
        }

        [TestMethod]
        public void Constructor_WithDefaultArguments_IsInstanceOfModuleBase()
        {
            Assert.IsInstanceOfType(_Module, typeof(ModuleBase));
        }

        [TestMethod]
        public void GetDeclaredExportedTypes_HaveToReturn_EmptyTypeArray()
        {
            var result = _Module.GetExportedTypes();
            result.Count().Should().Be(0);
        }

        [TestMethod]
        public void GetControllerTypes_ToEnsureExpressAppCompability_OnlyContainsControllerDerivedTypes()
        {
            var result = _Module.GetControllerTypes().All(m => typeof(DevExpress.ExpressApp.Controller).IsAssignableFrom(m));

            result.Should().BeTrue("All Controller have to be derived from DevExpress.ExpressApp.Controller");
        }

        [TestMethod]
        public void GetControllerTypes_ToEnsureExpressAppCompability_ContainsMVVMNavigationItemController()
        {
            var controllerTypes = _Module.GetControllerTypes();

            controllerTypes.Should().Contain(typeof (MVVMNagivationItemController));
        }
    }
}
