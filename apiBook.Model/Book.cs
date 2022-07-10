using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiBook.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string? NameBook { get; set; }
        public string? Descriptionbook { get; set; }
        public string? Authorbook { get; set; }
        public string? PublicationDate { get; set; }
        public int NumberCopies { get; set; }
        public Double Cost { get; set; }
        
    }
}
