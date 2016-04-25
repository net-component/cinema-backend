using System;

namespace Movies.DataLayer.Contracts.Entities
{
    public class Program : IEntity
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int RoomId { get; set; }

        public DateTime When { get; set; }

        public Movie Movie { get; set; }

        public Room Room { get; set; }
    }
}
