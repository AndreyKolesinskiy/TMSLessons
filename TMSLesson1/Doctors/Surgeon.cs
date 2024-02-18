namespace TMSLesson1.Doctors
{
    public class Surgeon : Doctor
    {
        public Surgeon(string name, int visitCost, string qualification, int id) : base(name, visitCost, qualification, id) { }
        public string specialization = "Surgeon";

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
