using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank.Infrastructure.Entities
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("CompId")]
        public Company Company { get; set; }

    }

}
