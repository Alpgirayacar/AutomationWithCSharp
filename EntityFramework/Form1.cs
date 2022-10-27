using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        public void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblStockAmound_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
              Name=  tbxName.Text,
              UnitPrace=Convert.ToDecimal(tbxUnitPrace.Text),
              StockAmount=Convert.ToInt32(tbxStockAmound.Text)

            });
            LoadProducts();
            MessageBox.Show("ADDED!!!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrace = Convert.ToDecimal(tbxUnitParaceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            }

                );
            LoadProducts();
            MessageBox.Show("UPDATED!!");
        }
        
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitParaceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            }
                );
            LoadProducts();
            MessageBox.Show("DELETED!!");
        }
    }
}
