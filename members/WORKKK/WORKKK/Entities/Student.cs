using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKKK.Entities
{
    internal class Student:Communitymembers
    {
        public string Carrier {  get; set; }

        public string Studentnumber { get; set; }

        public string semester {  get; set; }

        public bool IsActive { get; set; }
    }
}
