using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCrud_Auth.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Developer")]
        public string Developer { get; set; }


        [Display(Name = "Console")]
        public int GameSystemId { get; set; }

        public virtual GameSystem? GameSystem { get; set; }

        [NotMapped]
        public bool ShowModifyLinks { get; set; }
    }
}
