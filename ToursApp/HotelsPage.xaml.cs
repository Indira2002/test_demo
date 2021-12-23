using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ToursApp
{
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
  
            combofilter.ItemsSource = HospitalEntities.GetContext().Doctors.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as DailyReception));
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var hospitalForRemoving = DGridHotels.SelectedItems.Cast<DailyReception>().ToList();
            if(MessageBox.Show($"Вы точно хотите удалить данные?", "Внимание.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HospitalEntities.GetContext().DailyReceptions.RemoveRange(hospitalForRemoving);
                    HospitalEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удалено.");
                    DGridHotels.ItemsSource = HospitalEntities.GetContext().DailyReceptions.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HospitalEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p=>p.Reload());
                DGridHotels.ItemsSource = HospitalEntities.GetContext().DailyReceptions.ToList();
            }
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var regs = HospitalEntities.GetContext().DailyReceptions.ToList();
            DGridHotels.ItemsSource = regs.Where(p => p.Doctor1.Equals(combofilter.SelectedItem));          
        }
        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            DGridHotels.ItemsSource = HospitalEntities.GetContext().DailyReceptions.ToList();
        }

        private void combofilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var regs = HospitalEntities.GetContext().DailyReceptions.ToList();
            DGridHotels.ItemsSource = regs.Where(p => p.Doctor1.Equals(combofilter.SelectedItem));
        }

        
    }
}
