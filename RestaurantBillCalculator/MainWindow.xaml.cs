using System;
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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RestaurantBillCalculator
{
    /// <summary>
    /// Members: Abdul Moeed Saqib, Victoria Romaniuk, Amirarsalan Yousefi Kordestani, Zeedan Ahmed
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Item> cart = new List<Item>();

        private decimal Total { get; set; }
        private decimal Tax { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void beverageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Items.beverages.Any(x => x.Name == (string)beverageComboBox.SelectedItem))
            {
                var price = Items.beverages.Find(x => x.Name == (string)beverageComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);
                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Items.beverages.Find(x => x.Name == (string)beverageComboBox.SelectedItem));

                    SalesTax(price);

                    beverageComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Items.beverages.Find(x => x.Name == (string)beverageComboBox.SelectedItem));
                  
                    SalesTax(price);

                    beverageComboBox.SelectedIndex = -1;
                }
            }
        }

        private void mainCourseComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Items.mainCourses.Any(x => x.Name == (string)mainCourseComboBox.SelectedItem))
            {
                var price = Items.mainCourses.Find(x => x.Name == (string)mainCourseComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);

                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Items.mainCourses.Find(x => x.Name == (string)mainCourseComboBox.SelectedItem));

                    SalesTax(price);

                    mainCourseComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Items.mainCourses.Find(x => x.Name == (string)mainCourseComboBox.SelectedItem));

                    SalesTax(price);

                    mainCourseComboBox.SelectedIndex = -1;
                }
            }
        }

        private void dessertComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Items.desserts.Any(x => x.Name == (string)dessertComboBox.SelectedItem))
            {
                var price = Items.desserts.Find(x => x.Name == (string)dessertComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);

                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Items.desserts.Find(x => x.Name == (string)dessertComboBox.SelectedItem));

                    SalesTax(price);

                    dessertComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Items.desserts.Find(x => x.Name == (string)dessertComboBox.SelectedItem));

                    SalesTax(price);

                    dessertComboBox.SelectedIndex = -1;
                }
            }
        }
        private void appetizerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Items.appetizer.Any(x => x.Name == (string)appetizerComboBox.SelectedItem))
            {
                var price = Items.appetizer.Find(x => x.Name == (string)appetizerComboBox.SelectedItem);
                var item = itemsDataGrid.Items.IndexOf(price);

                if (item >= 0)
                {
                    itemsDataGrid.Items.Remove(price);
                    price.Quantity++;
                    itemsDataGrid.Items.Add(Items.appetizer.Find(x => x.Name == (string)appetizerComboBox.SelectedItem));

                    SalesTax(price);

                    appetizerComboBox.SelectedIndex = -1;
                }
                else
                {
                    itemsDataGrid.Items.Add(Items.appetizer.Find(x => x.Name == (string)appetizerComboBox.SelectedItem));

                    SalesTax(price);

                    appetizerComboBox.SelectedIndex = -1;
                }
            }
        }

        private void centennialLogoButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.centennialcollege.ca/");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Items.beverages)
            {
                beverageComboBox.Items.Add(item.Name);
            }

            foreach (var item in Items.desserts)
            {
                dessertComboBox.Items.Add(item.Name);
            }

            foreach (var item in Items.mainCourses)
            {
                mainCourseComboBox.Items.Add(item.Name);
            }

            foreach (var item in Items.appetizer)
            {
                appetizerComboBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// This is method is calculates the item's sale tax
        /// </summary>
        /// <param name="price"></param>
        private void SalesTax(Item price)
        {
            decimal tax = 0.13M;
            var salesTax = price.Price * tax;
            salesTax = Math.Round(salesTax, 1);
            if (salesTax < 0.1M)
            {
                salesTax = 0.1M;
            }

            Tax += salesTax;
            taxBlock.Text = Tax.ToString("C2");

            CalculateTotal(price, salesTax);
        }

        /// <summary>
        /// This method calculates the tax and the price to get the total cost of the item
        /// </summary>
        /// <param name="price"></param>
        /// <param name="salesTax"></param>
        private void CalculateTotal(Item price, decimal salesTax)
        {
            var total = price.Price + salesTax;
            Total += total;
            totalTextBlock.Text = Total.ToString("C2");
        }

        /// <summary>
        /// This method removes all the quantities from the items once its finish or it got clear
        /// </summary>
        private static void RemoveQuantity()
        {
            foreach (var item in Items.beverages)
            {
                item.Quantity = 1;
            }

            foreach (var item in Items.mainCourses)
            {
                item.Quantity = 1;
            }

            foreach (var item in Items.desserts)
            {
                item.Quantity = 1;
            }

            foreach (var item in Items.appetizer)
            {
                item.Quantity = 1;
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            itemsDataGrid.Items.Clear();
            Total = 0.00M;
            Tax = 0.00M;
            taxBlock.Text = "$0.00";
            totalTextBlock.Text = "$0.00";

            RemoveQuantity();
        }


        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in itemsDataGrid.Items)
            {
                Item i = item as Item;
                cart.Add(i);
            }

            var doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            var pdf = PdfWriter.GetInstance(doc, new FileStream("order.pdf", FileMode.OpenOrCreate));
            doc.Open();

            iTextSharp.text.Font myFont = FontFactory.GetFont("Arial", 30, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font myFont1 = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD);

            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Your orders:", myFont);

            doc.Add(p);
            doc.Add(new iTextSharp.text.Paragraph(" "));
            doc.Add(new iTextSharp.text.Paragraph(" "));

            doc.Add(new iTextSharp.text.Paragraph($"Name                  Price            Quantitiy", myFont1));
            foreach (var item in cart)
            {
                doc.Add(new iTextSharp.text.Paragraph($"{item.Name}                        {item.Price:C}                                   {item.Quantity}"));
            }

            doc.Add(new iTextSharp.text.Paragraph(" "));
            doc.Add(new iTextSharp.text.Paragraph(" "));

            doc.Add(new iTextSharp.text.Paragraph($"The total of your order: {Total:C}", myFont1));
            doc.Close();

            System.Diagnostics.Process.Start("order.pdf");

            itemsDataGrid.Items.Clear();
            Total = 0.00M;
            Tax = 0.00M;
            taxBlock.Text = "$0.00";
            totalTextBlock.Text = "$0.00";

            RemoveQuantity();
        }
    }
}
