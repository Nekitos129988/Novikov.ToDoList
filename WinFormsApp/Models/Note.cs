﻿using System;

namespace WinFormsApp.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
