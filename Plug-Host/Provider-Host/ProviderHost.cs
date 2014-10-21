using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plug_Host.Provider_Host
{
    /// <summary>
    /// 
    /// The code is repeat in each method for keep the dynamism of the provider dll loading
    /// 
    /// </summary>
    public class ProviderHost
    {
        private static ProviderHost singleton;

        private ProviderHost() { }

        public static ProviderHost getInstance()
        {
            if(singleton == null)
            {
                singleton = new ProviderHost();
            }
            return singleton;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="error"></param>
        /// <param name="title"></param>
        public void searchMovies(Delegate d, Delegate error, string title)
        {
            DirectoryInfo providersDir = new DirectoryInfo(@"Plugs\Providers");
            // if reportory exist, create is unabled
            providersDir.Create();

            FileInfo[] array = providersDir.GetFiles();

            foreach (FileInfo provider in array)
            {
                ObjectHandle handle = Activator.CreateInstanceFrom(provider.FullName,"IProvider");
                IProvider currentProvider = handle.Unwrap() as IProvider;
                new Thread(
                    () =>
                    {
                        try
                        {
                            Object[] argv = { provider.Name, currentProvider.searchMovies(title) };
                            d.DynamicInvoke(argv);
                        }
                        catch (Exception e)
                        {
                            Object[] argv = { provider.Name, e };
                            error.DynamicInvoke(argv);
                        }
                    }).Start();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="error"></param>
        /// <param name="title"></param>
        public void searchSeries(Delegate d, Delegate error, string title)
        {
            DirectoryInfo providersDir = new DirectoryInfo(@"Plugs\Providers");
            // if reportory exist, create is unabled
            providersDir.Create();

            FileInfo[] array = providersDir.GetFiles();

            foreach (FileInfo provider in array)
            {
                ObjectHandle handle = Activator.CreateInstanceFrom(provider.FullName, "IProvider");
                IProvider currentProvider = handle.Unwrap() as IProvider;
                new Thread(
                    () =>
                    {
                        try
                        {
                            Object[] argv = { provider.Name, currentProvider.searchSeries(title) };
                            d.DynamicInvoke(argv);
                        }
                        catch (Exception e)
                        {
                            Object[] argv = { provider.Name, e };
                            error.DynamicInvoke(argv);
                        }
                    }).Start();
            }
        }

        public void fetchMovieData(Delegate d, Delegate error, string providerName, string id)
        {
            DirectoryInfo providersDir = new DirectoryInfo(@"Plugs\Providers");
            // if reportory exist, create is unabled
            providersDir.Create();

            FileInfo[] providers = providersDir.GetFiles("*" + providerName + "*", SearchOption.TopDirectoryOnly);
            if(providers.Length != 1)
            {
                Object[] argv = { providerName, new FileNotFoundException("Le système a retourné " + providers.Length + " fichier(s)") };
                error.DynamicInvoke(argv);
                return;
            }

            ObjectHandle handle = Activator.CreateInstanceFrom(providers[0].FullName, "IProvider");
            IProvider currentProvider = handle.Unwrap() as IProvider;
            new Thread(
                () =>
                {
                    try 
	                {	                
                        Object[] argv = { providerName, currentProvider.fetchMovieData(id) };
                        d.DynamicInvoke(argv);
	                }
	                catch (Exception e)
	                {
                        Object[] argv = { providerName, e };
                        error.DynamicInvoke(argv);
	                }
                }).Start();
        }

        public void fetchSeriesData(Delegate d, Delegate error, string providerName, string id)
        {
            DirectoryInfo providersDir = new DirectoryInfo(@"Plugs\Providers");
            // if reportory exist, create is unabled
            providersDir.Create();

            FileInfo[] providers = providersDir.GetFiles("*" + providerName + "*", SearchOption.TopDirectoryOnly);
            if (providers.Length != 1)
            {
                Object[] argv = { providerName, new FileNotFoundException("Le système a retourné " + providers.Length + " fichier(s)") };
                error.DynamicInvoke(argv);
                return;
            }

            ObjectHandle handle = Activator.CreateInstanceFrom(providers[0].FullName, "IProvider");
            IProvider currentProvider = handle.Unwrap() as IProvider;
            new Thread(
                () =>
                {
                    try
                    {
                        Object[] argv = { providerName, currentProvider.fetchSeriesData(id) };
                        d.DynamicInvoke(argv);
                    }
                    catch (Exception e)
                    {
                        Object[] argv = { providerName, e };
                        error.DynamicInvoke(argv);
                    }
                }).Start();
        }

        public void fetchSeasonData(Delegate d, Delegate error, string providerName, string id, string season)
        {
            DirectoryInfo providersDir = new DirectoryInfo(@"Plugs\Providers");
            // if reportory exist, create is unabled
            providersDir.Create();

            FileInfo[] providers = providersDir.GetFiles("*" + providerName + "*", SearchOption.TopDirectoryOnly);
            if (providers.Length != 1)
            {
                Object[] argv = { providerName, new FileNotFoundException("Le système a retourné " + providers.Length + " fichier(s)") };
                error.DynamicInvoke(argv);
                return;
            }

            ObjectHandle handle = Activator.CreateInstanceFrom(providers[0].FullName, "IProvider");
            IProvider currentProvider = handle.Unwrap() as IProvider;
            new Thread(
                () =>
                {
                    try
                    {
                        Object[] argv = { providerName, currentProvider.fetchSeasonData(id,season) };
                        d.DynamicInvoke(argv);
                    }
                    catch (Exception e)
                    {
                        Object[] argv = { providerName, e };
                        error.DynamicInvoke(argv);
                    }
                }).Start();
        }

        public void fetchEpisodeData(Delegate d, Delegate error, string providerName, string id, string season, string episode)
        {
            DirectoryInfo providersDir = new DirectoryInfo(@"Plugs\Providers");
            // if reportory exist, create is unabled
            providersDir.Create();

            FileInfo[] providers = providersDir.GetFiles("*" + providerName + "*", SearchOption.TopDirectoryOnly);
            if (providers.Length != 1)
            {
                Object[] argv = { providerName, new FileNotFoundException("Le système a retourné " + providers.Length + " fichier(s)") };
                error.DynamicInvoke(argv);
                return;
            }

            ObjectHandle handle = Activator.CreateInstanceFrom(providers[0].FullName, "IProvider");
            IProvider currentProvider = handle.Unwrap() as IProvider;
            new Thread(
                () =>
                {
                    try
                    {
                        Object[] argv = { providerName, currentProvider.fetchEpisodeData(id, season, episode) };
                        d.DynamicInvoke(argv);
                    }
                    catch (Exception e)
                    {
                        Object[] argv = { providerName, e };
                        error.DynamicInvoke(argv);
                    }
                }).Start();
        }
    }
}
