using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plug_Host.Provider_Host
{
    public interface IProvider
    {
        /// <summary>
        /// Send a request to search if the movie "$Title" is on the ApiWeb's database 
        /// 
        /// </summary>
        /// <param name="title">Movie name</param>
        /// <returns> Json file which contains list of movies that matched on the ApiWeb </returns>
        string searchMovies(string title);

        /// <summary>
        /// Send a request to search if the tvshow "$Title" is on the ApiWeb's database
        /// 
        /// </summary>
        /// <param name="title">tvshow name</param>
        /// <returns> Json file which contains list of tvshows that matched on the ApiWeb </returns>
        string searchSeries(string title);

        /// <summary>
        /// Send a request to search metadata about the movie
        /// 
        /// </summary>
        /// <param name="id">The id of the movie</param>
        /// <returns> Json file which contains metadata about the movie </returns>
        string fetchMovieData(string id);

        /// <summary>
        /// Send a request to search metadata about the tvshow
        /// 
        /// </summary>
        /// <param name="id">The id of the tvshow</param>
        /// <returns> Json file which contains metadata about the tvshow </returns>
        string fetchSeriesData(string id);

        /// <summary>
        /// Send a request to search metadata about a season of one series 
        /// 
        /// </summary>
        /// <param name="id">The id of the tvshow</param>
        /// <param name="season">The number of the interested season</param>
        /// <returns> Json file which contains metadata about the season of one serie </returns>
        string fetchSeasonData(string id, string season);

        /// <summary>
        /// Send a request to search metadata about a episode of one series 
        /// 
        /// </summary>
        /// <param name="id">The id of the tvshow</param>
        /// <param name="season">The number of the interested season</param>
        /// <param name="episode">The number of the interested episode</param>
        /// <returns> Json file which contains metadata about the episode of one serie </returns>
        string fetchEpisodeData(string id, string season, string episode);
    }
}
