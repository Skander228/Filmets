﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filmets.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<FilmDTO> Films { get; set; }
    }
}