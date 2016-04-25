﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.Contracts.Entities
{
    public class Actor : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Nationality { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
