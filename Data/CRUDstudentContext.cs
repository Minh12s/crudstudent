﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDstudent.Models;

namespace CRUDstudent.Data
{
    public class CRUDstudentContext : DbContext
    {
        public CRUDstudentContext (DbContextOptions<CRUDstudentContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDstudent.Models.Student> Student { get; set; } = default!;
    }
}
