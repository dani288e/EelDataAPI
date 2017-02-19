using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EelDataAPI.DAL;
using EelDataAPI.Model;
using System.Collections.Generic;

namespace EelDataAPI.UnitTests
{
    [TestClass]
    public class DALTests
    {
        private List<DAL.Trigger> _triggers;
        [TestInitialize]
        public void Init()
        {
            _triggers = new List<DAL.Trigger>();
        }
        [TestMethod]
        public void GetTriggersTest()
        {
            DALManagerSingleton.Instance.GetTriggers(_triggers);
        }
    }
}
