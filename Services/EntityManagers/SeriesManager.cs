using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Services
{
    public static class SeriesManager
    {
        public static SeasonEntity getSeasonNumberXOf(int number, SeriesEntity series)
        {
            foreach (SeasonEntity season in series.ListOfSeasons) {
                int n = Int32.Parse(season.Number);
                if(n == number){
                    return season;
                }
            }
            return new SeasonEntity();
        }


    }
}
