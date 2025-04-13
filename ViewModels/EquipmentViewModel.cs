using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EquipmentMonitoringDashboard.Models;
using System.Windows.Threading;

namespace EquipmentMonitoringDashboard.ViewModels
{
    public class EquipmentViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Equipment> Equipment { get; set; }
        // ObservableCollection: A special list that notifies the UI when items are added/removed – perfect for live dashboards.
        // Equipments: Holds multiple Equipment objects and reflects any updates automatically in the UI when bound.
        
        private DispatcherTimer _timer; //performs a task on time interval

        public EquipmentViewModel() // Constructor
        {
            Equipment = new ObservableCollection<Equipment>
            {
                new Equipment { Name = "Machine A", Status = "Online", Temperature = 75, LastUpdated = DateTime.Now },
                new Equipment { Name = "Machine B", Status = "Offline", Temperature = 19, LastUpdated = DateTime.Now },
                new Equipment { Name = "Machine C", Status = "Maintenance", Temperature = 48.5, LastUpdated = DateTime.Now }
            };

            //Setup the timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(3); //set up the timer to "tick" every 3 seconds
            _timer.Tick += UpdateData; 
            _timer.Start();
        }

        /*private void UpdateData(object sender, EventArgs e)
        {
            var random = new Random();

            foreach (var eq in Equipment)
            {
                eq.Temperature = Math.Round(20 + random.NextDouble() * 80, 2); // Random temperature 20.00 - 100.00
                eq.Status = new[] {"Online", "Offline", "Maintainence"}[random.Next(3)]; //randomly picked from the list
                eq.LastUpdated = DateTime.Now; // keeps track of when it was last changed
            }
            
            onPropertyChanged(nameof(Equipment));

        }*/
        private void UpdateData(object sender, EventArgs e)
        {
            var random = new Random();

            foreach (var equipment in Equipment)
            {
                // Simulate temperature change
                equipment.Temperature += random.Next(-2, 3);

                // Simulate random status
                var statuses = new[] { "Running", "Idle", "Faulty" };
                equipment.Status = statuses[random.Next(statuses.Length)];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged; // It lets the UI react to property value changes
        protected void onPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));  
        }
    }
}
