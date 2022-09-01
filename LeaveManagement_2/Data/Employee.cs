using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace LeaveManagement_2.Data
{
    public class Employee : IdentityUser
    {
public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string TaxId { get; set; }   
        public DateTime DateOfBirth { get; set; }   
        public DateTime DateJoined { get; set; }    
    }
}
