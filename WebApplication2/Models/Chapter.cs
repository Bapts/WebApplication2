using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ChapterBookController
    {
        public Chapter Chapter { get; set; }
        public List<Book> BooksList { get; set; }
    }

    public class Chapter
    {
        public int Id { get; set; }
        [DisplayName("Titre")]
        [DisplayFormat(DataFormatString = "{0,20}")]
        public string BookTitle { get; set; }
        [Required]
        public int BookId { get; set; }
        [DisplayName("No chapitre")]
        public int ChapterNumber { get; set; }
        [DisplayName("Nom du createur")]
        public string CreatorName { get; set; }
        public string CreatorId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTimeOffset CreationTime { get; set; }
        [DisplayName("Vote positif")]
        public int UpVote { get; set; }
        [DisplayName("Vote negatif")]
        public int DownVote { get; set; }
        [DisplayName("Contenue")]
        public string Content { get; set; }
        public string Comments { get; set; }
    }
}