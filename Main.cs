using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCopyImageFolder_Click(object sender, EventArgs e)
        {
            CopyImageFolder copyImageFolder = new CopyImageFolder();
            copyImageFolder.ShowDialog();
        }

        private void btnAggExcel_Click(object sender, EventArgs e)
        {
            AggregationExcel aggregationExcel = new AggregationExcel();
            aggregationExcel.ShowDialog();
        }

        private void btnAggExcelZPEAK_Click(object sender, EventArgs e)
        {
            AggregationExcelZPEAK aggregationExcelZPEAK = new AggregationExcelZPEAK();
            aggregationExcelZPEAK.Show();
        }

        private void btnCheckJson_Click(object sender, EventArgs e)
        {
            CheckJsonZPEAK checkJsonZPEAK = new CheckJsonZPEAK();
            checkJsonZPEAK.Show();
        }
    }
}
