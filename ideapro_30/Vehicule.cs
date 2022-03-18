using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideapro_30
{
    public partial class Vehicule : Form
    {
        public Vehicule()
        {
            InitializeComponent();
        }

        private void Vihecule_Load(object sender, EventArgs e)
        {

        }

        private void dgvVehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vihecule_Shown(object sender, EventArgs e)
        {
            dgvVehicule.Rows.Add(
                new object[]
                {
                    "test",
                    "test",
                    "test",
                    "test",
                    "test",
                    "test"
                }
                
                );
            dgvVehicule.Rows.Add(
                    new object[]
                    {
                    "test",
                    "test",
                    "test",
                    "test",
                    "test",
                    "test"
                    }

                    );
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
