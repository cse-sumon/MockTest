using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QuestionModel
    {
        public int Id { get; set; }
        [Required]
        public int StepId { get; set; }
        [Required]
        public string QuestionName { get; set; }
        [Required]
        public string Option_1 { get; set; }
        [Required]
        public string Option_2 { get; set; }
        [Required]
        public string Option_3 { get; set; }
        [Required]
        public string Option_4 { get; set; }
        [Required]
        public string Answer { get; set; }
    }
}
