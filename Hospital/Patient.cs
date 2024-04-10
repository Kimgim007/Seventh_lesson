using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_lesson.Hospital
{
    public class Patient
    {
        public Patient() { }
        public Patient(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }
    }
}
