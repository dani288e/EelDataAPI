using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EelDataAPI.DAL
{
    public class DALManager
    {
        private List<Trigger> _triggerList = new List<Trigger>();
        public void GetTriggers(Model.Trigger record)
        {
            using (EelDataEntities context = new EelDataEntities())
            {
                DateTime dateCriteria = DateTime.Now.AddDays(-30);

                _triggerList = (from o in context.Triggers
                                 where o.DateTime >= dateCriteria
                                 select o).ToList();
                if (_triggerList != null)
                {
                    Trigger triggerE = new Trigger();
                    _triggerList = triggerE.Triggers;
                }
            }
        }
    }
}
