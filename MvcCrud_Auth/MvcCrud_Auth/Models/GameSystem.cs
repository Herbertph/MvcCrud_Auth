using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCrud_Auth.Models
{
    public class GameSystem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Console Name")]
        public string GameSystemName { get; set; }

        public virtual ICollection<Game>? Games { get; set; }

        [NotMapped]
        public bool ShowModifyLinks { get; set; }
    }
}
