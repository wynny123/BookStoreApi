﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApi.Models
{
    [Table("Book")]
    public class Book
    {   public int Id { get; set; }
        public string BookTithle { get; set; }
        public string Author { get; set; }
        public DateTime Date_Published { get; set; }
        public string Genre { get; set; }
    }
}
