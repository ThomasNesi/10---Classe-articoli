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
        public struct Prodotto
        {
            public string descrizione;
            public double prezzo;
        }
        public Prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();

            p = new Prodotto[100];
            dim = 0;
        }

        private void aggiungi_btn_Click(object sender, EventArgs e)
        {
            int codice = Convert.ToInt32(codice_box.Text);
            string descrizione = descrizione_box.Text;
            double prezzo = Convert.ToInt64(prezzo_box.Text);
            int anno = Convert.ToInt32(anno_box.Text);
            int mese = Convert.ToInt32(mese_box.Text);
            int giorno = Convert.ToInt32(giorno_box.Text);
            bool riciclabile = false;
            DateTime dateTime = new DateTime(anno, mese, giorno);
            List <int> cod = new List<int>();


            for (int i = 0; i < p.Length; i++)
            {
                if (tipo_cmbox.Text == "ALIMENTARE")
                {
                    ArticoloAlimentare art = new ArticoloAlimentare(codice, descrizione, prezzo, dateTime);
                    if (DateTime.Now.Year == dateTime.Year)
                    {
                        articoli.Items.Add(art.MostraN(codice, descrizione, prezzo, dateTime));
                    }
                    else
                    {
                        articoli.Items.Add(art.Mostra(codice, descrizione, prezzo, dateTime));
                    }
                }
                else if (tipo_cmbox.Text == "FRESCO")
                {
                    AlimentareFresco art = new AlimentareFresco(codice, descrizione, prezzo, dateTime);
                    if (DateTime.Now.Year == dateTime.Year && DateTime.Now.Month == dateTime.Month)
                    {
                        articoli.Items.Add(art.MostraN(codice, descrizione, prezzo, dateTime));
                    }
                    else
                    {
                        articoli.Items.Add(art.Mostra(codice, descrizione, prezzo, dateTime));
                    }
                }
                else if (tipo_cmbox.Text == "NON ALIMENTARE")
                {
                    ArticoloNonAlimentare art = new ArticoloNonAlimentare(riciclabile, codice, descrizione, prezzo, dateTime);
                    if (si_check ==)
                    {
                        articoli.Items.Add(art.Mostra(codice, descrizione, prezzo, dateTime));
                    }
                    else
                    {
                        articoli.Items.Add(art.Mostra(codice, descrizione, prezzo, dateTime));
                    }
                }
            }
        }

        private void scontrino_btn_Click(object sender, EventArgs e)
        {
            articoli.Items.Clear();
        }
    }
    class Articolo
    {
        private int codice;
        private string descrizione;
        private double prezzo;
        private DateTime data;

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
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public Articolo(int cod, string des, double pre, DateTime dat)
        {
            Codice = cod;
            Descrizione = des;
            Prezzo = pre;
            Data = dat;
        }
        public virtual double sconta(double pre)
        {
            double sconto = pre - ((pre * 5) / 100);
            return sconto;
        }
        public virtual string Mostra(int cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€,  Data Scadenza: {dat}";
        }
    }

    class ArticoloAlimentare : Articolo
    {
        public ArticoloAlimentare(int cod, string des, double pre, DateTime dat) : base (cod, des, pre, dat)
        {
            
        }

        public override double sconta(double pre)
        {
            double sconto = pre - ((pre * 20) / 100);
            return sconto;
        }
        public string MostraN(int cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {sconta(pre)}€,  Data Scadenza: {dat}";
        }
        public override string Mostra(int cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€,  Data Scadenza: {dat}";
        }
    }

    class ArticoloNonAlimentare : Articolo
    {
        private bool riciclabile;

        public bool Riciclabile
        {
            get { return riciclabile; }
            set { riciclabile = value;}
        }

        public ArticoloNonAlimentare(bool ric, int cod, string des, double pre, DateTime dat) : base(cod, des, pre, dat)
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
        public override string Mostra(int cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€,  Data Scadenza: {dat}";
        }
    }

    class AlimentareFresco : Articolo
    {

        public AlimentareFresco(int cod, string des, double pre, DateTime dat) : base(cod, des, pre, dat)
        {

        }

        public double sconta(double pre, DateTime dat)
        {
            if ((dat.Day - DateTime.Now.Day) <= 1)
            {
                double sconto = pre - ((pre * 10) / 100);
                return sconto;
            }
            else if ((dat.Day - DateTime.Now.Day) <= 3)
            {
                double sconto = pre - ((pre * 5) / 100);
                return sconto;
            }
            else if ((dat.Day - DateTime.Now.Day) >= 5)
            {
                double sconto = pre - ((pre * 2) / 100);
                return sconto;
            }
            else
            {
                return pre;
            }
        }
        public string MostraN(int cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {sconta(pre, dat)}€,  Data Scadenza: {dat}";
        }
        public override string Mostra(int cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€,  Data Scadenza: {dat}";
        }
    }
}
