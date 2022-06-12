using Eterna.Models;
using System.Collections.Generic;

namespace Eterna.ViewModels
{
    public class ServiceVM
    {
        public List<Card> Cards { get; set; }
        public Statistics Statistics { get; set; }
        public List<Contact> Contacts { get; set; }
        public News News { get; set; }
    }
}
