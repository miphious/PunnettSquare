using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunnettsSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MonohybridBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            
            dataTable.Columns.Add("");
            dataTable.Columns.Add("");

            dataTable.Rows.Add("");
            dataTable.Rows.Add("");

        }

        private void DihybridBtn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("");
            dataTable.Columns.Add("");
            dataTable.Columns.Add("");
            dataTable.Columns.Add("");

            dataTable.Rows.Add("");
            dataTable.Rows.Add("");
            dataTable.Rows.Add("");
            dataTable.Rows.Add("");
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.traitTB1.Text = "";
            this.traitTB1.Text = "";
        }
    }
}
