using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace jobzila_mvc2.Models
{
    public class Post
    {

        public long Id { get; set; }


        public string _key;
        public string key {

            get { 
                if(_key==null) {

                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");

                    return _key; 
                
                }
            
            return _key;
            }
            set { _key = value; } 
        
        
        }

        //Dataanotations
        [Display(Name = "Post Title")]
        [Required]
        [StringLength(100, MinimumLength =5, ErrorMessage ="Title should be min 5 and max 100 characters")]
        public string Title { get; set; }

        [Required]
        [MinLength(100, ErrorMessage ="Blog must be 100 character or more.")]
        [Display(Name ="My Blog Content")]
        public string Body { get; set; }


        public string _author;

        public string Author {


            get {

                if (_author == null)
                {
                    _author = "Sadeed";
                }

                return _author;

            }
                
                
            
            
            set { _author = value; } 
        
        
        }

        public DateTime _posted = DateTime.Now;

        public  DateTime Posted{

            get { return _posted; }

            set { _posted = value; } 
        
        }
    }
}
