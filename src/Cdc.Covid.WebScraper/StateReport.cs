using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Cdc.Covid.WebScraper
{
    [DebuggerDisplay("{State}")]
    public sealed class StateReport
    {
        public string StateAbbreviation { get; private set; } = string.Empty;
        public string State { get; private set; } = string.Empty;
        public List<CountyReport> CountyInfo { get; private set; } = new List<CountyReport>();
        public DateTime DateGenerated { get; private set; } = DateTime.Now;
        public int Confirmed { get; private set; } = -1;
        public int Deaths { get; private set; } = -1;
        public int Hospitalizations { get; private set; } = -1;

        public StateReport(string state, string abbreviation, List<CountyReport> reports)
        {
            State = state;
            StateAbbreviation = abbreviation;
            CountyInfo = reports;

            Confirmed = reports.Sum(r => r.Confirmed);
            Deaths = reports.Sum(r => r.Deaths);
            Hospitalizations = reports.Sum(r => r.Hospitalizations);

            if (Deaths < 0) Deaths = 0;
            if (Hospitalizations < 0) Hospitalizations = 0;
        }
    }
}
