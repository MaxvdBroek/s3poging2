using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForestAPI.Models
{
    public class Page
    {
        public int PageID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Information { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public DateTime LastUpdated { get; set; }
    }

}
