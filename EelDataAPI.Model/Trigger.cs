using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EelDataAPI.Model
{
    public class Trigger
    {
        public int BassinID { get; set; }
        public int WarningID { get; set; }
        public DateTime DateTime { get; set; }
        //public List<Trigger> Triggers { get; set; }
    }
}
