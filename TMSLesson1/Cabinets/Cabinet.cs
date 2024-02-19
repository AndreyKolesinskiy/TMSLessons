namespace TMSLesson1
{
    public class Cabinet<T>
    {
        public T Doctor;
        public int CabinetNumber;

        public Cabinet(T Doctor, int cabinetNumber)
        {
            this.Doctor = Doctor;
            this.CabinetNumber = cabinetNumber;
        }
    }
}
