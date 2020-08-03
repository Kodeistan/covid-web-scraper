using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Cdc.Covid.WebScraper
{
    [DebuggerDisplay("{Name} : {Confirmed} cases, {Deaths} deaths")]
    public sealed class CountyReport
    {
        public string Name { get; set; } = string.Empty;
        public int Confirmed { get; set; } = -1;
        public int Probable { get; set; } = -1;
        public int Deaths { get; set; } = -1;
        public int Hospitalizations { get; set; } = -1;
        public double CaseRate { get; set; } = -1.0;

        public CountyReport(string name, int confirmed, int probable, int deaths, int hospitalizations, double rate)
        {
            Name = name;
            Confirmed = confirmed;
            Probable = probable;
            Deaths = deaths;
            Hospitalizations = hospitalizations;
            CaseRate = rate;
        }
    }
}
