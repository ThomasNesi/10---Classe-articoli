using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___Classe_articoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aggiungi_btn_Click(object sender, EventArgs e)
        {
            int codice = Convert.ToInt32(codice_box.Text);
            string descrizione = descrizione_box.Text;
            double prezzo = Convert.ToInt64(prezzo_box.Text);
            Articolo articolo = new Articolo(codice, descrizione, prezzo);
            articoli.Items.Add(articolo.Mostra(codice, descrizione, prezzo));
        }
    }
    class Articolo
    {
        private int codice;
        private string descrizione;
        private double prezzo;

        public int Codice
        {
            get { return codice; }
            set { codice = value; }
        }
        public string Descrizione
        {
            get { return descrizione; }
            set { descrizione = value; }
        }
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }

        public Articolo(int cod, string des, double pre)
        {
            Codice = cod;
            Descrizione = des;
            Prezzo = pre;
        }
        public string Mostra(int cod, string des, double pre)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€";
        }

        public virtual double sconta(double pre)
        {
            double sconto = pre - ((pre * 5) / 100);
            return sconto;
        }
    }

    class ArticoloAlimentare : Articolo
    {
        private int scadenza;

        public int Scadenza
        {
            get { return scadenza; }
            set { scadenza = value; }
        }
        public ArticoloAlimentare(int sca, int cod, string des, double pre) : base (cod, des, pre)
        {
            Scadenza = sca;
        }
        public override double sconta(double pre)
        {
            double sconto = pre - ((pre * 20) / 100);
            return sconto;
        }
    }

    class ArticoloNonAlimetare : Articolo
    {
        private bool riciclabile;

        public bool Riciclabile
        {
            get { return riciclabile; }
            set { riciclabile = value;}
        }

        public ArticoloNonAlimetare(bool ric, int cod, string des, double pre) : base(cod, des, pre)
        {
            Riciclabile = ric;
        }
        public override double sconta(double pre)
        {
            if (riciclabile == true)
            {
                double sconto = pre - ((pre * 10) / 100);
                return sconto;
            }
            else
            {
                return pre;
            }
        }
    }

    class AlimentareFresco : Articolo
    {
        private int giorno;

        public int Giorno
        {
            get { return giorno; }
            set { giorno = value; }
        }

        public AlimentareFresco(int gio, int cod, string des, double pre) : base(cod, des, pre)
        {
            Giorno = gio;
        }

        public override double sconta(double pre)
        {
            if (Giorno <= 1)
            {
                double sconto = pre - ((pre * 10) / 100);
                return sconto;
            }
            else if (Giorno <= 3)
            {
                double sconto = pre - ((pre * 5) / 100);
                return sconto;
            }
            else if (Giorno >= 5)
            {
                double sconto = pre - ((pre * 2) / 100);
                return sconto;
            }  
            else 
            { 
                return pre;
            }
        }
    }
}
