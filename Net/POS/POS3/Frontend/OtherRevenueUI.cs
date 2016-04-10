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
    public partial class OtherExpenses : Form, CUDUI<OtherExpense>
    {
        OtherExpense obj;


        private BindingSource bind;

        private BasisService<OtherExpense> service;

        public OtherExpenses()
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
            service = new OtherExpenseService();
            obj = service.getEmpty();



            bind.DataSource = this.obj;
            
            vName.DataBindings.Add("Text", bind, "Name");
            vAmount.DataBindings.Add("Text", bind, "Amount");
            vCreationDate.DataBindings.Add("Text", bind, "CreationDate");
            vComments.DataBindings.Add("Text", bind, "Comments");


        }

        public void create(OtherExpense entity)
        {
            OtherExpense newEntity = Util.Util.Clone<OtherExpense>(entity);
            service.add(newEntity);
            refresh(false);

        }
        public void update(OtherExpense entity)
        {
            service.update(entity);
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


            bind.ResetBindings(mode);
        }
        public void delete(OtherExpense entity)
        {
            service.delete(entity);
            getNew();
            refresh(false);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getNew();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.update(obj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.create(obj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.delete();
        }
    }
}
