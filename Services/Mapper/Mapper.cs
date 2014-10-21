using LitJson;
using Model;
using Model.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapper
{
    public class Mapper
    {
        public static string catchPropertie(JsonData data, string propertyName)
        {
            try
            {
                return data[propertyName] + "";
            }
            catch (Exception e)
            {
                Log.getInstance().info("Mapper --> catchPropertie ->> Could not catch information " + propertyName + "in the Json Data");
                Log.getInstance().handle(e);
            }
            return "";
        }

        public static EpisodeEntity jsonToEpisode(string src)
        {
            return JsonMapper.ToObject<EpisodeEntity>(src);
        }

        public static MovieEntity jsonToMovie(string src)
        {
            return JsonMapper.ToObject<MovieEntity>(src);
        }

        public static SeasonEntity jsonToSeason(string src)
        {
            return JsonMapper.ToObject<SeasonEntity>(src);
        }

        public static SeriesEntity jsonToSeries(string src)
        {
            return JsonMapper.ToObject<SeriesEntity>(src);
        }

        public static List<MovieEntity> jsonArrayToMovieList(string src)
        {
            JsonData data = JsonMapper.ToObject(src);
            
            if(!data.IsArray)
            {
                Log.getInstance().info("Mapper --> jsonArrayToMovieList ->> source is not an array");
            }

            if (data.Count == 0)
            {
                return new List<MovieEntity>();
            }
            else
            {
                List<MovieEntity> resList = new List<MovieEntity>();

                for (int i = 0; i < data.Count; i++)
                {
                    resList.Add(jsonToMovie(data[i] + ""));
                }
                return resList;
            }
        }

        public static List<SeriesEntity> jsonArrayToSeriesList(string src)
        {
            JsonData data = JsonMapper.ToObject(src);

            if(!data.IsArray)
            {
                Log.getInstance().info("Mapper --> jsonArrayToSeriesList ->> source is not an array");
            }

            if (data.Count == 0)
            {
                return new List<SeriesEntity>();
            }
            else
            {
                List<SeriesEntity> resList = new List<SeriesEntity>();

                for (int i = 0; i < data.Count; i++)
                {
                    resList.Add(jsonToSeries(data[i] + ""));
                }
                return resList;
            }
        }
    }
}
