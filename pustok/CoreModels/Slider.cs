using pustok.Enums;
using System.ComponentModel.DataAnnotations;

namespace pustok.CoreModels
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title {  get; set; }
        [Required]
        [MaxLength(40)]
        public string Description { get; set; }
        [Required]
        [MaxLength(40)]
        public string BottomText { get; set; }
        [Required]
        

        public HeroAreaTextPosition TextPosition { get; set; }
        
[Required]
        public string ImageUrl {  get; set; }
        
    }
}
