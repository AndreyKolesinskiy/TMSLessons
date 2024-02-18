using TMSLesson1;

internal class Program
{
    public delegate void SayGoodbye();
    public static event SayGoodbye DoctorSayGoodbye;
    private static void Main(string[] args)
    {
        Clinic clinic = new Clinic();
        clinic.InitializeClicnic();
        clinic.GetRequestedDoctorType();
        clinic.PrintRequestedDoctors();
        clinic.PrintCabinetNumber();
        clinic.DoctorWorks();
        clinic.DoctorsSayGoodbye();
    }
}