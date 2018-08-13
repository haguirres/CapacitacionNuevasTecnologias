using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public DateTime HiringDate { get; set; }
        public virtual IEnumerable<PersonsEmployess> Persons { get; set; }

        /*
        [Key]
        public int PersonId { get; set; }        
        public Person Person { get; set; }
        public DateTime HiringDate { get; set; }
        /////////////////////////////////////////////////
        public int EmployeeId { get; set; }
        
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
         */
    }
}