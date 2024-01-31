using TMSLesson1;

internal class Program
{
    private static void Main(string[] args)
    {
        //This program lets user to select needed specialist and get treatment through the terminal
        Dentist tom = new Dentist("Tom", (int)Values.HourCost.Intern, Values.qualifications[1], 23);
        Dentist bill = new Dentist("Bill", (int)Values.HourCost.FirstCategory, Values.qualifications[2], 17);
        Therapist garry = new Therapist("Garry", (int)Values.HourCost.HighestCategory, Values.qualifications[3], 91);
        Therapist john = new Therapist("John", (int)Values.HourCost.Professor, Values.qualifications[4], 65);
        Surgeon sam = new Surgeon("Sam", (int)Values.HourCost.HighestCategory, Values.qualifications[3], 31);
        Surgeon nick = new Surgeon("Nick", (int)Values.HourCost.Professor, Values.qualifications[4], 77);

        List<Doctor> doctors = new List<Doctor>();
        doctors.Add(tom);
        doctors.Add(bill);
        doctors.Add(garry);
        doctors.Add(john);
        doctors.Add(sam);
        doctors.Add(nick);

        Console.WriteLine("Hi, where do you fill pain: head, teeth, back. Please enter answer");
        string painArea = Console.ReadLine();
        string requestedDoctorType = "";
        if (painArea == "head")
        {
            requestedDoctorType = "Therapist";
        }
        else if (painArea == "teeth")
        {
            requestedDoctorType = "Dentist";
        }
        else if (painArea == "back")
        {
            requestedDoctorType = "Surgeon";
        }

        foreach (Doctor doctor in doctors)
        {
            if (doctor.GetSpecilaization() == requestedDoctorType)
            {
                Console.WriteLine(doctor.GetSpecilaization() + " " + doctor.name + " - " + doctor.qualification + "(id:" + doctor.id +
                    "). Cost of the visit is: " + doctor.visitCost + "$");
            }
        }

        Console.WriteLine("Please enter id of the doctor");
        int doctorId = Convert.ToInt32(Console.ReadLine());

        foreach (Doctor doctor in doctors)
        {
            if (doctor.id == doctorId)
            {
                doctor.Work();
                doctor.Treat();
                doctor.PrintVisitCost();
            }
        }
    }
}