using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_lesson.Hospital
{
    public class TreatmentPlan
    {
        public TreatmentPlan() { }
        public TreatmentPlan(string Plan)
        {
            this.Plan = Plan;
        }
        public string Plan {  get; set; }
    }
}
