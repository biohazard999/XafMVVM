﻿using DevExpress.ExpressApp;
using FakeItEasy;
using FluentAssertions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMMVM.Data;
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
            XafApplication application = new XMVVMApplicationMockedInstance(A.Fake<IServiceLocator>());

            application.Should().BeAssignableTo<XafApplication>();
        }

        [TestMethod]
        public void GetServiceLocator_WithCustomConstructor_ShouldReturnServiceLocator()
        {
            var expected = A.Fake<IServiceLocator>();

            XMVVMApplication application = new XMVVMApplicationMockedInstance(expected);

            application.ServiceLocator.Should().Be(expected);
        }

        [TestMethod]
        public void GetServiceLocator_WithDefaultConstructor_ShouldReturnStaticServiceLocator()
        {
            var expected = A.Fake<IServiceLocator>();
            
            ServiceLocator.SetLocatorProvider(() => expected);
    
            XMVVMApplication application = new XMVVMApplicationMockedInstance();

            application.ServiceLocator.Should().Be(expected);
        }
    }
}
