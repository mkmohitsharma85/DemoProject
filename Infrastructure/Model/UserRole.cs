﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class UserRole : BaseClass
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
