using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SeriesEntity
    {
        public SeriesEntity()
        {
            ListOfSeasons = new List<SeasonEntity>();
        }

        public string Id { get; set; }
        public string ProviderName { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Date { get; set; }
        public string Synopsis { get; set; }
        public string MPPARating { get; set; }
        public string Rating { get; set; }
        public string Budget { get; set; }
        public string Revenue { get; set; }
        public string NumberOfSeasons { get; set; }
        public string NumberOfEpisodes { get; set; }

        public string[] Actors { get; set; }
        public string[] Studios { get; set; }
        public string[] Productors { get; set; }
        public string[] Writers { get; set; }
        public string[] Posters { get; set; }
        public string[] Backdrops { get; set; }
        public string[] Countries { get; set; }
        public string[] Genres { get; set; }

        public List<SeasonEntity> ListOfSeasons { get; set; }
    }
}
