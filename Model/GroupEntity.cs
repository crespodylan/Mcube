using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class GroupEntity : Entity
    {
        public Dictionary<PersonEntity, String> PersonInstrument { get; set; }
        public string Country { get; set; }
        public List<string> Genres { get; set; }
        public DateTime CreationDate { get; set; }
        List<string> Labels { get; set; }
        public String Website { get; set; }
        public String History { get; set; }
        public List<AlbumEntity> Albums { get; set; }
    }
}
