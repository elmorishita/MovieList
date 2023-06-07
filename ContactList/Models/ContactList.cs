using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public class Contact
    {
        // EF Core will configure the db to generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        [Range(10, 10, ErrorMessage = "Must be 10x digits")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a note.")]
        public string Note { get; set; } = string.Empty;


        // a read-only property for the slug at the end of the URL
        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
