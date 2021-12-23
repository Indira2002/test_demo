using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private DailyReception _currentDailyReception = new DailyReception();
        public AddEditPage( DailyReception selectedDailyReception)
        {
            InitializeComponent();
            if(selectedDailyReception != null)
            {
                _currentDailyReception = selectedDailyReception;
            }
            DataContext = _currentDailyReception;
            combo1.ItemsSource = HospitalEntities.GetContext().Diagnos.ToList();
            combo2.ItemsSource = HospitalEntities.GetContext().Doctors.ToList();
            combo3.ItemsSource = HospitalEntities.GetContext().Patients.ToList();
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string errors = DailyReceptions.Check(_currentDailyReception);
           
            if (errors.Length > 0)
            {
                MessageBox.Show(errors);
                return;
            }
            if (_currentDailyReception.Id == 0)
                HospitalEntities.GetContext().DailyReceptions.Add(_currentDailyReception);
                try
                {
                     HospitalEntities.GetContext().SaveChanges();
                    MessageBox.Show("Сохранено.");
                    Manager.MainFrame.GoBack();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            
        }
    }
}
