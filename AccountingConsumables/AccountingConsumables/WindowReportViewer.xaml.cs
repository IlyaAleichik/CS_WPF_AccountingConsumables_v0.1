using Microsoft.Reporting.WinForms;

using System.Data;
using System.Drawing.Printing;
using System.Windows;
using System.Windows.Controls;

namespace AccountingConsumables
{
    /// <summary>
    /// Логика взаимодействия для WindowReportViewer.xaml
    /// </summary>
    public partial class WindowReportViewer : Window
    {

       private string selected { get; set; }
        public WindowReportViewer()
        {
            InitializeComponent();

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Right = 0;
            pg.Margins.Left = 0;
            System.Drawing.Printing.PaperSize size = new System.Drawing.Printing.PaperSize();
            size.RawKind = (int)PaperKind.B5;
            pg.PaperSize = size;
            //this.ReportViewer.SetPageSettings(pg);
            this.ReportViewer.RefreshReport();
            ReportViewer.Reset();

        }
        MainWindow main = new MainWindow();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
       

        }

   
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";
            DataTable dt;
            ReportDataSource dataSource;
            switch (selected)
            {


                case "Движение материалов за период на дату":

                    sql = "ExpensesViewReport";

                    ReportViewer.Reset();

                    dt = main.getDataFill(sql);
                    dataSource = new ReportDataSource("DataSet1", dt);
                    ReportViewer.LocalReport.DataSources.Add(dataSource);

                    ReportViewer.LocalReport.ReportEmbeddedResource = "AccountingConsumables.Report3.rdlc";
                    ReportViewer.RefreshReport();
                    break;

                case "Оборудование в наличии":

                    sql = "EquipmentViewReport";

                    ReportViewer.Reset();

                    dt = main.getDataFill(sql);
                    dataSource = new ReportDataSource("DataSet2", dt);
                    ReportViewer.LocalReport.DataSources.Add(dataSource);

                    ReportViewer.LocalReport.ReportEmbeddedResource = "AccountingConsumables.Report.rdlc";
                    ReportViewer.RefreshReport();
                    break;


                case "Сроки службы оборудования":

                    sql = "EquipmentViewReport";

                    ReportViewer.Reset();

                    dt = main.getDataFill(sql);
                    dataSource = new ReportDataSource("DataSet3", dt);
                    ReportViewer.LocalReport.DataSources.Add(dataSource);

                    ReportViewer.LocalReport.ReportEmbeddedResource = "AccountingConsumables.Report2.rdlc";
                    ReportViewer.RefreshReport();
                    break;

                case "Акт расхода материалов":

                
                  
                
                        sql = "ExpensesViewReport where Model like '"+ txtNameProd.Text + "%'";
                   

                    ReportViewer.Reset();

                    dt = main.getDataFill(sql);
                    dataSource = new ReportDataSource("DataSet1", dt);
                    ReportViewer.LocalReport.DataSources.Add(dataSource);

                    ReportViewer.LocalReport.ReportEmbeddedResource = "AccountingConsumables.Report1.rdlc";
                    ReportViewer.RefreshReport();
                    break;

              
            }

        }

        private void SelectReport_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
          selected = selectedItem.Content.ToString();
            if (selected == "Акт расхода материалов")
            {
                txtNameProd.Visibility = Visibility.Visible;
            }
            else { txtNameProd.Visibility = Visibility.Collapsed; }
         
        }

        private void TextBox_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            txtNameProd.Text = "";
        }
    }
}
