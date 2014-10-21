using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Bean
    /// </summary>
    public class EpisodeEntity
    {
        public string Id { get; set; }
        public string ProviderName { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Synopsis { get; set; }
        public string ProductionDate { get; set; }
        public string MPPARating { get; set; }
        public string Rating { get; set; }

        public string[] Actors { get; set; }
    }
}
