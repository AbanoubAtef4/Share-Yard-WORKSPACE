﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
namespace Center_Maneger.UesrControls
{
    /// <summary>
    /// Interaction logic for Prices_Settings.xaml
    /// </summary>
    public partial class Prices_Settings : UserControl
    {
        private DataRowView selectedRow; // store cuurent selected row if i wanted to delete

        public Prices_Settings()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data() // display classes data in grid
        {
            data_grid.ItemsSource = databaseLoader.LoadData("prices").DefaultView;
        }

        private void new_price_record(object sender, RoutedEventArgs e)
        {
            start_date_price_input.Clear();
            end_date_price_input.Clear();
            cost_price_input.Clear();
        }

        private void save_price_record(object sender, RoutedEventArgs e)
        {
            int startDate, endDate, durationCost;
            if (start_date_price_input.Text.Trim() == "" || end_date_price_input.Text.Trim() == "" || cost_price_input.Text.Trim() == "")  // make sure textboxes are not empty
            {
                MessageBox.Show("برجاء ادخال جميع الحقول ", " خطأ ", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            bool isStartNumber = int.TryParse(start_date_price_input.Text, out startDate); 
            bool isEndNumber = int.TryParse(end_date_price_input.Text, out endDate);
            bool isCostNumber = int.TryParse(cost_price_input.Text, out durationCost);

            if (isStartNumber && isEndNumber && isCostNumber && endDate > 0 && durationCost > 0)
            {
                Dictionary<string, object> data = new Dictionary<string, object>
                {
                    {"from_date", startDate},
                    {"to_date", endDate},
                    {"cost", durationCost}
                };
                try
                {
                    databaseLoader.InsertRecord("prices", data);
                    load_data();
                }
                catch
                {
                    MessageBox.Show("خطأ اثناء عملية الادخال", " خطأ ", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("برجاء ادخال ارقام صحيحة ", " خطأ ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void remove_price_record(object sender, RoutedEventArgs e)
        {
            if (selectedRow != null) // if a record is selected 
            {

                var result = MessageBox.Show("هل أنت متأكد من حذف هذا الصف؟", "تأكيد", MessageBoxButton.YesNo); // رسالة تأكيد
                if (result == MessageBoxResult.Yes) // if he chooses YES
                {
                    string from_date = Convert.ToString((selectedRow["from_date"]));
                    databaseLoader.DeleteRecord("prices", "from_date", from_date);
                    load_data();
                }
            }

            else
            {
                MessageBox.Show("برجاء اختيار الصف الذي تريد حذفه ", " خطأ ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void change_selected_record(object sender, SelectionChangedEventArgs e) // this event is called whenever you select a record (row) from the grid
        {
            selectedRow = data_grid.SelectedItem as DataRowView; // store the current selected row in the variable 

        }

        private void change_header_name(object sender, DataGridAutoGeneratingColumnEventArgs e) //Becuase the grid is dynamically generated in runtime (asynchronous) مقدرش أغير اسم العمود بالكود مباشرة لكن الفنكشن دي بتشتغل لما العمود يتم انشاءه وبعدها بقدر أغير الاسم 
        {
            if (e.PropertyName == "from_date")
            {
                e.Column.Header = "بداية الفترة";
            }
            else if (e.PropertyName == "to_date")
            {
                e.Column.Header = "نهاية الفترة";
            }
            else if (e.PropertyName == "cost")
            {
                e.Column.Header = "تكلفة الفترة";
            }
        }
    }
}
