using System;
using System.Xml;
using EelDataAPI.DAL;
using EelDataAPI.Model;
using System.Diagnostics;
using System.Collections.Generic;

namespace EelDataAPI.XML
{
    public class XMLManager
    {
        public XmlDocument GenerateTriggerDocument(List<DAL.Trigger> triggerList)
        {
            XmlDocument triggerDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = triggerDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            foreach (var trigger in DALManagerSingleton.Instance.GetTriggers(triggerList))
            {
                Debug.WriteLine(triggerList.ToString());
            }
            XmlElement root = triggerDoc.DocumentElement;
            triggerDoc.InsertBefore(xmlDeclaration, root);

            return triggerDoc;
        }
    }
}
