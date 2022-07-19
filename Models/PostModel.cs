using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class PostModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Please enter the title of your publication")]
        public string PostName { get; set; }
        [Required(ErrorMessage = "Please write something in your post")]
        public string PostText { get; set; }
        [Required(ErrorMessage = "Please select a topic for your message")]
        public string PostTopic { get; set; }
    }
}
