using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Theme
    {
        public int ThemeId { get; set; }
        [Required]
        public string Name { get; set; }
        //public IList<QuestionTheme> QuestionThemes { get; set; }
    }
}
