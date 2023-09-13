﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TestPrsApi
{
	public class User
	{
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;

        public string Firstname { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public bool IsReviewer { get; set; }

        public bool IsAdmin { get; set; }
    }
}

