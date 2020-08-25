using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeService.DataBase
{
    [Serializable]
    public class Employee
    {
        [Required] [Key]
        public int Id { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required] 
        public string Name { get; set; }

        [Required] 
        public string MiddleName { get; set; }

        [Required] 
        public string Position { get; set; }
        
        [Required]
        public decimal Salary { get; set; }

        [Required] [Column(TypeName = "Date")] 
        public DateTime? EmploymentDate { get; set; }

        [Column(TypeName = "Date")] 
        public DateTime? DismissalDate{ get; set; }
}
}
