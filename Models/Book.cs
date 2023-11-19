using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Spinu_Iulian_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Titlul cărții este obligatoriu.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul cărții trebuie să aibă între 3 și 150 de caractere.")]
        public string Title { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
            [Range(0.01, 500)]

        public decimal Price { get; set; }
       

        public int? AuthorID { get; set; } // Cheie străină
        public Author? Author { get; set; } // navigation property
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navigation property
        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }

    }

}
