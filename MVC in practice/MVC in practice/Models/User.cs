﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_in_practice.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}