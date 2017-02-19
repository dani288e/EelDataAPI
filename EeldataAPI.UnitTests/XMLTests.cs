using EelDataAPI.DAL;
using EelDataAPI.XML;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EelDataAPI.UnitTests
{
    [TestClass]
    public class XMLTests
    {
        private List<Trigger> _triggers;
        //private Model.Trigger _trigger;

        [TestInitialize]
        public void Init()
        {
            _triggers = new List<Trigger>();
            //_trigger = new Model.Trigger();
        }
        [TestMethod]
        public void GenerateTriggerDocumentTest()
        {
            XMLManagerSingleton.Instance.GenerateTriggerDocument(_triggers);
        }

    }
}
