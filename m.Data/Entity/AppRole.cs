using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace m.Data.Entity
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}