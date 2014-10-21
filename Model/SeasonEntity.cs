using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Bean
    /// </summary>
    public class SeasonEntity
    {
        public SeasonEntity()
        {
            ListOfEpisodes = new List<EpisodeEntity>();
        }

        public string Number { get; set; }
        public string ProductionDate { get; set; }

        public List<EpisodeEntity> ListOfEpisodes { get; set; }
    }
}
