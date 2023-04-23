using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apm.Forms;
using FontAwesome.Sharp;

namespace apm
{
    public partial class Startfenster : Form
    {
        private IconButton _currentButton;
        private Form _currentForm;
        private List<Kunde> _kunden = new List<Kunde>();
        private List<Flug> _fluege = new List<Flug>();


        /// <summary>
        /// Konstruktor Startfenster.
        /// Generiert testdaten und zeigt ersten Menuepunkt.
        /// </summary>
        public Startfenster()
        {
            InitializeComponent();
            GeneriereKunden();
            GeneriereFluege();
            ZeigeForm(new KundenHinzufuegen());
        }


        /// <summary>
        /// Liefert die Kundenliste.
        /// </summary>
        /// <returns>Kundenliste</returns>
        public List<Kunde> GetKunden()
        {
            return _kunden;
        }


        /// <summary>
        /// Ersetzt die Kundenliste durch die uebergebene Liste.
        /// </summary>
        /// <param name="kundenliste">Neue Kundenliste</param>
        public void SetKunden(List<Kunde> kundenliste)
        {
            _kunden = kundenliste;
        }


        /// <summary>
        /// Liefert die Flugliste.
        /// </summary>
        /// <returns>Flugliste</returns>
        public List<Flug> GetFluege()
        {
            return _fluege;
        }


        /// <summary>
        /// Ersetzt die Flugliste durch die uebergebene Liste.
        /// </summary>
        /// <param name="flugliste">Neue Flugliste</param>
        public void SetFluege(List<Flug> flugliste)
        {
            _fluege = flugliste;
        }


        /// <summary>
        /// Schliesst die aktuelle Form und oeffnet die uebergebene Form.
        /// </summary>
        /// <param name="form">Anzuzeigende Form</param>
        private void ZeigeForm(Form form)
        {
            if(_currentForm != null)
            {
                _currentForm.Close();
            }
            _currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pn_form.Controls.Add(form);
            pn_form.Tag = form;
            form.BringToFront();
            form.Show();
        }


        /// <summary>
        /// Selektiert einen Menubutton und passt dementsprechend im Header 
        /// das Icon und den Titel an.
        /// </summary>
        /// <param name="senderButton">Button, welcher eine Selektierung anfordert</param>
        private void AktiviereButton(object senderButton)
        {
            if (senderButton != null)
            {
                DeaktiviereButton();
                _currentButton = (IconButton)senderButton;
                _currentButton.BackColor = Color.FromArgb(126, 214, 223);
                _currentButton.TextAlign = ContentAlignment.MiddleCenter;
                _currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                _currentButton.ImageAlign = ContentAlignment.MiddleRight;

                ipb_seite.IconChar = _currentButton.IconChar;
                lb_formtitel.Text = _currentButton.Text;
            }
        }


        /// <summary>
        /// Hebt die Selektierung eines der Menubuttons auf.
        /// </summary>
        private void DeaktiviereButton()
        {
            if (_currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb(199, 236, 238);
                _currentButton.TextAlign = ContentAlignment.MiddleLeft;
                _currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                _currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        /// <summary>
        /// Erstellt einen Kundenstamm und fuegt Kunden hinzu fuer Testzwecke. Die erzeugen Daten werden in die 
        /// Kundenliste geschrieben.
        /// </summary>
        private void GeneriereKunden()
        {
            Kundenstamm ksLufthansa = new Kundenstamm("Lufthansa");
            try
            {
                Kunde kunde1 = new Kunde(1273856, Kunde.Stati.Flug_gebucht, "Hans", "Mueller", DateTime.Now, Kunde.Geschlechter.m, 0152017324, "h.mueller@test.de",
                    "deutsch", "Am Schwanenteich", "8", 09648, "Mittweida", "Deutschland");
                ksLufthansa.Add(kunde1, "1273856");

                Kunde kunde2 = new Kunde(1936122, Kunde.Stati.unbekannt, "Jan", "Schmidt", DateTime.Now, Kunde.Geschlechter.m, 037183624, "j.schm@try.com",
                    "deutsch", "Gasse", "12b", 08213, "Stenn", "Deutschland");
                ksLufthansa.Add(kunde2, "1936122");

                Kunde kunde3 = new Kunde(1200836, Kunde.Stati.unbekannt, "Julia", "Meyer", DateTime.Now, Kunde.Geschlechter.w, 034821374, "julchen.mey@gmail.de",
                    "deutsch", "Am Tor", "27a", 01283, "Tübingen", "Deutschland");
                ksLufthansa.Add(kunde3, "1200836");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Kunde konnte nicht hinzugefuegt werden: " + e.Message);
            }

            ComponentCollection kundenstammListe = ksLufthansa.Components;
            IEnumerator denum = kundenstammListe.GetEnumerator();

            while (denum.MoveNext())
            {
                _kunden.Add((Kunde)denum.Current);
            }
        }


        /// <summary>
        /// Erstellt Fluege fuer Testzwecke und fuegt sie der Flugliste hinzu.
        /// </summary>
        private void GeneriereFluege()
        {
            _fluege.Add(new Flug(4234, "FRA", "JFK",
                    new DateTime(2020, 09, 25, 10, 30, 00), new DateTime(2020, 09, 25, 19, 25, 00)));

            _fluege.Add(new Flug(1932, "TXL", "MUC",
                new DateTime(2020, 09, 25, 11, 50, 00), new DateTime(2020, 09, 25, 12, 45, 00)));

            _fluege.Add(new Flug(4234, "DUS", "AUH",
                new DateTime(2020, 09, 26, 06, 15, 00), new DateTime(2020, 09, 26, 20, 32, 00)));

            _fluege.Add(new Flug(4234, "LEJ", "CDG",
                new DateTime(2020, 09, 28, 15, 40, 00), new DateTime(2020, 09, 28, 17, 02, 00)));
        }
        

        private void btn_hinzufuegen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenHinzufuegen());
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenSuchen(this, "KundenBearbeiten"));
        }

        private void btn_entfernen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenSuchen());
        }

        private void btn_informationenAbrufen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new KundenSuchen(this, "KundenAnzeigen"));
        }

        private void btn_umbuchen_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
            ZeigeForm(new Umbuchen());
        }

        private void btn_startManuell_Click(object sender, EventArgs e)
        {
            AktiviereButton(sender);
        }
    }

}
