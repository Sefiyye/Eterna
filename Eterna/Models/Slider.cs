using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [NotMapped]
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Btn { get; set; }
    }
}
