using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class AlbumEntity
    {
        public string Title { get; set; }
        Dictionary<int, MusicEntity> Musics { get; set; }
        public int Duration { get; set; }
        public List<string> Genres { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Label { get; set;}
    }
}
