﻿using System.Collections.Generic;

namespace DbPerfTest.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}