using System.ComponentModel.DataAnnotations;

namespace Skinet.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}