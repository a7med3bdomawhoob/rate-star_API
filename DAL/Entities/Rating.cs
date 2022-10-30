using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public string CommentTextArea { get; set; }
        public string ChooceProblem { get; set; }
        public int Rate { get; set; }

    }
}
