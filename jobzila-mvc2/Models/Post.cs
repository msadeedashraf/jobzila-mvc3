using System.ComponentModel.DataAnnotations;

namespace jobzila_mvc2.Models
{
    public class Post
    {
        //Dataanotations
        [Display(Name = "Post Title")]
        [Required]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Title should be min 5 and max 100 characters")]
        public string Title { get; set; }

        [Required]
        [MinLength(100, ErrorMessage ="Blog must be 100 character or more.")]
        [Display(Name ="My Blog Content")]
        public string Body { get; set; }

        public string Author { get; set; }
        public  DateTime Posted{ get; set; }
    }
}
