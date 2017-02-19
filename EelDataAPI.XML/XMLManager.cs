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
        public XmlDocument GenerateTriggerDocument(List<Trigger> triggerList)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("Trigger");
            xmlDocument.AppendChild(root);
            foreach (var trigger in DALManagerSingleton.Instance.GetTriggers(triggerList))
            {
                XmlElement triggerElement = xmlDocument.CreateElement("Event");
                triggerElement.SetAttribute("BassinID", trigger.BassinID.ToString());
                triggerElement.SetAttribute("WarningID", trigger.WarningID.ToString());
                triggerElement.SetAttribute("Timestamp", trigger.DateTime.ToString());
                root.AppendChild(triggerElement);
            }
            return xmlDocument;
        }
    }
}
