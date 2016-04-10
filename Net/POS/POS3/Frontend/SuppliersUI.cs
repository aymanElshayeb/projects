using POS3.Domain;
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
    public partial class Suppliers : Form, CUDUI<Supplier>
    {
        Supplier obj;
        List<Supplier> list;

        private BindingSource bind;
        private BindingSource bindList;
        private BasisService<Supplier> service;

        public SupplierUI()
        {
            InitializeComponent();
            customInitialize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.create(this.obj);
        }


        public void customInitialize()
        {
            bind = new BindingSource();
            service = new SupplierService();
            obj = service.getEmpty();
            list = service.findAll();


            bind.DataSource = this.obj;
            vId.DataBindings.Add("Text", bind, "Id");
            vName.DataBindings.Add("Text", bind, "Name");
            vAddress.DataBindings.Add("Text", bind, "Address");
            vMobile.DataBindings.Add("Text", bind, "Mobile");
            vMail.DataBindings.Add("Text", bind, "Mail");
            vPaidPeriod.DataBindings.Add("Text", bind, "PaidPeriod");

            bindList = new BindingSource();
            vList.AutoGenerateColumns = false;

            BindingList<Supplier> filtered = new BindingList<Supplier>(this.list);
            bindList.DataSource = filtered;
            vList.DataSource = this.bindList;



            this.cId.DataPropertyName = "Id";
            this.cName.DataPropertyName = "Name";
            cAddress.DataPropertyName = "Address";
            cMobile.DataPropertyName = "Mobile";
            cMail.DataPropertyName = "Mail";
            cPaidPeriod.DataPropertyName = "PaidPeriod";

            this.vList.SelectionChanged += new System.EventHandler(
           vList_SelectionChanged);

        }

        public void create(Supplier entity)
        {
            Supplier newEntity = Util.Util.Clone<Supplier>((Supplier)entity);
            service.add(newEntity);
            list.Add(newEntity);
            refresh(false);

        }
        public void update(Supplier entity)
        {
            service.update(entity);


            list.ForEach(delegate (Supplier obj)
            {
                if (obj.Id.Equals(entity.Id))
                {
                    obj.Name = entity.Name;

                }

            });

            //find and update
            refresh(false);

        }
        public void getNew()
        {
            this.obj = service.getEmpty();
            bind.DataSource = this.obj;
            bind.ResetBindings(true);
        }
        public void refresh(bool mode)
        {
            filter();
            bindList.ResetBindings(mode);
            bind.ResetBindings(mode);
        }
        public void delete(Supplier entity)
        {
            service.delete(entity);

            //delete from list
            list.Remove(entity);
            getNew();
            refresh(false);


        }
        private void filter()
        {
            BindingList<Supplier> filtered = new BindingList<Supplier>(this.list.Where(obj =>
            {

                bool catched = true;


                if (catched && sId.Text != null && (!"".Equals(sId.Text)))
                {
                    catched = obj.Id.Contains(sId.Text);
                }

                if (catched && sName.Text != null && (!"".Equals(sName.Text)))
                {
                    catched = obj.Name.Contains(sName.Text);
                }
                if (catched && sAddress.Text != null && (!"".Equals(sAddress.Text)))
                {
                    catched = obj.Address.Contains(sAddress.Text);
                }
                if (catched && sMobile.Text != null && (!"".Equals(sMobile.Text)))
                {
                    catched = obj.Mobile.Contains(sMobile.Text);
                }
                if (catched && sMail.Text != null && (!"".Equals(sMail.Text)))
                {
                    catched = obj.Mail.Contains(sMail.Text);
                }
                return catched;

            }
            ).ToList());

            bindList.DataSource = filtered;
            vList.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.update(obj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.delete(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getNew();
        }

        private void vList_SelectionChanged(object sender, EventArgs e)
        {
            if (vList.SelectedRows.Count > 0)
            {

                this.obj = new Supplier { Id = vList.SelectedRows[0].Cells["cId"].Value.ToString(), Name = vList.SelectedRows[0].Cells["cName"].Value.ToString() };
                bind.DataSource = this.obj;
                this.refresh(true);


            }


        }

        private void sId_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void sName_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void vMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
