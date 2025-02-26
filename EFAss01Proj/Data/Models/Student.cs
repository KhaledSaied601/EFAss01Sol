using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAss01Proj.Data.Models
{
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string FName { get; set; }

        public string LName { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public int Dept_Id { get; set; }


    }
}
