using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class MusicPortalContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Countries> Countries { get; set; }

        public MusicPortalContext(DbContextOptions<MusicPortalContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                Albums slipknotAlbum = new Albums { Album = "Slipknot", AlbumCover = "/Images/Slipknot Self-Titled.jpg", Year = 1999 };
                Albums mutterAlbum = new Albums { Album = "Mutter", AlbumCover = "/Images/Mutter.jpg", Year = 2001 };
                Albums rideTheLightningAlbum = new Albums { Album = "Ride The Lightning", AlbumCover = "/Images/Ride the Lightning.png", Year = 1984 };
                Artists slipknotArtist = new Artists { Artist = "Slipknot" };
                Artists rammsteinArtist = new Artists { Artist = "Rammstein" };
                Artists metallicaArtist = new Artists { Artist = "Metallica" };
                Countries usaCountry = new Countries { Country = "США" };
                Countries germanCountry = new Countries { Country = "Німеччина" };
                Genre metalGenre = new Genre { Name = "Метал" };
                Genre rockGenre = new Genre { Name = "Рок" };

                Albums?.Add(slipknotAlbum);
                Albums?.Add(mutterAlbum);
                Albums?.Add(rideTheLightningAlbum);
                Artists?.Add(slipknotArtist);
                Artists?.Add(rammsteinArtist);
                Artists?.Add(metallicaArtist);
                Countries?.Add(usaCountry);
                Countries?.Add(germanCountry);
                Genres?.Add(metalGenre);
                Genres?.Add(rockGenre);

                Songs?.Add(new Song { Title = "(sic)", Albums = slipknotAlbum, Genre = metalGenre, Artists = slipknotArtist, Countries = usaCountry, MusicFile = "/Songs/(sic).mp3" });
                Songs?.Add(new Song { Title = "Sonne", Albums = mutterAlbum, Genre = metalGenre, Artists = rammsteinArtist, Countries = germanCountry, MusicFile = "/Songs/Sonne.mp3" });
                Songs?.Add(new Song { Title = "For Whom The Bell Tolls", Albums = rideTheLightningAlbum, Genre = metalGenre, Artists = metallicaArtist, Countries = usaCountry, MusicFile = "/Songs/For Whom The Bell Tolls.mp3" });

                SaveChanges();
            }
        }
    }
}
