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
    public partial class ReceiptUI : Form, CUDUI<Receipt>, CUDUI<ReceiptItem>, RefereshUI
    {

        #region UI domain object
        Receipt receipt;
        ReceiptItem receiptItem;
        List<Receipt> list;

        #endregion

        #region services
        private BasisService<Receipt> receiptService;
        private BasisService<ReceiptItem> receiptItemService;
        private BasisService<ReceiptItem> suppliersService;
        private BasisService<ReceiptItem> productService;
        #endregion

        #region bindingSources
        private BindingSource receiptBind;
        private BindingSource receiptItemBind;
        private BindingSource listbind;
        #endregion

        public void customInitialize()
        {
            #region service Intiation
            receiptService = new ReceiptService();
            receiptItemService = new ReceiptItemService();
            suppliersService = new SuppliersService();   
            #endregion

            #region bind UI
            receiptBind = new BindingSource();
            receipt = receiptService.getEmpty();
            receiptBind.DataSource = receipt;


            vId.DataBindings.Add("Text", receiptBind, "Id");            
            vCreationDate.DataBindings.Add("Value", receiptBind, "creationDate");
            vSupplierId.DataBindings.Add("Text", receiptBind, "supplier.Id");
            vSupplierName.DataBindings.Add("Text", receiptBind, "supplier.Name");


            receiptItemBind = new BindingSource();
            receiptItem = receiptItemService.getEmpty();
            receiptItemBind.DataSource = receiptItem;

            vInvoiceId.DataBindings.Add("Text", receiptItemBind, "invoice.Id");
            vInvoiceCreationDate.DataBindings.Add("Text", receiptItemBind, "invoice.CreationDate");
            vInvoiceType.DataBindings.Add("Text", receiptItemBind, "invoice.Type");
            vInvoiceTotalSellPrice.DataBindings.Add("Text", receiptItemBind, "invoice.TotalSellPrice");
            vInvoiceRemain.DataBindings.Add("Text", receiptItemBind, "invoice.Remain");
            vIsDiscount.DataBindings.Add("Value", receiptItemBind, "IsDiscount");
            vRemainAfterDiscount.DataBindings.Add("Text", receiptItemBind, "RemainAfterDiscount");
            vPaid.DataBindings.Add("Text", receiptItemBind, "Paid");
            vDiscount.DataBindings.Add("Text", receiptItemBind, "Discount");



            listBind = new BindingSource();
            vList.AutoGenerateColumns = false;
            list = new List<Receipt>();
            listBind.DataSource = list;
            vList.DataSource = listBind;

            #endregion


        }

        #region Receipt operatinos
        public void create(Receipt entity)
        {
            receiptService.add(entity);

        }
        #endregion

        #region refresh
        public void refresh(bool mode)
        {
            if (mode)
            {
                receiptBind.DataSource = receipt;
                receiptItemBind.DataSource = receiptItem;
                listBind.DataSource = list;
                vList.DataSource = listBind;


            }
            receiptBind.ResetBindings(mode);
            receiptItemBind.ResetBindings(mode);
            listBind.ResetBindings(mode);

        }

        public void getNew()
        {
            this.receipt = receiptService.getEmpty();
            this.receiptItem = receiptItemService.getEmpty();
            refresh(true);
        }
        #endregion

        #region Receipt itmes operatinos
        public void create(ReceiptItem entity)
        {
            ReceiptItem newEntity = Util.Util.Clone<ReceiptItem>((ReceiptItem)receiptItem);
            ReceiptItemService.add(newEntity);
            list.Add(newEntity);
            refresh(false);
        }
        public void update(ReceiptItem entity)
        {
            receiptItemservice.update(entity);


            list.ForEach(delegate (ReceiptItem obj)
            {
                if (obj.Id.Equals(entity.Id))
                {
                    obj.Name = entity.Name;

                }

            });

            //find and update
            refresh(false);

        }



        public void delete(ReceiptItem entity)
        {
            ReceiptItemService.delete(entity);

            //delete from list
            list.Remove(entity);
            getNewItem();
            refresh(false);
        }

        private void getNewItem()
        {
            this.receiptItem = receiptItemService.getEmpty();
            refresh(true);
        }
        #endregion
        public ReceiptUI()
        {
            InitializeComponent();
            customInitialize();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.create(this.receiptItem);
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

                this.receiptItem = new ReceiptItem
                {
                    Id = vList.SelectedRows[0].Cells["cId"].Value.ToString(),
                    Product = product,
                    units = vList.SelectedRows[0].Cells["cUnits"].Value.ToString()
                    ,
                    measureUnit = vList.SelectedRows[0].Cells["cMeasureUnit"].Value.ToString(),
                    sellPrice = vList.SelectedRows[0].Cells["cMeasureUnit"].Value.ToString()
                };

                this.refresh(true);


            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.update(this.receiptItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.delete(this.receiptItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.getNewItem();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.create(this.receipt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.getNew();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
