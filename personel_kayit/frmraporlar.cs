using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_kayit
{
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }

        private void frmraporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PersonelVeriTabaniDataSet.personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.PersonelVeriTabaniDataSet.personeller);


            this.reportViewer1.RefreshReport();
        }
    }
}
