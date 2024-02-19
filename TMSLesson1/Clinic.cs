using TMSLesson1.Doctors;
using TMSLesson1.Enums;

namespace TMSLesson1
{
    internal class Clinic
    {
        List<Doctor> doctors;
        Dentist tom;
        Dentist bill;
        Therapist garry;
        Therapist john;
        Surgeon nick;
        Surgeon sam;
        List<Cabinet<Dentist>> dentistCabinets;
        List<Cabinet<Therapist>> therapistCabinets;
        List<Cabinet<Surgeon>> surgeonCabinets;
        Doctor selectedDoctor;
        string requestedDoctorType;
        public delegate void SayGoodbye();
        public static event SayGoodbye DoctorSayGoodbye;

        public void InitializeClicnic()
        {
            InitializeDoctors();
            InitializeDentistCabinets();
            InitializeTherapistCabinets();
            InitializeSurgeonCabinets();
        }

        public List<Doctor> InitializeDoctors()
        {
            tom = new Dentist("Tom", (int)Values.HourCost.Intern, Values.qualifications[1], 23);
            bill = new Dentist("Bill", (int)Values.HourCost.FirstCategory, Values.qualifications[2], 17);
            garry = new Therapist("Garry", (int)Values.HourCost.HighestCategory, Values.qualifications[3], 91);
            john = new Therapist("John", (int)Values.HourCost.Professor, Values.qualifications[4], 65);
            sam = new Surgeon("Sam", (int)Values.HourCost.HighestCategory, Values.qualifications[3], 31);
            nick = new Surgeon("Nick", (int)Values.HourCost.Professor, Values.qualifications[4], 77);
            
            doctors = new List<Doctor>();
            doctors.Add(tom);
            doctors.Add(bill);
            doctors.Add(garry);
            doctors.Add(john);
            doctors.Add(sam);
            doctors.Add(nick);
            return doctors;
        }

        public List<Cabinet<Dentist>> InitializeDentistCabinets()
        {
            Cabinet<Dentist> tomCabinet = new Cabinet<Dentist>(tom, 101);
            Cabinet<Dentist> billCabinet = new Cabinet<Dentist>(bill, 102);
            dentistCabinets = new List<Cabinet<Dentist>>();
            dentistCabinets.Add(tomCabinet);
            dentistCabinets.Add(billCabinet);
            return dentistCabinets;
        }

        public List<Cabinet<Therapist>> InitializeTherapistCabinets()
        {
            Cabinet<Therapist> garryCabinet = new Cabinet<Therapist>(garry, 103);
            Cabinet<Therapist> johnCabinet = new Cabinet<Therapist>(john, 104);
            therapistCabinets = new List<Cabinet<Therapist>>();
            therapistCabinets.Add(garryCabinet);
            therapistCabinets.Add(johnCabinet);
            return therapistCabinets;
        }

        public List<Cabinet<Surgeon>> InitializeSurgeonCabinets()
        {
            Cabinet<Surgeon> samCabinet = new Cabinet<Surgeon>(sam, 106);
            Cabinet<Surgeon> nickCabinet = new Cabinet<Surgeon>(nick, 106);
            surgeonCabinets = new List<Cabinet<Surgeon>>();
            surgeonCabinets.Add(samCabinet);
            surgeonCabinets.Add(nickCabinet);
            return surgeonCabinets;
        }

        public string GetRequestedDoctorType()
        {
            Console.WriteLine("Hi, where do you fill pain: \n 1. Head \n 2. Teeth \n 3. Back \n Please enter number");
            string painArea = Console.ReadLine();
            requestedDoctorType = "";
            if (painArea == "1")
            {
                requestedDoctorType = "Therapist";
            }
            else if (painArea == "2")
            {
                requestedDoctorType = "Dentist";
            }
            else if (painArea == "3")
            {
                requestedDoctorType = "Surgeon";
            }
            return requestedDoctorType;
        }

        public void PrintRequestedDoctors()
        {
            List<Doctor> requestedDoctors = doctors.Where(a => a.GetSpecilaization().Equals(requestedDoctorType)).ToList();
            foreach (Doctor doctor in requestedDoctors)
            {
                Console.WriteLine(doctor.GetSpecilaization() + " " + doctor.name + " - " + doctor.qualification + "(id:" + doctor.id +
                        "). Cost of the visit is: " + doctor.visitCost + "$");
            }
        }

        public Doctor SelectDoctor()
        {
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

            selectedDoctor = doctors.Where(a => a.id == doctorId).First();
            return selectedDoctor;
        }

        public void PrintCabinetNumber()
        {
            int doctorCabinet = 0;
            var selectedDoctor = SelectDoctor();
            switch (selectedDoctor.GetSpecilaization())
            {
                case "Dentist":
                    doctorCabinet = dentistCabinets.Where(a => a.Doctor.name == selectedDoctor.name).First().CabinetNumber;
                    break;
                case "Therapist":
                    doctorCabinet = therapistCabinets.Where(a => a.Doctor.name == selectedDoctor.name).First().CabinetNumber;
                    break;
                case "Surgeon":
                    doctorCabinet = surgeonCabinets.Where(a => a.Doctor.name == selectedDoctor.name).First().CabinetNumber;
                    break;
            }
            Console.WriteLine("Cabinet number is: " + doctorCabinet);
        }

        public void DoctorWorks()
        {
            selectedDoctor.Treat();
            selectedDoctor.Work();
            selectedDoctor.PrintVisitCost();
        }

        public void DoctorsSayGoodbye()
        {
            foreach (Doctor doctor in doctors)
            {
                DoctorSayGoodbye += doctor.SayGoodbye;
            }
            DoctorSayGoodbye.Invoke();
        }
    }
}
