using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.Contracts.Entities
{
    public class Movie : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime PremierDate { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
