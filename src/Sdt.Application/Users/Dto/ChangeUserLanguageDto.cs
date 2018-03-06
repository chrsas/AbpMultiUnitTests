using System.ComponentModel.DataAnnotations;

namespace Sdt.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}