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
            string codice = Convert.ToString(codice_box.Text);
            string descrizione = descrizione_box.Text;
            double prezzo = Convert.ToInt64(prezzo_box.Text);
            bool riciclabile = false;
            DateTime dateTime = Convert.ToDateTime(TimePicker_date.Text);
            ArticoloAlimentare[] art = new ArticoloAlimentare[5];
            AlimentareFresco[] art2 = new AlimentareFresco[5];
            ArticoloNonAlimentare[] art3 = new ArticoloNonAlimentare[5];

            for (int i = 0;i < art.Length; i++)
            {
                if (tipo_cmbox.Text == "ALIMENTARE")
                {

                    if (DateTime.Now.Year == dateTime.Year)
                    {
                        art[i] = new ArticoloAlimentare(codice, descrizione, prezzo, dateTime);
                        articoli.Items.Add(art[i].MostraN(codice, descrizione, prezzo, dateTime));
                        break;
                    }
                    else
                    {
                        art[i] = new ArticoloAlimentare(codice, descrizione, prezzo, dateTime);
                        articoli.Items.Add(art[i].Mostra(codice, descrizione, prezzo, dateTime));
                        break;
                    }
                }
                else if (tipo_cmbox.Text == "FRESCO")
                {
                    
                    if (DateTime.Now.Year == dateTime.Year && DateTime.Now.Month == dateTime.Month)
                    {
                        art2[i] = new AlimentareFresco(codice, descrizione, prezzo, dateTime);
                        articoli.Items.Add(art2[i].MostraN(codice, descrizione, prezzo, dateTime));
                        break;
                    }
                    else
                    {
                        art2[i] = new AlimentareFresco(codice, descrizione, prezzo, dateTime);
                        articoli.Items.Add(art2[i].Mostra(codice, descrizione, prezzo, dateTime));
                        break;
                    }
                }
                else if (tipo_cmbox.Text == "NON ALIMENTARE")
                {

                    if (si_check.Checked == true)
                    {
                        riciclabile = true;
                        art3[i] = new ArticoloNonAlimentare(riciclabile, codice, descrizione, prezzo);
                        articoli.Items.Add(art3[i].MostraN(codice, descrizione, prezzo));
                        break;
                    }
                    else
                    {
                        art3[i] = new ArticoloNonAlimentare(riciclabile, codice, descrizione, prezzo);
                        articoli.Items.Add(art3[i].MostraA(codice, descrizione, prezzo));
                        break;
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
        private string codice;
        private string descrizione;
        private double prezzo;

        public string Codice
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

        public Articolo(string cod, string des, double pre)
        {
            Codice = cod;
            Descrizione = des;
            Prezzo = pre;
        }
        public virtual double sconta(double pre)
        {
            double sconto = pre - ((pre * 5) / 100);
            return sconto;
        }
        public virtual string Mostra(string cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€,  Data Scadenza: {dat}";
        }
    }

    class ArticoloAlimentare : Articolo
    {
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public ArticoloAlimentare(string cod, string des, double pre, DateTime dat) : base (cod, des, pre)
        {
            Data = dat;
        }

        public override double sconta(double pre)
        {
            double sconto = pre - ((pre * 20) / 100);
            return sconto;
        }
        public string MostraN(string cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {sconta(pre)}€,  Data Scadenza: {dat}";
        }
        public override string Mostra(string cod, string des, double pre, DateTime dat)
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

        public ArticoloNonAlimentare(bool ric, string cod, string des, double pre) : base(cod, des, pre)
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
        public string MostraN(string cod, string des, double pre)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {sconta(pre)}€";
        }
        public string MostraA(string cod, string des, double pre)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€";
        }
    }

    class AlimentareFresco : Articolo
    {
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public AlimentareFresco(string cod, string des, double pre, DateTime dat) : base(cod, des, pre)
        {
            Data = dat;
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
        public string MostraN(string cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {sconta(pre, dat)}€,  Data Scadenza: {dat}";
        }
        public override string Mostra(string cod, string des, double pre, DateTime dat)
        {
            return $"Codice: {cod},  Articolo: {des},  Prezzo: {pre}€,  Data Scadenza: {dat}";
        }
    }
}
