using System;
using System.Windows;
using AccountingConsumables.Views;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;




namespace AccountingConsumables
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {


            InitializeComponent();


        }
        public string connectionString { get; set; } = ConfigurationManager.ConnectionStrings["AccountingConsumables"].ConnectionString;


        EditWindow edit;
        SqlDataAdapter adapter;
        DataTable table;
        SqlConnection connection = null;
        SqlCommand cmd;
     
        //Выполнение действий при загрузке программы
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            edit = new EditWindow();
            try
            {
                table = new DataTable();
                try
                {
              
                    string sql = edit.selectTypeMaterial;
                    connection = new SqlConnection(connectionString);
                    SqlCommand command = new SqlCommand(sql, connection);
                    adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(table);
                    dataGrid.ItemsSource = table.DefaultView;
                    dataGrid.Columns[0].Visibility = Visibility.Hidden;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message );
     
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }         
                ////Clock
                //var timer = new System.Windows.Threading.DispatcherTimer();
                //timer.Interval = new TimeSpan(0, 0, 1);
                //timer.IsEnabled = true;
                //timer.Tick += (o, t) => { lableTime.Content = DateTime.Now.ToLongTimeString(); };
                //timer.Start();   
            }
            catch (Exception)
            {
                throw;
            }
        }
      
        //Принудительное завершение работы программы
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Настройки программы
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
           

            if (SettingsGrid.Visibility == Visibility.Collapsed)
            {
                SettingsGrid.Visibility = Visibility.Visible;

            }
            else if (SettingsGrid.Visibility == Visibility.Visible)
            {
                SettingsGrid.Visibility = Visibility.Collapsed;

            }


        }

        //Генератор отчетов
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowReportViewer rv = new WindowReportViewer();
            rv.Show();
        }

        //Таблицы
        private void TypeMaterial_Click(object sender, RoutedEventArgs e)
        {
       
            string sql = edit.selectTypeMaterial;
            table = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void Eqepment_Click(object sender, RoutedEventArgs e)
        {
           
            string sql = "Select * from EquipmentView";
            table = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }
        private void Providers_Click(object sender, RoutedEventArgs e)
        {
           
            string sql = edit.selectProviders;
            table = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void Category_Click(object sender, RoutedEventArgs e)
        {
            string sql = edit.selectCategory;
            table = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            string sql = "Select * from MaterialsView";
            table = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void Departament_Click(object sender, RoutedEventArgs e)
        {
            string sql = edit.selectDepartament;
            table = new DataTable();
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void Expenses_Click(object sender, RoutedEventArgs e)
        {
            string sql = " Select * from ExpensesView ";
            table = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            string sql = " Select * from OrdersView";
            table = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                dataGrid.ItemsSource = table.DefaultView;
                dataGrid.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        //Кнопка открывающая окно "Редактирование"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditWindow edit = new EditWindow();
            edit.Show();
        }

        //О программе
        private void AboutWindowClick(object sender, RoutedEventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.ShowDialog();
        }

        //Выход из программы
        private void ExitFromApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Справка
        private void ViewHelp(object sender, RoutedEventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            var uri = new Uri(System.IO.Path.Combine(curDir, "help/index.html"));
            System.Diagnostics.Process.Start(uri.ToString());
        }


  
        public DataTable getDataFill(string adress)
        {
            DataTable dt = new DataTable();
            connection = new SqlConnection(connectionString);
            try
            {
                if(connection.State.ToString() == "Closed")
                {
                    connection.Open();
                }
                string sql = string.Empty;

                //if( sql == "")
                //{
                    sql = "Select * from " + adress;
                //}
                //else
                //{
                //    sql = "Select * from ExpensesView where [Наименование продукции/Модель] Like '" + adress + "%'";
                //}
               
                cmd = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error" + e.Message);
                return dt;
            }
        }

    }
}


