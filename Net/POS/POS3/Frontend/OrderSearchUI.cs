using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS3.Domain;
using POS3.Services;
namespace POS3
{
    public partial class OrderSearch : Form
    {
        private List<Order> OrderList;
        private BindingSource OrdersSource;
        private OrderService OrderService;
        public OrderSearch()
        {
            InitializeComponent();
            CustomeInitiation();
        }

        private void CustomeInitiation()
        {
            OrderService = new OrderService();
            OrderList = OrderService.findAll();

            //Binding Order list
            OrdersSource = new BindingSource();
            OrdersSource.DataSource = this.OrderList;


            dgOrderSearch.AutoGenerateColumns = false;
            dgOrderSearch.DataSource = OrderList;
            this.Number.DataPropertyName = "Number";
            this.Total.DataPropertyName = "Total";
            this.CustomerName.DataPropertyName = "Customer.Name";
            this.DelieveryName.DataPropertyName = "Delievery.Name";
     

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbOrderNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgOrderSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Sales Sales = (Sales)this.Tag;
            Console.WriteLine(this.OrderList[e.RowIndex]);
            Sales.setFormOrder(this.OrderList[e.RowIndex]);
     
            Close();
        }
    }
}
