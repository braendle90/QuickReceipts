using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickReceipts.Models
{
    public class Customer
    {
        public int Id { get; set; }         // Primary key
        public int CustomerId { get; set; } 
        public string FirstName { get; set; } // For individual clients
        public string LastName { get; set; } // For individual clients
        public string CompanyName { get; set; } // For corporate clients
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; } // Customer status
        public CustomerType Type { get; set; } // Indicates individual or corporate client
    }

    public enum CustomerType
    {
        Private,
        Firma
    }
}
