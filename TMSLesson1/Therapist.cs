using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TMSLesson1
{
    public class Therapist : Doctor
    {
        public Therapist(string name, int visitCost, string qualification, int id) : base(name, visitCost, qualification, id) { }
        public string specialization = "Therapist";

        public override string GetSpecilaization()
        {
            return specialization;
        }
        public override void Treat()
        {
            Console.WriteLine(specialization + " " + name + " treats...");
        }
    }
}
