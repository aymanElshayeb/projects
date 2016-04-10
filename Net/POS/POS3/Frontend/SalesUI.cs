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
    public partial class Sales : Form
    {
        private BindingSource source;
        private BindingSource orderItemSource;
        private Order Order;
        private OrderService OrderService;
        private CustomerService CustomerService;

        public Sales()
        {
            InitializeComponent();
            CustomInitialize();
            
        }

        public void setFormOrder(Object inputOrder)
        {
            this.Order = (Order)inputOrder;
            source.DataSource = this.Order;
            orderItemSource.DataSource = this.Order.OrderItemList;
            orderItemSource.ResetBindings(false);
            source.ResetBindings(false);
        }
        private void CustomInitialize()
        {

            source = new BindingSource();
            //orderItemVG.AutoGenerateColumns = false;
            OrderService = new OrderService();
            CustomerService = new CustomerService();
            this.Order = OrderService.getEmpty();
            source.DataSource = this.Order;

            //Binding OrderItem
            orderItemSource = new BindingSource();
            orderItemSource.DataSource = this.Order.OrderItemList;
            vdOrderItem.AutoGenerateColumns = false;
            vdOrderItem.DataSource = orderItemSource;
            this.quantity.DataPropertyName= "quantity";
            this.ProductName.DataPropertyName= "Name";
            this.UnitPrice.DataPropertyName= "UnitPrice";
            this.TotalPrice.DataPropertyName= "TotalPrice";

            //Binding Order
            
            
            lbOrderNumber.DataBindings.Add("Text", source, "Number");
            
            lbOrderTotal.DataBindings.Add("Text", source, "Total");
            rtOrderPaid.DataBindings.Add("Text", source, "Paid");
            rtOrderRemain.DataBindings.Add("Text", source, "Remaining");

            //Binding Customer
            lbCustomerCode.DataBindings.Add("Text", source, "Customer.Code");
            lbCustomerName.DataBindings.Add("Text", source, "Customer.Name");
            lbCustomerAddress.DataBindings.Add("Text", source, "Customer.Address");
            lbCustomerTelephone.DataBindings.Add("Text", source, "Customer.Telephone");
            

            //Bind Delievery
            //cbDelievery.DataBindings.Add("ValueMember", this.Order.Delievery.Id, "");



        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localOrderDBDataSet.Delievery' table. You can move, or remove it, as needed.
            this.delieveryTableAdapter.Fill(this.localOrderDBDataSet.Delievery);

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                addRow(t.Text);
                Console.WriteLine("The value is "+ t.Text);
            }
                
        }

        private void addRow(string code)
        {
          
                OrderItem temp= OrderService.getOrderItem(code) ;

                orderItemSource.Add(temp);
            orderItemSource.ResetBindings(false);
            source.ResetBindings(false);



        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.OrderService.add(this.Order);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CustomerService.add(this.Order.Customer);
        }

        private void rtOrderPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderSearch orderSearch = new OrderSearch();
            orderSearch.Tag = this;
            orderSearch.ShowDialog(this);
            /*
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
