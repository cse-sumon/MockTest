using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ExamModel
    {
        public int Id { get; set; }
        [Required]
        public int StepId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int OutOfMark { get; set; }
        [Required]
        public int Mark { get; set; }
        [Required]
        public DateTime ExamDate { get; set; }
    }
}
