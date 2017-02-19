using EelDataAPI.DAL;
using EelDataAPI.XML;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EelDataAPI;

namespace EelDataAPI.UnitTests
{
    [TestClass]
    public class XMLTests
    {
        private List<DAL.Trigger> _triggers;
        private Model.Trigger _trigger;

        [TestInitialize]
        public void Init()
        {
            _triggers = new List<DAL.Trigger>();
            _trigger = new Model.Trigger();
        }
        [TestMethod]
        public void GenerateXMLTest()
        {
            XMLManagerSingleton.Instance.GenerateTriggerDocument(_triggers);
        }

    }
}
