using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EelDataAPI.DAL;
using EelDataAPI.Model;

namespace EelDataAPI.UnitTests
{
    [TestClass]
    public class DALTests
    {
        private EelDataAPI.Model.Trigger _trigger;
        [TestInitialize]
        public void Init()
        {
            _trigger = new Model.Trigger();
        }
        [TestMethod]
        public void GetTriggersTest()
        {
            DALManagerSingleton.Instance.GetTriggers(_trigger);
        }
    }
}
