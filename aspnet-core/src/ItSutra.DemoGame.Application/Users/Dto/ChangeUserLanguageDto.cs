using System.ComponentModel.DataAnnotations;

namespace ItSutra.DemoGame.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}