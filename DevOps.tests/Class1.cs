using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xania.AspNet.Simulator;
using NUnit.Framework;
using DevOpsSolution.Controllers;

namespace DevOps.tests
{
    public class Hometest
    {
        private DirectControllerAction _action;
        [SetUp]
        public void newtest()
        {
            var testcontroller = new DevOpsController();
            _action = testcontroller.Action(c => c.Hello());
        }

        [Test]
        public void AnonymouusTest()
        {
            _action.Authorize().ToString();

        }
    }
}
