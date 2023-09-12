﻿using System.ComponentModel.DataAnnotations;

namespace VideoGameShowdown.Models
{
    public class RAWG_Store
    {
        #region Properties..
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Domain { get; set; }
        public int GamesCount { get; set; }
        public string ImageBackground { get; set; }
        #endregion Properties..
    }
}