using POS3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS3
{
    public partial class Invoice : Form, CUDUI<Invoice>, CUDUI<InvoiceItem>, RefereshUI
    {
        
        #region UI domain object
            Invoice invoice;
            InvoiceItem invoiceItem;
        #endregion

        #region services
            private BasisService<Invoice> invoiceService;
            private BasisService<InvoiceItem> invoiceItemService;
            private BasisService<InvoiceItem> suppliersService;
            private BasisService<InvoiceItem> productService;
        #endregion

        #region bindingSources
            private BindingSource bind;
            private BindingSource bindList;
        #endregion

        public void customInitialize()
        {
            #region service Intiation
                invoiceService = new InvoiService();
                invoiceItemService = new InvoiceItemService();
                suppliersService = new SuppliersService();
                productService = new ProductSerivce();
            #endregion

            #region bind UI
                invoiceBind = new BindingSource();
                invoice = invoiceService.getEmpty();
                invoiceBind.DataSource = invoice;

                
                vId.DataBindings.Add("Text", invoiceBind, "Id");
                vType.DataBindings.Add("Text", invoiceBind, "type");
                vCreationDate.DataBindings.Add("Value", invoiceBind, "creationDate");

                vSupplierId.DataBindings.Add("Text", invoiceBind, "supplier.Id");
                vSupplierName.DataBindings.Add("Text", invoiceBind, "supplier.Name");
                vTotalSellPrice.DataBindings.Add("Text", invoiceItemBind, "TotalSellPrice");


                invoiceItemBind = new BindingSource();
                invoiceItem = invoiceItemService.getEmpty();
               invoiceItemBind.DataSource = invoiceItem;

                vProductId.DataBindings.Add("Text", invoiceItemBind, "product.Id");
                vProductBarcode.DataBindings.Add("Text", invoiceItemBind, "product.Barcode");
                vProductName.DataBindings.Add("Text", invoiceItemBind, "product.Name");

                vUnits.DataBindings.Add("Text", invoiceItemBind, "Units");
                vTotalSellPrice.DataBindings.Add("Text", invoiceItemBind, "TotalSellPrice");
                vMeasureUnit.DataBindings.Add("SelectedValue", invoiceItemBind, "MeasureUnit");               
            

                listBind = new BindingSource();
                vList.AutoGenerateColumns = false;
                listBind.DataSource = list;
                vList.DataSource = listBind;

            #endregion

          
        }

        #region Invoice operatinos
            public void create(Invoice entity)
        {            
            invoiceService.add(entity);

        }       
        #endregion
        
        #region refresh
        public void refresh(bool mode)
        {
            if (mode)
            {
                invoiceBind.DataSource = invoice;
                invoiceItemBind.DataSource = invoiceItem;
                listBind.DataSource = list;
                vList.DataSource = listBind;


            }
            invoiceBind.ResetBindings(mode);
            invoiceItemBind.ResetBindings(mode);
            vList.ResetBindings(mode);

        }

        public void getNew()
        {
            this.invoice = invoiceService.getEmpty();
            this.invoiceItem = invoiceItemService.getEmpty();
            refresh(true);
        }
        #endregion

        #region Invoice itmes operatinos
        public void create(InvoiceItem entity)
        {
            InvoiceItem newEntity = Util.Util.Clone<InvoiceItem>((InvoiceItem)invoiceItem);
            InvoiceItemService.add(newEntity);
            list.Add(newEntity);
            refresh(false);
        }
        public void update(InvoiceItem entity)
        {
            invoiceItemservice.update(entity);


            list.ForEach(delegate (InvoiceItem obj)
            {
                if (obj.Id.Equals(entity.Id))
                {
                    obj.Name = entity.Name;

                }

            });

            //find and update
            refresh(false);

        }

        

        public void delete(InvoiceItem entity)
        {
            InvoiceItemService.delete(entity);

            //delete from list
            list.Remove(entity);
            getNewItem();
            refresh(false);
        }

        private void getNewItem()
        {
            this.invoiceItem = invoiceItemService.getEmpty();
            refresh(true);
        }
        #endregion
        public Invoice()
        {
            InitializeComponent();
            customInitialize();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.create(this.invoiceItem);
        }

        private void vUnitsByCarton_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void vList_SelectionChanged(object sender, EventArgs e)
        {
            if (vList.SelectedRows.Count > 0)
            {
                Product product = productService.findOne(vList.SelectedRows[0].Cells["cProductId"].Value.ToString());

                this.invoiceItem = new InvoiceItem { Id = vList.SelectedRows[0].Cells["cId"].Value.ToString(), Product = product, units= vList.SelectedRows[0].Cells["cUnits"].Value.ToString()
                    , measureUnit= vList.SelectedRows[0].Cells["cMeasureUnit"].Value.ToString(), sellPrice= vList.SelectedRows[0].Cells["cMeasureUnit"].Value.ToString()
                };
                
                this.refresh(true);


            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.update(this.invoiceItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.delete(this.invoiceItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.getNewItem();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.create(this.invoice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.getNew();
        }
        
    }
}
