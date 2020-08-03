using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cdc.Covid.WebScraper
{
    public sealed class ReportGenerator
    {
        private readonly object _syncLock = new object();

        public List<StateReport> Generate()
        {
            List<StateReport> stateReports = new List<StateReport>();

            Parallel.ForEach(GetScraperList(), scraper =>
            {
                StateReport stateReport = scraper.ExecuteScrapeAsync().Result;
                lock (_syncLock) { stateReports.Add(stateReport); }
            });

            return stateReports;
        }

        private List<IStateScraper> GetScraperList()
        {
            List<IStateScraper> scrapers = new List<IStateScraper>();
            
            scrapers.Add(new GA_Scraper());
            scrapers.Add(new MI_Scraper());

            return scrapers;
        }
    }
}
