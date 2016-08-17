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
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTimeOffset CreationTime { get; set; }
        [DisplayName("Derniere modification")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTimeOffset LastModificationDate { get; set; }
        [DisplayName("Couverture")]
        public string FrontImage { get; set; }
        [DisplayName("Contenu")]
        public string Content { get; set; }
        [Required]
        [DisplayName("Nombre de contribution")]
        public int NbrContribution { get; set; }
        [Required]
        [DisplayName("Etat")]
        public int State { get; set; }
        [Required]
        [DisplayName("Genre")]
        public int Genre { get; set; }

        public enum EGenre
        {
            Comte,
            Fiction,
            Policier,
            Theatre,
        }

        public enum EEtat
        {
            Create,
            Actif,
            Inactif,
            Finis
        }
    }
}