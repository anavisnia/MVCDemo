using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
