using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Student
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public int PhoneNumber  { get; set; }
       public string Address { get; set; }
       public string LastName { get; set; }
       public DateTime DateOfBirth { get; set; }
       public string Gender { get; set; }
      
       public MemoryStream Photo { get; set; }
                

    }
}
