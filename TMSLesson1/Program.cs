using TMSLesson1;

internal class Program
{
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