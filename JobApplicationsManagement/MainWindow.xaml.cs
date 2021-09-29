using System;
using System.Windows;
using System.Windows.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace JobApplicationsManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean state = false;
        private const String hiddenMessage = "HEHE, didn't expect this, did You?";

        private readonly JobapplicationsContext _context =
            new JobapplicationsContext();

        private CollectionViewSource employerViewSource;
        private CollectionViewSource applicationEventViewSource;

        public MainWindow()
        {
            InitializeComponent();
            employerViewSource =
                (CollectionViewSource)FindResource(nameof(employerViewSource));
            applicationEventViewSource =
                (CollectionViewSource)FindResource(nameof(applicationEventViewSource));
        }

        private void buttonClicked()
        {
            state = state ^ true;
            if (state)
            {
                this.hiddenLabel.Content = hiddenMessage;
            }
            else
            {
                this.hiddenLabel.Content = null;
            }
            
        }

        private void demoButton_Click(object sender, RoutedEventArgs e)
        {
            this.buttonClicked();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // this is for demo purposes only, to make it easier
            // to get up and running
            _context.Database.EnsureCreated();

            // load the entities into EF Core
            _context.Employers.Load();
            _context.ApplicationEvents.Load();

            // bind to the source
            employerViewSource.Source =
                _context.Employers.Local.ToObservableCollection();
            System.Windows.Data.CollectionViewSource applicationEventViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("applicationEventViewSource1")));
            // Load data by setting the CollectionViewSource.Source property:
            // applicationEventViewSource1.Source = [generic data source]
            System.Windows.Data.CollectionViewSource jobApplicationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("jobApplicationViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // jobApplicationViewSource.Source = [generic data source]
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // all changes are automatically tracked, including
            // deletes!
            _context.SaveChanges();

            // this forces the grid to refresh to latest values

            employersDataGrid.Items.Refresh();
            jobApplicationsDataGrid.Items.Refresh();
            applicationEventsDataGrid.Items.Refresh();

        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {

        }
    }
}
