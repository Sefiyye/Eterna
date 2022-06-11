using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.ViewModels
{
    public class HomeVM
    {
        public List<Setting> Settings{ get; set; }
        public List<SocialMedia>SocialMedias { get; set; }
        public List<Card> Cards { get; set; }
    }
}
