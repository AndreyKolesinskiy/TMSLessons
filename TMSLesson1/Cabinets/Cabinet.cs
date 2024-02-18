namespace TMSLesson1
{
    public class Cabinet<T>
    {
        public T Doctor;
        public int CabinetBumber;

        public Cabinet(T Doctor, int cabinetNumber)
        {
            this.Doctor = Doctor;
            this.CabinetBumber = cabinetNumber;
        }
    }
}
