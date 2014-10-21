using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Services.EntityManagers
{
    class SeasonManager
    {
        public static EpisodeEntity getEpisodeXOf(int number, SeasonEntity season)
        {
            foreach(EpisodeEntity episode in season.ListOfEpisodes) {
                int n = Int32.Parse(episode.Number);
                if(n == number) {
                    return episode;
                }
            }
            return new EpisodeEntity();
        }
    }
}
