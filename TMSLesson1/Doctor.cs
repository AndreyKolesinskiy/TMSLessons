using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson1
{
    abstract public class Doctor : IWorkable
    {
        public string name;
        public int visitCost;
        public string qualification;
        public int id;

        public Doctor(string name, int visitCost, string qualification, int id)
        {
            this.name = name;
            this.visitCost = visitCost;
            this.qualification = qualification;
            this.id = id;
        }
        abstract public void Treat();
        abstract public string GetSpecilaization();

        public void PrintVisitCost()
        {
            Console.WriteLine("Your bill is: " + visitCost + "$. Please pay at the desk.");
        }

        public void Work()
        {
            Console.WriteLine("I'm working very hard... Please wait.");
        }

    }
}
