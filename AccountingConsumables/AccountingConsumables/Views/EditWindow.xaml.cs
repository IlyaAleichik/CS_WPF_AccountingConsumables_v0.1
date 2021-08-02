using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;


namespace AccountingConsumables.Views
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        MainWindow main = new MainWindow();
        SqlDataAdapter adapter;
        DataTable table;
        SqlConnection connection = null;
        SqlCommand command;

        public string selectTypeMaterial = "SELECT ID_TypeMaterial,NameTypeMaterial as [Наименования типов] FROM TypeMaterial";
        public string selectProviders = "SELECT ID_Providers,NameOrganization as Организация,Phone as Телефон,AddresProviders as Адрес FROM Providers";
        public string selectDepartament = "SELECT ID_Departament,NameDep as [Наименования подразделений] FROM Departament";
        public string selectCategory = "SELECT ID_Category,NameCategory as [Наименования категорий] FROM Category";
        private string CatBoxSelected { get; set; }
        private string selTable { get; set; }

        private void SetVisible()
        {
            TypeMaterialGrid.Visibility = Visibility.Hidden;
            ProvidersGrid.Visibility = Visibility.Hidden;
            MaterialsGrid.Visibility = Visibility.Hidden;
            OrdersGrid.Visibility = Visibility.Hidden;
            DepartamentGrid.Visibility = Visibility.Hidden;
            CategoryGrid.Visibility = Visibility.Hidden;
            EquipmentGrid.Visibility = Visibility.Hidden;
            ExpensesGrid.Visibility = Visibility.Hidden;

        }
        private void fillTableAndSav(string sql, UIElement nameFrom)
        {




            table = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(main.connectionString);
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
        private void fillTableAndDel(string sql, UIElement nameFrom)
        {




            table = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(main.connectionString);
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
        private void fillTable(string sql, UIElement nameFrom)
        {


            nameFrom.Visibility = Visibility.Visible;


            table = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(main.connectionString);
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
        private void fillComboboxEq()
        {
            SqlConnection connection = null;
            try
            {





                string sql = "SELECT  * FROM Equipment";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                boxEquip.ItemsSource = table.DefaultView;
                boxEquip.DisplayMemberPath = "Model";
                boxEquip.SelectedValuePath = "ID_Equipment";
                command.Dispose();
                connection.Close();


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
        private void fillComboboxDep()
        {
            SqlConnection connection = null;
            try
            {

                string sql = "SELECT  * FROM Departament";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                boxDep.ItemsSource = table.DefaultView;
                boxDep.DisplayMemberPath = "NameDep";
                boxDep.SelectedValuePath = "ID_Departament";
                command.Dispose();
                connection.Close();


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
        private void fillComboboxProv()
        {
            SqlConnection connection = null;
            try
            {





                string sql = "SELECT  * FROM Providers";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                boxProviders.ItemsSource = table.DefaultView;
                boxProviders.DisplayMemberPath = "NameOrganization";
                boxProviders.SelectedValuePath = "ID_Providers";
                command.Dispose();
                connection.Close();


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
        private void fillComboboxMat2()
        {
            SqlConnection connection = null;
            try
            {





                string sql = "SELECT  * FROM Materials";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);

                boxMat.ItemsSource = table.DefaultView;
                boxMat.DisplayMemberPath = "NameMaterials";
                boxMat.SelectedValuePath = "ID_Materials";


                command.Dispose();
                connection.Close();


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
        private void fillComboboxMat()
        {
            SqlConnection connection = null;
            try
            {





                string sql = "SELECT  * FROM Materials";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                boxMaterials.ItemsSource = table.DefaultView;
                boxMaterials.DisplayMemberPath = "NameMaterials";
                boxMaterials.SelectedValuePath = "ID_Materials";



                command.Dispose();
                connection.Close();


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
        private void fillComboboxType()
        {
            SqlConnection connection = null;
            try
            {





                string sql = "SELECT  * FROM TypeMaterial";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                txtFKIDTypeMaterial.ItemsSource = table.DefaultView;
                txtFKIDTypeMaterial.DisplayMemberPath = "NameTypeMaterial";
                txtFKIDTypeMaterial.SelectedValuePath = "ID_TypeMaterial";
                command.Dispose();
                connection.Close();


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
        private void fillComboboxCategory()
        {
            SqlConnection connection = null;
            try
            {





                string sql = "SELECT  * FROM Category";
                DataTable table = new DataTable();

                connection = new SqlConnection(main.connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                txtCategory.ItemsSource = table.DefaultView;
                txtCategory.DisplayMemberPath = "NameCategory";
                txtCategory.SelectedValuePath = "ID_Category";
                command.Dispose();
                connection.Close();


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

        public EditWindow()
        {
            InitializeComponent();  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


       
      

        }
        private void CatBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            CatBoxSelected = selectedItem.Content.ToString();
            switch (CatBoxSelected)
            {

                case "Подразделения":
                    selID.Text = "";
                    SetVisible();
                    fillTable(selectDepartament, DepartamentGrid); //Departament

                    break;

                case "Категории":
                    selID.Text = "";
                    SetVisible();
                    fillTable(selectCategory, CategoryGrid); //Category

                    break;

                case "Типы материалов":
                    selID.Text = "";
                    SetVisible();
                    fillTable(selectTypeMaterial, TypeMaterialGrid); //typeMaterial
                 
                    break;
                case "Поставщики":
                    selID.Text = "";
                    SetVisible();
                    fillTable(selectProviders, ProvidersGrid);//Providers
                 

                    break;
                case "Материалы":
                    selID.Text = "";
                    fillComboboxType();
                    SetVisible();
                    fillTable("SELECT * FROM MaterialsView", MaterialsGrid); //Materials

                
                    break;
                case "Заказы":
                    selID.Text = "";
                    fillComboboxMat();
                    fillComboboxProv();
                    SetVisible();
                    fillTable("SELECT * FROM OrdersView", OrdersGrid); // Orders
                  
                    break;
       
                case "Оборудование":
                    selID.Text = "";
                    fillComboboxCategory();
                    SetVisible();
                    fillTable("SELECT * FROM EquipmentView", EquipmentGrid); //Equipment
                  
                    break;
                case "Расходы":
                    selID.Text = "";
                    fillComboboxMat2();
                    fillComboboxEq();
                    fillComboboxDep();
                    SetVisible();
                    fillTable("SELECT * FROM ExpensesView", ExpensesGrid); //Expenses
                  
                    break;
            }
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            switch (CatBoxSelected)
            {

                case "Подразделения":
                    //Departament             
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Departament"].ToString();
                            txtNameDep.Text = dr["Наименования подразделений"].ToString();

                        }
                        catch { }
                    }
                    break;

                case "Категории":
                    //Category 
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Category"].ToString();
                            txtNameCategory.Text = dr["Наименования категорий"].ToString();



                        }
                        catch { }
                    }
                    break;

                case "Типы материалов":
                    //TypeMaterial      
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text =  dr["ID_TypeMaterial"].ToString();
                            txtNameTypeMat.Text = dr["Наименования типов"].ToString();


                    
                        }
                        catch { }
                    }
                    break;

                case "Поставщики":
                    //Providers
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Providers"].ToString();
                            txtNameOrg.Text = dr["Организация"].ToString();
                            txtPhone.Text = dr["Телефон"].ToString();
                            txtAdressProviders.Text = dr["Адрес"].ToString();

                        }
                        catch { }
                    }
                    break;

                case "Материалы":
                    //Materials
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Materials"].ToString();
                            txtNameMaterials.Text = dr["Наименование материала"].ToString();
                            txtCountMaterials.Text = dr["Кол-во"].ToString();
                            txtFKIDTypeMaterial.Text = dr["Тип"].ToString();
                            dateDateReceipt.SelectedDate = DateTime.Parse(dr["Дата прибытия"].ToString());
                            dateLife.SelectedDate = DateTime.Parse(dr["Срок службы"].ToString());
                          


                        }
                        catch { }
                    }
                    break;

                case "Заказы":
                    // Orders
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Orders"].ToString();
                            txtDateOrder.SelectedDate = DateTime.Parse(dr["Дата заказа"].ToString());
                            txtCounOrdertMaterials.Text = dr["Кол-во"].ToString();


                       
                        }
                        catch { }
                    }
                    break;

 

                case "Оборудование":
                    //Equipmnet 
                    ///*fillComboBox*/();
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Equipment"].ToString();
                            txtModel.Text = dr["Модель"].ToString();
                            txtCountEquipment.Text = dr["Кол-во"].ToString();
                            txtLife.SelectedDate = DateTime.Parse(dr["Срок службы"].ToString());
                            
                         


                        }
                        catch { }
                    }
                    break;

                case "Расходы":
                    //Expenses
                    if (dr != null)
                    {
                        try
                        {
                            selID.Text = dr["ID_Expenses"].ToString();
                            txtInvolved.Text = dr["Involved"].ToString();
                            txtDateExpensees.SelectedDate = DateTime.Parse(dr["DateExpensees"].ToString());
                            boxEquip.SelectedValue = dr["Модель"].ToString();

                         
                        }
                        catch { }
                    }
                    break;
            }

        }
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            string query;
            table = new DataTable();
            switch (CatBoxSelected)
            {


                case "Типы материалов":

                    //DataRowView dr = dg.SelectedItem as DataRowView;
                    //TypeMaterial      

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        query = "INSERT INTO TypeMaterial(NameTypeMaterial) Values(@NameTypeMaterial)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@NameTypeMaterial", txtNameTypeMat.Text);
                        command.ExecuteNonQuery();
                        fillTable(selectTypeMaterial, TypeMaterialGrid);
                        connection.Close();

                        
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

                    break;

                case "Поставщики":
                    //Providers
                
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        query = "INSERT INTO Providers(NameOrganization,Phone,AddresProviders) Values(@NameOrganization,@Phone,@AddresProviders)";       
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@NameOrganization", txtNameOrg.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@AddresProviders", txtAdressProviders.Text);
                        command.ExecuteNonQuery();
                        fillTable(selectProviders, ProvidersGrid);
                        connection.Close();
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
                    break;

                case "Материалы":
                    //Materials

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                         query = "INSERT INTO Materials(NameMaterials,CountMaterials,DateReceipt,Life,ID_TypeMaterial) Values(@NameMaterials,@CountMaterials,@DateReceipt,@Life,@ID_TypeMaterial)";
                        command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@NameMaterials", txtNameMaterials.Text);
                        command.Parameters.AddWithValue("@CountMaterials", txtCountMaterials.Text);
                        command.Parameters.AddWithValue("@DateReceipt", dateDateReceipt.Text);
                        command.Parameters.AddWithValue("@Life", dateLife.Text);
                        command.Parameters.AddWithValue("@ID_TypeMaterial", txtFKIDTypeMaterial.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTable("SELECT * FROM MaterialsView", MaterialsGrid);
                        connection.Close();
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
                    break;

                case "Заказы":
                    // Orders

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        query = "INSERT INTO Orders(DateOrder,CountOrderMat,ID_Materials,ID_Providers) Values(@DateOrder,@CountOrderMat,@ID_Materials,@ID_Providers)";
                        command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@DateOrder", txtDateOrder.Text);
                        command.Parameters.AddWithValue("@CountOrderMat", txtCounOrdertMaterials.Text);
                        command.Parameters.AddWithValue("@ID_Materials", boxMaterials.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@ID_Providers", boxProviders.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTable("SELECT * FROM OrdersView", OrdersGrid);
                        connection.Close();
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
                    break;

                case "Подразделения":
                    //Departament             

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                         query = "INSERT INTO Departament(NameDep) Values(@NameDep)";
                         command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@NameDep", txtNameDep.Text);
                        command.ExecuteNonQuery();
                        fillTable(selectDepartament, DepartamentGrid);
                        connection.Close();
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
                    break;

                case "Категории":
                    //Category 
                    
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        query = "INSERT INTO Category(NameCategory) Values(@NameCategory)";
                        command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@NameCategory", txtNameCategory.Text);
              
                        command.ExecuteNonQuery();
                        fillTable(selectCategory, CategoryGrid);
                        connection.Close();
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
                    break;

                case "Оборудование":
                    //Equipment 

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                         query = "INSERT INTO Equipment(Model,CountEquipment,Life,ID_Category) Values(@Model,@CountEquipment,@Life,@ID_Category)";
                        command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@Model", txtModel.Text);
                        command.Parameters.AddWithValue("@CountEquipment", txtCountEquipment.Text);
                        command.Parameters.AddWithValue("@Life", txtLife.Text);
                        command.Parameters.AddWithValue("@ID_Category", txtCategory.SelectedValue.ToString());

                        command.ExecuteNonQuery();
                        fillTable("SELECT * FROM EquipmentView", EquipmentGrid);
                        connection.Close();
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
                    break;

                case "Расходы":
                    //Expenses

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                    connection.Open();
                    query = "insert into Expenses(DateExpensees,Involved,ID_Equipment,ID_Materials,ID_Departament) values(@DateExpensees,@Involved,@ID_Equipment,@ID_Materials,@ID_Departament)";

                      
                        command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@DateExpensees", txtDateExpensees.Text);
                        command.Parameters.AddWithValue("@Involved", txtInvolved.Text);
                        command.Parameters.AddWithValue("@ID_Equipment", boxEquip.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@ID_Materials", boxMat.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@ID_Departament", boxDep.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTable("SELECT * FROM ExpensesView", ExpensesGrid);
                        connection.Close();
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
                    break;
            }



        }
        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {

            switch (CatBoxSelected)
            {

                case "Типы материалов":
                    //DataRowView dr = dg.SelectedItem as DataRowView;
                    //TypeMaterial      

                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from TypeMaterial where ID_TypeMaterial = @ID_TypeMaterial";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@ID_TypeMaterial", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel(selectTypeMaterial, TypeMaterialGrid);
                        connection.Close();
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

                    break;

                case "Поставщики":
                    //Providers
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Providers where ID_Providers = @ID_Providers";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@ID_Providers", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel(selectProviders, ProvidersGrid);
                        connection.Close();
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
                    break;

                case "Материалы":
                    //Materials
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Materials where ID_Materials =  @ID_Materials";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Materials", selID.Text);
                        command.ExecuteNonQuery(); 
                        fillTableAndDel("SELECT * FROM MaterialsView", MaterialsGrid);
                        connection.Close();
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
                    break;

                case "Заказы":
                    // Orders
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Orders where ID_Orders = @ID_Orders";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Orders", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel("SELECT * FROM OrdersView", OrdersGrid);
                        connection.Close();
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
                    break;

                case "Подразделения":
                    //Departament             
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Departament where ID_Departament = @ID_Departament";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Departament", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel(selectDepartament, TypeMaterialGrid);
                        connection.Close();
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
                    break;

                case "Категории":
                    //Category 
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Category where ID_Category = @ID_Category";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Category", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel(selectCategory, TypeMaterialGrid);
                        connection.Close();
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
                    break;

                case "Оборудование":
                    //Equipmnet 
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Equipment where ID_Equipment = @ID_Equipment ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Equipment", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel("SELECT * FROM EquipmentView", EquipmentGrid);
                        connection.Close();
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
                    break;

                case "Расходы":
                    //Expenses
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "delete from Expenses where ID_Expenses = @ID_Expenses";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Expenses", selID.Text);
                        command.ExecuteNonQuery();
                        fillTableAndDel("SELECT * FROM ExpensesView", ExpensesGrid);
                        connection.Close();
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
                    break;
            }

        }   
        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = null;

            switch (CatBoxSelected)
            {
               
                case "Типы материалов":
                    //DataRowView dr = dg.SelectedItem as DataRowView;
                    //TypeMaterial      
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();
                        string query = "update TypeMaterial set  NameTypeMaterial = @NameType where ID_TypeMaterial =  @ID_TypeMaterial";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@ID_TypeMaterial", selID.Text);
                        command.Parameters.AddWithValue("@NameType",txtNameTypeMat.Text);
                        command.ExecuteNonQuery();
                        fillTable(selectTypeMaterial, TypeMaterialGrid);
                        connection.Close();
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

                    break;

                case "Поставщики":
                    //Providers
                    
                                 
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();          
                        string query = "update Providers set NameOrganization = @NameOrganization, Phone = @Phone, AddresProviders = @AddresProviders where ID_Providers = @ID_Providers ";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Providers", selID.Text);
                        command.Parameters.AddWithValue("@NameOrganization", txtNameOrg.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@AddresProviders", txtAdressProviders.Text);
                        command.ExecuteNonQuery();
                        fillTableAndSav(selectProviders, ProvidersGrid);
                        connection.Close();
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

                    break;

                case "Материалы":
                    //Materials
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        string query = "update Materials set NameMaterials = @NameMaterials, CountMaterials = @CountMaterials, DateReceipt = @DateReceipt, Life = @Life, ID_TypeMaterial = @ID_TypeMaterial where ID_Materials = @ID_Materials";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Materials", selID.Text);
                        command.Parameters.AddWithValue("@NameMaterials", txtNameMaterials.Text);
                        command.Parameters.AddWithValue("@CountMaterials", txtCountMaterials.Text);
                        command.Parameters.AddWithValue("@DateReceipt", dateDateReceipt.Text);
                        command.Parameters.AddWithValue("@Life", dateLife.Text);
                        command.Parameters.AddWithValue("@ID_TypeMaterial", txtFKIDTypeMaterial.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTableAndSav("SELECT * FROM MaterialsView", MaterialsGrid);
                
                        connection.Close();
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
                    break;

                case "Заказы":
                    // Orders
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        string query = "update Orders set DateOrder = @DateOrder , CountOrderMat = @CountOrderMat, ID_Materials =@ID_Materials, ID_Providers = @ID_Providers  where ID_Orders = @ID_Orders";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Orders", selID.Text);
                        command.Parameters.AddWithValue("@DateOrder", txtDateOrder.Text);
                        command.Parameters.AddWithValue("@CountOrderMat", txtCounOrdertMaterials.Text);
                        command.Parameters.AddWithValue("@ID_Materials", boxMaterials.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@ID_Providers", boxProviders.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTableAndSav("SELECT * FROM OrdersView", OrdersGrid);
                        connection.Close();
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
                    break;

                case "Подразделения":
                    //Departament             
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        string query = " update Departament set NameDep = @NameDep where ID_Departament = @ID_Departament";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Departament", selID.Text);
                        command.Parameters.AddWithValue("@NameDep", txtNameDep.Text);
                        command.ExecuteNonQuery();
                        fillTableAndSav(selectDepartament, DepartamentGrid);
                        connection.Close();
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
                    break;

                case "Категории":
                    //Category 
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        string query = "  update Category set NameCategory = @NameCategory  where ID_Category = @ID_Category";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Category", selID.Text);
                        command.Parameters.AddWithValue("@NameCategory", txtNameCategory.Text);
                        command.ExecuteNonQuery();
                        fillTableAndSav(selectCategory, CategoryGrid);
                        connection.Close();
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
                    break;

                case "Оборудование":
                    //Equipmnet 
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        string query = " update Equipment set Model = @Model, CountEquipment = @CountEquipment, Life = @Life, ID_Category = @ID_Category where ID_Equipment = @ID_Equipment";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Equipment", selID.Text);
                        command.Parameters.AddWithValue("@Model", txtModel.Text);
                        command.Parameters.AddWithValue("@CountEquipment", txtCountEquipment.Text);
                        command.Parameters.AddWithValue("@Life", txtLife.Text);
                        command.Parameters.AddWithValue("@ID_Category", txtCategory.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTableAndSav("SELECT * FROM EquipmentView", EquipmentGrid);
                        connection.Close();
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
                    break;

                case "Расходы":
                    //Expenses
                    try
                    {
                        connection = new SqlConnection(main.connectionString);
                        connection.Open();

                        string query = "  update Expenses set DateExpensees = @DateExpensees, Involved = @Involved, ID_Equipment = @ID_Equipment, ID_Materials = @ID_Materials, ID_Departament= @ID_Departament where ID_Expenses = @ID_Expenses";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ID_Expenses", selID.Text);
                        command.Parameters.AddWithValue("@DateExpensees", txtDateExpensees.Text);
                        command.Parameters.AddWithValue("@Involved", txtInvolved.Text);
                        command.Parameters.AddWithValue("@ID_Equipment", boxEquip.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@ID_Materials", boxMat.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@ID_Departament", boxDep.SelectedValue.ToString());
                        command.ExecuteNonQuery();
                        fillTableAndSav("SELECT * FROM ExpensesView", ExpensesGrid);
                        connection.Close();
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
                    break;
            }
        }
    }
}
