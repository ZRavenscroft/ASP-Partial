using Pustok.Models;

namespace Pustok.ViewModels
{
    public class HomeViewModel
    {
        public List<Book> SpecialBooks { get; set; }
        public List<Book> NewBooks { get; set; }
        public List<Book> DiscountedBooks { get; set; }
    }
}
