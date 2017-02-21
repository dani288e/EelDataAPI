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

        [TestInitialize]
        public void Init()
        {
            _triggers = new List<Trigger>();
        }
        [TestMethod]
        public void GenerateTriggerDocumentTest()
        {
            XMLManagerSingleton.Instance.GenerateTriggerDocument(_triggers);
        }

    }
}
