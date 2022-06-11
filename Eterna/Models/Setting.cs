using System.Collections.Generic;

namespace Eterna.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TwitterIcon { get; set; }
        public string InstagramIcon { get; set; }
        public string SkypeIcon { get; set; }
        public string InIcon { get; set; }
        public string FacebookIcon { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
