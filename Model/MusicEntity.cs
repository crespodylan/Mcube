using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 
    /// </summary>
    class MusicEntity : Entity
    {
        public String Name { get; set; }
        public DateTime Recording { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }
        public GroupEntity Group { get; set; }
        public List<Entity> Producters { get; set; }
        public String Label { get; set; }
        public Dictionary<string, int> RankingCountry { get; set; }
        public String OtherInformations { get; set; }
        public List<PersonEntity> Musicians { get; set; }
        public List<PersonEntity> Compositors { get; set; }
        public PersonEntity Autor { get; set; }
        public AlbumEntity Album { get; set; }
        
    }
}
