using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prrduct_Management_Liblery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void table_2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB1DataSet1);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB1DataSet1.Table_2' table. You can move, or remove it, as needed.
            this.table_2TableAdapter.Fill(this.dB1DataSet1.Table_2);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            table_2BindingSource.RemoveCurrent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            table_2BindingSource.AddNew();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            table_2BindingSource.MoveLast();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            table2BindingSource.MoveNext();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            table2BindingSource.MovePrevious();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            table2BindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table2BindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table2BindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table2BindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table2BindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table2BindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table2BindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB1DataSet1);
        }
    }

    
}
