using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_lesson.Hospital
{
    public class Doctor
    {
        public Doctor() { }
        public Doctor(string DoctorName)
        {
            this.DoctorName = DoctorName;
        }
        public string DoctorName { get; set; }

        public void Treat(string whoWillTreatYou)
        {
            switch (whoWillTreatYou)
            {
                case "1":
                    {
                        Console.WriteLine("Хирург режит");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Дантиста пилит");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Терапевта лечит");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("");
                        break;
                    }
            }
        }

        public void WhoWillTreatYou(TreatmentPlan treatmentPlan)
        {

            switch (treatmentPlan.Plan)
            {
                case "1":
                    {
                        Console.WriteLine("Назначить хирурга");
                        Treat("1");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Назначить дантиста");
                        Treat("2");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Назначить терапевта");
                        Treat("3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("");
                        break;
                    }
            }

        }
    }
}
