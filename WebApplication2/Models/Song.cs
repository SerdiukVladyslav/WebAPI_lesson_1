using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Song
    {
        public int SongId { get; set; }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public Artists Artists { get; set; }

        public Albums Albums { get; set; }

        public Countries Countries { get; set; }

        public string? MusicFile { get; set; }
    }
}
