//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EelDataAPI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensor
    {
        public int ID { get; set; }
        public int BassinID { get; set; }
        public string IPAddress { get; set; }
    
        public virtual Bassin Bassin { get; set; }
        public virtual SensorData SensorData { get; set; }
    }
}
