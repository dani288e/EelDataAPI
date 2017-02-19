using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;

namespace EelDataAPI
{
    public partial class Default : System.Web.UI.Page
    {
        // todo make a timer that generates xml doc and maybe refreshes content on page

        private Timer _xmlTimer;

        private List<DAL.Trigger> _triggerList;
        protected void Page_Load(object sender, EventArgs e)
        {
            _xmlTimer = new Timer();
            _xmlTimer.Interval = 5000;
            _xmlTimer.Elapsed += _xmlTimer_Elapsed;
            _xmlTimer.Enabled = true;
            _triggerList = new List<DAL.Trigger>();
            string theXML = Server.HtmlEncode(File.ReadAllText(@"C:\EelData\API\triggers.xml"));
            lit1.Text = theXML;
        }

        private void _xmlTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            XML.XMLManagerSingleton.Instance.GenerateTriggerDocument(_triggerList);
        }
    }
}