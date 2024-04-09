using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Albums
    {
        public int Id { get; set; }

        public string Album { get; set; }

        public string? AlbumCover { get; set; }

        public int Year { get; set; }

        //public List<Song> Songs { get; set; }
    }
}
