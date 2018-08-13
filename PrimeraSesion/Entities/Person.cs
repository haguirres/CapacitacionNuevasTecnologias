using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<PersonsEmployess> Employees { get; set; }                
    }
}