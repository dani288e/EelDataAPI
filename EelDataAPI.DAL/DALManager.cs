using System;
using System.Collections.Generic;
using System.Linq;
using EelDataAPI.Model;
using System.Collections.ObjectModel;

namespace EelDataAPI.DAL
{
    public class DALManager
    {
        public List<Trigger> GetTriggers(List<Trigger> triggers)
        {
            using (EelDataEntities context = new EelDataEntities())
            {
                DateTime dateCriteria = DateTime.Now.AddDays(-30);

                var query = (from o in context.Triggers
                             where o.DateTime >= dateCriteria
                             select o).ToList();
                if (query != null)
                {
                    foreach (var result in query)
                    {
                        triggers.Add(result);
                    }
                }
                return triggers;
            }
        }
    }
}
