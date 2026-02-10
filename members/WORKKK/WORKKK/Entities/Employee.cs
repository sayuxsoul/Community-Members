using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKKK.Entities
{
    internal class Employee:Communitymembers
    {
        public decimal Salary { get; set; }

        public DateTime HireDate {  get; set; }

        public bool IsActive { get; set; }
    }

}
