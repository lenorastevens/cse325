using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int Id { get; set; }

        [Display(Name = "Entry Date"), DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [StringLength(25, MinimumLength = 3), Required]
        public required string StandardWork { get; set; }

        [StringLength(25, MinimumLength = 3), Required]
        public required string Book { get; set; }

        [Required]
        public int Chapter { get; set; }

        [Display(Name = "Start"), Required]
        public int StartVerse { get; set; }

        [Display(Name = "End")]
        public int? EndVerse { get; set; }

        [Required]
        public required string Impression { get; set; }

        [Display(Name = "Verse Text"), Required]
        public required string VerseText { get; set; }

    }
}
