using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server = new Server();
        public FrmServer()
        {
            InitializeComponent();
            cmbIgre.DataSource = Kontroler.Instance.VratiSveIgre();
            cmbIgre.DisplayMember = "Naziv";

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dgvIgraci.DataSource = new BindingList<ClientHandler>(server.Klijenti);
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            Igra igra = (Igra)cmbIgre.SelectedItem;
            if (!int.TryParse(txtBrojIgraca.Text, out int brojIgraca) || brojIgraca > 4 || brojIgraca < 2)
            {
                MessageBox.Show("Broj igraca nije dobar!");
                return;
            }
            Thread nit = new Thread(() => { server.PokreniIgru(igra, brojIgraca); });
            nit.Start();
            MessageBox.Show("Server je uspesno pokrenut!");
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

    
}

