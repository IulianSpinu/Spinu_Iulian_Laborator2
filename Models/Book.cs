using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Spinu_Iulian_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public int? AuthorID { get; set; } // Cheie străină
        public Author Author { get; set; } // navigation property
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher Publisher { get; set; } //navigation property

        public ICollection<BookCategory>? BookCategories { get; set; }

    }

}
