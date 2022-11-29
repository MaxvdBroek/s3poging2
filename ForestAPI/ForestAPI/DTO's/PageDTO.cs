using ForestAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForestAPI.DTO_s
{
    public class PageDTO
    {
        public int PageID { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public int CategoryID { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
