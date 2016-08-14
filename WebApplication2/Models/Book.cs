using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [DisplayName("Titre")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Resume")]
        public string Summary { get; set; }
        [DisplayName("Auteurs")]
        public string Authors { get; set; }
        [DisplayName("Dernier Chapitre")]
        public string LastChapter { get; set; }
        [DisplayName("Nombres de chapitres")]
        public int ChapterCount { get; set; }
        [DisplayName("Date de creation")]
        public DateTimeOffset CreationTime { get; set; }
        [DisplayName("Derniere modification")]
        public DateTimeOffset LastModificationDate { get; set; }
        [DisplayName("Couverture")]
        public string FrontImage { get; set; }
        [DisplayName("Contenu")]
        public string Content { get; set; }
    }
}