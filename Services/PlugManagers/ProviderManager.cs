using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plug_Host.Provider_Host;

namespace Services.ProviderManager
{
    public class ProviderManager
    {
        /// <summary>
        /// In order to use Asynchrone callback, you have to save delegates from the UI.
        /// That delegate makes able the providerManager object to impact changes in the UI, when he receive data from provider.
        /// </summary>
        public Delegate callbackSearchMovie;
        public Delegate callbackSearchSeries;
        public Delegate callbackFetchMovieData;
        public Delegate callbackFetchSeriesData;
        public Delegate callbackFetchSeasonData;
        public Delegate callbackFetchEpisodeData;

        private delegate void Callback(string providerName, string text);
        private delegate void ErrorCallback(string providerName, Exception e);

        private ProviderManager(){}

        public ProviderManager(Delegate movies, Delegate series, Delegate movieData, Delegate seriesData, Delegate seasonData, Delegate episodeData)
        {
            this.callbackSearchMovie = movies;
            this.callbackSearchSeries = series;
            this.callbackFetchMovieData = movieData;
            this.callbackFetchSeriesData = seriesData;
            this.callbackFetchSeasonData = seasonData;
            this.callbackFetchEpisodeData = episodeData;
        }

        /// <summary>
        /// Call provider .dll(s) to search and give back movies which has matched with $title
        /// </summary>
        /// <param name="title">Movie title</param>
        public void callSearchMovie(string title)
        {
            Callback d = resultSearchMovies;
            ErrorCallback error = providerError;
            try
            {
                ProviderHost.getInstance().searchMovies(d,error, title);
            }
            catch (Exception e) 
            {
                Log.getInstance().error("ProviderManager -> callSearchMovie", e);
            }
        }

        /// <summary>
        /// Call provider .dll(s) to search and give back series that have matched with $title
        /// </summary>
        /// <param name="title">Series title</param>
        public void callSeachSeries(string title)
        {
            Callback d = resultSearchSeries;
            ErrorCallback error = providerError;
            try
            {
                ProviderHost.getInstance().searchSeries(d,error, title);
            }
            catch (Exception e)
            {
                Log.getInstance().error("ProviderManager -> callSearchSeries", e);
            }
        }

        public void callFetchMovieData(string providerName, string id)
        {
            Callback d = resultFetchMovieData;
            ErrorCallback error = providerError;
            try
            {
                ProviderHost.getInstance().fetchMovieData(d, error, providerName, id);
            }
            catch(Exception e)
            {
                Log.getInstance().error("ProviderManager -> callFetchMovieData", e);
            }
        }

        public void callFetchSeriesData(string providerName, string id)
        {
            Callback d = resultFetchSeriesData;
            ErrorCallback error = providerError;
            try
            {
                ProviderHost.getInstance().fetchSeriesData(d, error, providerName, id);
            }
            catch (Exception e)
            {
                Log.getInstance().error("ProviderManager -> callFetchSeriesData", e);
            }
        }

        public void callFetchSeasonData(string providerName, string id, string season)
        {
            Callback d = resultFetchSeasonData;
            ErrorCallback error = providerError;
            try
            {
                ProviderHost.getInstance().fetchSeasonData(d, error, providerName, id, season);
            }
            catch (Exception e)
            {
                Log.getInstance().error("ERROR : ProviderManager -> callFetchSeasonData", e);
            }
        }

        public void callFetchEpisodeData(string providerName, string id, string season, string episode)
        {
            Callback d = resultFetchEpisodeData;
            ErrorCallback error = providerError;
            try
            {
                ProviderHost.getInstance().fetchEpisodeData(d, error, providerName, id, season, episode);
            }
            catch (Exception e)
            {
                Log.getInstance().error("ProviderManager -> callFetchEpisodeData", e);
            }
        }

        private void providerError(string providerName, Exception e)
        {
            Log.getInstance().error("ProviderManager -> providerError:" + providerName, e);
        }

        private void resultSearchMovies(string providerName, string text)
        {
            this.callbackSearchMovie.DynamicInvoke(Mapper.Mapper.jsonArrayToMovieList(text));
        }

        private void resultSearchSeries(string providerName, string text)
        {
            this.callbackSearchSeries.DynamicInvoke(Mapper.Mapper.jsonArrayToSeriesList(text));
        }

        private void resultFetchMovieData(string providerName, string text)
        {
            this.callbackFetchMovieData.DynamicInvoke(Mapper.Mapper.jsonToMovie(text));
        }

        private void resultFetchSeriesData(string providerName, string text)
        {
            this.callbackFetchSeriesData.DynamicInvoke(Mapper.Mapper.jsonToSeries(text));
        }

        private void resultFetchSeasonData(string providerName, string text)
        {
            this.callbackFetchSeasonData.DynamicInvoke(Mapper.Mapper.jsonToSeason(text));
        }

        private void resultFetchEpisodeData(string providerName, string text)
        {
            this.callbackFetchEpisodeData.DynamicInvoke(Mapper.Mapper.jsonToEpisode(text) );
        }
    }
}
