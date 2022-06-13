using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Client> Clients { get; set; }
        public List<HomeCard> HomeCards { get; set; }
        public List<LastCard> LastCards { get; set; }
        public Rule Rules { get; set; }

    }
}
