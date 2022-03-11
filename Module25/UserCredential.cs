﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25
{
    public class UserCredential
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}