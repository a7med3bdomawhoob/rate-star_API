using System.ComponentModel.DataAnnotations;

namespace RatingProjectApi.Dto
{
    public class RatingDto
    {
       
        public int CustomerId { get; set; }
        [MaxLength(500 ,ErrorMessage ="Must be more than or Equal 50") ]
        public string CommentTextArea { get; set; }
        public string ChooceProblem { get; set; }
        [Range(1, 5, ErrorMessage = "Must be Between 1 and 5")]
        public int Rate { get; set; }
    }

}
