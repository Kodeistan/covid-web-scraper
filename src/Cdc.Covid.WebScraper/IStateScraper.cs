using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cdc.Covid.WebScraper
{
    public interface IStateScraper
    {
        Task<StateReport> ExecuteScrapeAsync();
    }
}
