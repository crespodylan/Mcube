using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class MusicEntity : Entity
    {
        public String _sName { get; set; }
        public DateTime _dRecording { get; set; }
        public int _iLength { get; set; }
        public GenreEntity _cGenre { get; set; }
        public GroupEntity _cGroup { get; set; }
        public List<Entity> _cProducters { get; set; }
        public String _sLabel { get; set; }
        public Dictionary<string, int> _dRankingCountry { get; set; }
        public String _sOtherInformations { get; set; }
        public List<Entity> _cInterpreters { get; set; }
        public List<Entity> _cMusicians { get; set; }
    }
}
