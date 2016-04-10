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
using POS3.Util;
namespace POS3
{
    public partial class Items : Form, CUDUI<Item>
    {
        Item item;
        List<Item> list;
        
        private BindingSource bind;
        private BindingSource bindList;
        private ItemService itemService;
        
        public Items()
        {
            InitializeComponent();
            customInitialize();
        }

        public void customInitialize()
        {
            bind = new BindingSource();
            itemService = new ItemService();
            item = itemService.getEmpty();
            list = itemService.findAll();
            

            bind.DataSource = this.item;
            vId.DataBindings.Add("Text", bind, "Id");
            vBarcode.DataBindings.Add("Text", bind, "Barcode");
            vName.DataBindings.Add("Text", bind, "Name");

            bindList = new BindingSource();
            vList.AutoGenerateColumns = false;

            BindingList<Item> filtered = new BindingList<Item>(this.list);
            bindList.DataSource = filtered;
            vList.DataSource = this.bindList;

            

            this.cId.DataPropertyName = "Id";
            this.cBarcode.DataPropertyName = "Barcode";
            this.cName.DataPropertyName = "Name";
        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.create(this.item);
        }

        public void create(Item entity)
        {
            Item newItem=Util.Util.Clone<Item>((Item)entity);
            itemService.add(newItem);
            list.Add(newItem);      
            refresh(false);

        }
        public void update(Item entity)
        {
            itemService.update(entity);


            list.ForEach(delegate (Item item)
                            {
                                if(item.Id.Equals(entity.Id))
                                {
                                    item.Name = entity.Name;
                                    item.Barcode = entity.Barcode;
                                }
                                    
                            });

            //find and update
            refresh(false);

        }
        public void refresh(bool mode)
        {
            filter();
            bindList.ResetBindings(mode);
            bind.ResetBindings(mode);
        }
        public void delete(Item entity)
        {
            itemService.delete(entity);

            //delete from list
            list.Remove(entity);
            refresh(false);

        }
        private void filter()
        {
            BindingList<Item> filtered = new BindingList<Item>(this.list.Where(obj =>
            {

                bool catched = true;
                if (catched && sBarcode.Text != null && (!"".Equals(sBarcode.Text)))
                {
                    catched = obj.Barcode.Contains(sBarcode.Text);
                }

                if (catched && sNumber.Text != null && (!"".Equals(sNumber.Text)))
                {
                    catched = obj.Id.Contains(sNumber.Text);
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
        public void getNew()
        {
            this.item = itemService.getEmpty();
            bind.DataSource = this.item;
            this.refresh(true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.update(this.item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.delete(this.item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getNew();
        }

        public void getNew()
        {
            this.item = itemService.getEmpty();
            bind.DataSource = this.item;
            this.refresh(true);
        }
      
        private void sBarcode_TextChanged(object sender, EventArgs e)
        {
            this.filter();
        }

        

        private void sName_TextChanged(object sender, EventArgs e)
        {
            this.filter();
        }

        private void sNumber_TextChanged(object sender, EventArgs e)
        {
            this.filter();
        }

        private void vList_SelectionChanged(object sender, EventArgs e)
        {
            if (vList.SelectedRows.Count > 0)
            {

                this.item = new Item(vList.SelectedRows[0].Cells["cId"].Value.ToString(), vList.SelectedRows[0].Cells["cBarcode"].Value.ToString(), vList.SelectedRows[0].Cells["cName"].Value.ToString());
                bind.DataSource = this.item;
                this.refresh(true);


            }


        }

        
    }

    
}
;