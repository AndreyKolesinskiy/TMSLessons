using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson1
{
    internal class Cabinet<T>
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
