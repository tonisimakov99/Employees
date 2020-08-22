using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    [Serializable]
    public class Employee
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string SurName { get; set; }
        
        [Required]
        public string Patronymic { get; set; }
        
        [Required]
        public string Position { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime? EmploymentDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DismissalDate { get; set; }
    }
}
