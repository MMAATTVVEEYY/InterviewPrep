using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        //[Required]
        //public string Title { get; set; }
        [Required]
        public string QuestionText { get; set; }
        [Required]
        public string AnswerText { get; set; }
        public string ImagePath { get; set; }
        // public IList<QuestionTheme> QuestionThemes { get; set; }


    }
}
