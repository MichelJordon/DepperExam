using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class Author
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string QuoteText { get; set; }
    }
}