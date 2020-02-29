using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace upload.Models
{
    public class IMDB
    {
        [Key]
        public double SN { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Duration { get; set; }
        public string Type { get; set; }
        public string ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Stars { get; set; }
        public string Descreption { get; set; }

    }
}
