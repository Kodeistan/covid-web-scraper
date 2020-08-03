using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Cdc.Covid.WebScraper.UI
{
    public sealed class ReportViewModel : ObservableObject
    {
        private readonly ReportGenerator _generator = new ReportGenerator();
        private StateReport _selectedReport;

        public StateReport SelectedReport
        {
            get => _selectedReport;
            set
            {
                _selectedReport = value;
                RaisePropertyChanged(nameof(SelectedReport));
            }
        }

        public ObservableCollection<StateReport> Reports { get; private set; } = new ObservableCollection<StateReport>();

        public ICommand GenerateReportCommand { get { return new RelayCommand(GenerateReportCommandExecute, CanExecuteGenerateReportCommand); } }
        private bool CanExecuteGenerateReportCommand() => true;
        private void GenerateReportCommandExecute()
        {
            List<StateReport> reports = _generator.Generate();
            foreach (var report in reports)
            {
                Reports.Add(report);
            }
        }
    }
}
