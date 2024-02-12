using System.Numerics;
using TMSLesson1;

internal class Program
{
    public delegate void SayGoodbye();
    public static event SayGoodbye DoctorSayGoodbye;
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

        Cabinet<Dentist> tomCabinet = new Cabinet<Dentist>(tom, 101);
        Cabinet<Dentist> billCabinet = new Cabinet<Dentist>(tom, 102);
        Cabinet<Therapist> garryCabinet = new Cabinet<Therapist>(garry, 103);
        Cabinet<Therapist> johnCabinet = new Cabinet<Therapist>(john, 104);
        Cabinet<Surgeon> samCabinet = new Cabinet<Surgeon>(sam, 106);
        Cabinet<Surgeon> nickCabinet = new Cabinet<Surgeon>(nick, 106);

        List<Cabinet<Dentist>> dentistCabinets = new List<Cabinet<Dentist>>();
        dentistCabinets.Add(tomCabinet);
        dentistCabinets.Add(billCabinet);
        List<Cabinet<Therapist>> therapistCabinets = new List<Cabinet<Therapist>>();
        therapistCabinets.Add(garryCabinet);
        therapistCabinets.Add(johnCabinet);
        List<Cabinet<Surgeon>> surgeonCabinets = new List<Cabinet<Surgeon>>();
        surgeonCabinets.Add(samCabinet);
        surgeonCabinets.Add(nickCabinet);

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

        List<Doctor> requestedDoctors = doctors.Where(a => a.GetSpecilaization().Equals(requestedDoctorType)).ToList();
        foreach (Doctor doctor in requestedDoctors)
        {
            Console.WriteLine(doctor.GetSpecilaization() + " " + doctor.name + " - " + doctor.qualification + "(id:" + doctor.id +
                    "). Cost of the visit is: " + doctor.visitCost + "$");
        }

        int doctorId = 0;
        while (doctorId == 0)
        {
            Console.WriteLine("Please enter id of the doctor");
            try
            {
                doctorId = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Entered id is not an integer");
            }
        }

        var selectedDoctor = doctors.Where(a=>a.id == doctorId).First();

        int doctorCabinet = 0;
        switch (selectedDoctor.GetSpecilaization())
        {
            case "Dentist":
                doctorCabinet = dentistCabinets.Where(a => a.Doctor.name == selectedDoctor.name).First().CabinetBumber;
                break;
            case "Therapist":
                doctorCabinet = therapistCabinets.Where(a => a.Doctor.name == selectedDoctor.name).First().CabinetBumber;
                break;
            case "Surgeon":
                doctorCabinet = surgeonCabinets.Where(a => a.Doctor.name == selectedDoctor.name).First().CabinetBumber;
                break;
        }
        Console.WriteLine("Cabinet number is: " + doctorCabinet);
        selectedDoctor.Treat();
        selectedDoctor.Work();
        selectedDoctor.PrintVisitCost();

        // All doctors of the clicnic say Goodbye to the patient
        foreach (Doctor doctor in doctors)
        {
            DoctorSayGoodbye += doctor.SayGoodbye;
        }
        DoctorSayGoodbye.Invoke();
    }
}