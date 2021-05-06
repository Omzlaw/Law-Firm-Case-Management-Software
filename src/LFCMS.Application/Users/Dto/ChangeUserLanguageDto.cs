using System.ComponentModel.DataAnnotations;

namespace LFCMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}