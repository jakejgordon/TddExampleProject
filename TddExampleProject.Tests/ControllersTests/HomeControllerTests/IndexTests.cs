using System.Web.Mvc;
using NUnit.Framework;
using Shouldly;
using StructureMap.AutoMocking;
using TddExampleProject.Controllers;

namespace TddExampleProject.Tests.ControllersTests.HomeControllerTests
{
    [TestFixture]
    public class IndexTests
    {
        private RhinoAutoMocker<HomeController> _autoMocker;

        [SetUp]
        public void SetUp()
        {
            _autoMocker = new RhinoAutoMocker<HomeController>();
        }
    }
}