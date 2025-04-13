# EquipmentMonitoringDashboard
This project is a real-time equipment monitoring dashboard built using WPF (Windows Presentation Foundation) and C#. It provides a visual representation of machine statuses, temperatures, and last update timestamps, offering an intuitive and interactive way to keep track of equipment in a factory or production environment.

Key Features:

1. Live Data Simulation: The dashboard automatically updates every few seconds, simulating changes in temperature and equipment status (e.g., "Running", "Idle", "Faulty").
2. Dynamic Data Binding: The application uses MVVM architecture, allowing easy management and updates of the data between the UI and underlying logic.
3. Color-Coded Temperature Status: With the help of a custom value converter, equipment row colors change based on temperature thresholds, making it easy to spot machines that are at risk of overheating.
4. Real-Time Updates: The DispatcherTimer ensures the data stays current by periodically refreshing the equipment status.
5. User-Friendly Interface: The WPF DataGrid dynamically adjusts to the data, making it simple for users to understand equipment statuses at a glance.
