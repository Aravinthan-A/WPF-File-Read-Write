using System.Collections;
using System.Windows;
using System.IO;
using System;

namespace String_Function
{
    /// <summary>
    /// Interaction logic for Addname.xaml
    /// </summary>
    public partial class Addname : Window
    {
        ArrayList oarray;


        public Addname()
        {
            InitializeComponent();
           
           


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (oarray == null)
            {
                oarray = new ArrayList();
            }
            oarray.Add(txtname.Text);
            int count = oarray.Capacity;
            cmbdata.ItemsSource = null;
            cmbdata.ItemsSource = oarray;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string val = "";
            int count = cmbdata.Items.Count;
            for (int i = 0; i < count; i++)
            {
               val+= cmbdata.Items[i].ToString()+"|";
            }
            File.WriteAllText("C:\\Users\\welcome\\Documents\\" + txtname.Text + ".txt",val);
        }

       
    }
}
