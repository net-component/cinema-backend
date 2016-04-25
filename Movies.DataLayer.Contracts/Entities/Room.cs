using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.Contracts.Entities
{
    public class Room : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rows { get; set; }

        public int SeatsInRow { get; set; }
    }
}
