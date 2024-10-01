using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDoga
{
    public partial class Form1 : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        List<item> items = new List<item>();


        public Form1()
        {
            InitializeComponent();
            
            items = db.ReadAll();

            foreach (item item in items)
            {
                ProductsListB.Items.Add(item.name + "   " + item.price + "   " + item.quantity);
            }


            AddItemB.Click += (s, e) =>
            {
                if (NameTB.ToString().Length > 0 && PriceTB.ToString().Length > 0 && QuantityTB.ToString().Length > 0)
                {
                    item oneItem = new item();
                    oneItem.name = NameTB.Text;
                    oneItem.price = Convert.ToInt32(PriceTB.Text);
                    oneItem.quantity = Convert.ToInt32(QuantityTB.Text);
                    db.insertOneItem(oneItem);
                }
                else
                {
                    MessageBox.Show("Name, or Price, or Quantity missing");
                }
            };

            ReloadB.Click += (s, e) =>
            {
                items.Clear();
                items = db.ReadAll();
                ProductsListB.Items.Clear();
                foreach (item item in items)
                {
                    ProductsListB.Items.Add(item.name + "   " + item.price + "   " + item.quantity);
                }
            };

            DeleteItemB.Click += (s, e) =>
            {
                if (NameTB.ToString().Length > 0)
                {
                    foreach (item item in items)
                    {
                        if (item.name == NameTB.Text)
                        {
                            db.deleteOneitem(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Name missing");
                }
            };

        }
    }
}
