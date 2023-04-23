using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apm.Forms
{
    public partial class KundenAnzeigen : Form
    {
        public List<Kunde> Kunden { get; set; }
        private KundenSuchen _prevForm = null;
        private Startfenster _mainForm = null;


        /// <summary>
        /// Standard-Konstruktor KundenAnzeigen
        /// </summary>
        public KundenAnzeigen()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Konstruktor KundenAnzeigen.
        /// </summary>
        /// <param name="startFenster"></param>
        /// <param name="vorherigesFenster"></param>
        public KundenAnzeigen(Form startFenster, Form vorherigesFenster)
        {
            _prevForm = vorherigesFenster as KundenSuchen;
            _mainForm = startFenster as Startfenster;
            InitializeComponent();
        }


        /// <summary>
        /// Beschafft die Kundenliste vom Startfenster, sucht in dieser Liste
        /// nach dem, Kunden (anhand der Kundennummer), welcher ausgewaehlt wurde und
        /// fuellt dessen Werte in das Formular.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundenAnzeigen_Load(object sender, EventArgs e)
        {
            Kunden = _mainForm.GetKunden();
            int index = Kunden.FindIndex(a => a.Kundennummer == int.Parse(_prevForm.SelectedRow.Cells[0].Value.ToString()));
            tb_kundennummer.Text = Kunden[index].Kundennummer.ToString();
            tb_vorname.Text = Kunden[index].Vorname.ToString();
            tb_nachname.Text = Kunden[index].Nachname.ToString();
            dtp_geburtsdatum.Value = Kunden[index].Geburtsdatum.Date;
            tb_strasse.Text = Kunden[index].Strasse.ToString();
            tb_zipCode.Text = Kunden[index].Zip.ToString();
            tb_wohnort.Text = Kunden[index].Wohnort.ToString();
            tb_land.Text = Kunden[index].Land.ToString();
            cb_status.SelectedItem = Kunden[index].Status.ToString();
            cb_geschlecht.SelectedItem = Kunden[index].Geschlecht.ToString();
            tb_staatsbuergerschaft.Text = Kunden[index].Staatsbuergerschaft.ToString();
            tb_hausnummer.Text = Kunden[index].Hausnummer.ToString();
            tb_telefonnummer.Text = Kunden[index].Telefonnummer.ToString();
            tb_email.Text = Kunden[index].EMailAdresse.ToString();
        }
    }
}
