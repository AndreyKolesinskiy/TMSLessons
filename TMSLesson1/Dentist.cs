using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson1
{
    public class Dentist : Doctor
    {
        public Dentist(string name, int visitCost, string qualification, int id) : base(name, visitCost, qualification, id) { }
        public string specialization = "Dentist";

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
