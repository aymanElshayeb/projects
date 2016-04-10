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
    public partial class _ٌRegisterExpenses : Form, CUDUI<RegisterExpense>
    {
        RegisterExpense obj;
        

        private BindingSource bind;
        
        private BasisService<RegisterExpense> service;

        public _ٌRegisterExpenses()
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
            service = new RegisterExpenseService();
            obj = service.getEmpty();
            


            bind.DataSource = this.obj;
            vId.DataBindings.Add("Text", bind, "Id");
            vName.DataBindings.Add("Text", bind, "Name");

            

        }

        public void create(RegisterExpense entity)
        {
            RegisterExpense newEntity = Util.Util.Clone<RegisterExpense>(entity);
            service.add(newEntity);
            refresh(false);

        }
        public void update(RegisterExpense entity)
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
        public void delete(RegisterExpense entity)
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
