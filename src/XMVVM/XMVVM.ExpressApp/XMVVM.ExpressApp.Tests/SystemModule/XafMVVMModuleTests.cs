using System;
using System.Linq;
using DevExpress.ExpressApp;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMVVM.ExpressApp.SystemModule;
using XMVVM.ExpressApp.SystemModule.Controllers;

// ReSharper disable SuggestUseVarKeywordEvident
namespace XMVVM.ExpressApp.Tests.SystemModule
{
    [TestClass]
    public class XafMVVMModuleTests
    {
        private XafMVVMModule _module;

        [TestInitialize]
        public void TestInitialize()
        {
            _module = new XafMVVMModule();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _module.Dispose();
        }

        [TestMethod]
        public void Constructor_WithDefaultArguments_IsInstanceOfModuleBase()
        {
            Assert.IsInstanceOfType(_module, typeof(ModuleBase));
        }

        [TestMethod]
        public void GetExportedTypes_MustNotReturnAnyExportedTypes_ReturningAnEmptyTypeArray()
        {
            var result = _module.GetExportedTypes();
            result.ShouldBeEquivalentTo(new Type[] {});
        }

        [TestMethod]
        public void GetControllerTypes_ToEnsureExpressAppCompability_OnlyContainsControllerDerivedTypes()
        {
            var result = _module.GetControllerTypes().All(m => typeof(DevExpress.ExpressApp.Controller).IsAssignableFrom(m));

            result.Should().BeTrue("All Controller have to be derived from DevExpress.ExpressApp.Controller");
        }

        [TestMethod]
        public void GetControllerTypes_ToEnsureExpressAppCompability_ContainsMVVMNavigationItemController()
        {
            var controllerTypes = _module.GetControllerTypes();

            controllerTypes.Should().Contain(typeof (MVVMNagivationItemController));
        }
    }
}
