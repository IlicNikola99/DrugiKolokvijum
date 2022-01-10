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

namespace Klijent
{
    public partial class FrmKlijent : Form
    {
        private double brojPoena = 0;

        public FrmKlijent()
        {
            InitializeComponent();
            gbIgra.Enabled = false;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                Komunikacija.Instance.PrijaviSe(txtKorisnickoIme.Text);
                MessageBox.Show("Cekam na pocetak igre!");
                gbPrijava.Enabled = false;
                gbIgra.Enabled = true;
                ProcitajPitanje();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcitajPitanje()
        {
            OdgovorOdServera odgovor = Komunikacija.Instance.ProcitajPorukuOdServera();
            if (odgovor.Pobednik == null)
            {
                    txtPitanje.Text = odgovor.TekstPitanja;
            }
            else
            {
                MessageBox.Show("Pobednik je " + odgovor.Pobednik + odgovor.Poeni);
            }
        }

        private void Odgovori()
        {
            ZahtevOdKlijenta z = new ZahtevOdKlijenta { Odgovor = txtOdgovor.Text };
            Komunikacija.Instance.PosaljiPoruku(z);
            OdgovorOdServera odgovor = Komunikacija.Instance.ProcitajPorukuOdServera();
            txtPorukaOdServera.Text = odgovor.PorukaOdServera;
            brojPoena += odgovor.Poeni;
            txtUkupanBrojPoena.Text = brojPoena.ToString();
        }

        private void btnPosaljiOdgovor_Click(object sender, EventArgs e)
        {
            Odgovori();
            ProcitajPitanje();
        }
    }
}
