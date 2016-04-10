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
    public partial class ExpenseUI : Form, CUDUI<Expense>
    {
        Expense obj;
        List<Expense> list;

        private BindingSource bind;
        private BindingSource bindList;
        private BasisService<Expense> service;

        public ExpenseUI()
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
            service = new ExpenseService();
            obj = service.getEmpty();
            list = service.findAll();


            bind.DataSource = this.obj;
            vId.DataBindings.Add("Text", bind, "Id");
            
            vName.DataBindings.Add("Text", bind, "Name");

            bindList = new BindingSource();
            vList.AutoGenerateColumns = false;

            BindingList<Expense> filtered = new BindingList<Expense>(this.list);
            bindList.DataSource = filtered;
            vList.DataSource = this.bindList;



            this.cId.DataPropertyName = "Id";
            
            this.cName.DataPropertyName = "Name";

            this.vList.SelectionChanged += new System.EventHandler(
           vList_SelectionChanged);

        }

        public void create(Expense entity)
        {
            Expense newEntity = Util.Util.Clone<Expense>((Expense)entity);
            service.add(newEntity);
            list.Add(newEntity);
            refresh(false);

        }
        public void update(Expense entity)
        {
            service.update(entity);


            list.ForEach(delegate (Expense obj)
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
        public void delete(Expense entity)
        {
            service.delete(entity);

            //delete from list
            list.Remove(entity);
            getNew();
            refresh(false);


        }
        private void filter()
        {
            BindingList<Expense> filtered = new BindingList<Expense>(this.list.Where(obj =>
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

                this.obj = new Expense { Id = vList.SelectedRows[0].Cells["cId"].Value.ToString(), Name = vList.SelectedRows[0].Cells["cName"].Value.ToString()};
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
    }
}
