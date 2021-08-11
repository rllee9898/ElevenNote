using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElevenNote.WebMVC.Models
{
    public class NoteListItem
    {
        [Display(Name = "Note ID")]
        public int NoteId { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}