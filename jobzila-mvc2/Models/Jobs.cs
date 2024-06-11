using System.ComponentModel.DataAnnotations;

namespace jobzila_mvc2.Models
{
    public class Jobs
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title should be min 5 and max 100 characters")]
        public string Title { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Company should be min 5 and max 100 characters")]
        public string Company { get; set; }

        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Description should be min 5 and max 1000 characters")]
        public string Description { get; set; }


        public string _author;

        public string Author
        {


            get
            {

                if (_author == null)
                {
                    _author = "Sadeed";
                }

                return _author;

            }




            set { _author = value; }


        }

        public DateTime _posted = DateTime.Now;

        public DateTime Posted
        {

            get { return _posted; }

            set { _posted = value; }

        }

    }
}
