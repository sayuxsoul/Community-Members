using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKKK.Entities
{
    internal class Teacher:Employee
    {
        public string TeacherCode {  get; set; }

        public String Subject { get; set; }

        public int HoursperWeek {  get; set; }

        public String classroom { get; set; }
    }
}
