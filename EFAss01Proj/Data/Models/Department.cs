using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAss01Proj.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateOnly HiringDate { get; set; }

        public int Ins_Id { get; set; }
    }
}
