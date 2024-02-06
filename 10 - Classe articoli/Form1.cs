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

        public double sconta(double pre)
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
        public AriticoloAlimentare(int sca, int cod, string des, double pre) : base (cod, des, pre)
        {
            Scadenza = sca;
        }
    }

    class ArticoloNonAlimetare
    {

    }

    class AlimentareFresco
    {

    }
}
