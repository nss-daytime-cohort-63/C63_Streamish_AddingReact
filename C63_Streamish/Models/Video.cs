﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace C63_Streamish.Models
{
    public class Video
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
