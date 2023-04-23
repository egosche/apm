using System;
using System.Collections;
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
    public partial class KundenSuchen : Form
    {
        private string _nextForm = null;
        private Form _currentForm;
        private Startfenster mainForm = null;
        private List<Flug> Fluege { get; set; }
        public List<Kunde> Kunden { get; set; }
        public DataGridViewRow SelectedRow { get; set; }


        public KundenSuchen()
        {
            InitializeComponent();
        }

        public KundenSuchen(Form startFenster, string naechstesFenster)
        {
            InitializeComponent();
            mainForm = startFenster as Startfenster;
            Fluege = mainForm.GetFluege();
            Kunden = mainForm.GetKunden();
            _nextForm = naechstesFenster;
        }

        /// <summary>
        /// Schliesst die aktuelle Form und oeffnet die uebergebene Form.
        /// </summary>
        /// <param name="form">Anzuzeigende Form</param>
        private void ZeigeForm(Form form)
        {
            if (_currentForm != null)
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
        /// Sucht nach Uebereinstimmungen in einer uebergebenen Kundenliste mit den angegebenen Parametern.
        /// Gibt eine Kundenliste aus, welche Kunden mit Uebereinstimmungen enthaelt.
        /// </summary>
        /// <param name="kundenliste">Kundenliste, in welcher gesucht werden soll</param>
        /// <param name="kundennummer">Gesuchte Kundennummer</param>
        /// <param name="name">Gesuchter Name</param>
        /// <param name="adresse">Gesuchte Adresse</param>
        /// <param name="land">Gesuchtes Land</param>
        /// <returns>Liste von Kunden mit Uebereinstimmungen</returns>
        private List<Kunde> SuchKunde(List<Kunde> kundenliste, int kundennummer, string vorname, string nachname, string wohnort)
        {

            List<Kunde> gesucht = null;
            List<Kunde> ergebnisse = new List<Kunde>();

            if (kundennummer != -1)
            {
                if (ergebnisse.Count == 0)
                {
                    gesucht = kundenliste.Where(item => item.Kundennummer.ToString().StartsWith(kundennummer.ToString())).ToList();

                    foreach (Kunde kunde in gesucht)
                    {
                        if (!ergebnisse.Where(item => item.Kundennummer.Equals(kunde.Kundennummer)).Any())
                            ergebnisse.Add(kunde);
                    }
                }
                else
                {

                    gesucht = ergebnisse.Where(item => item.Kundennummer.ToString().StartsWith(kundennummer.ToString())).ToList();
                    ergebnisse = gesucht;
                }
            }

            if (vorname != "")
            {
                if (ergebnisse.Count == 0)
                {
                    gesucht = kundenliste.Where(item => item.Vorname.ToUpper().Contains(vorname.ToUpper())).ToList();

                    foreach (Kunde kunde in gesucht)
                    {
                        if (!ergebnisse.Where(item => item.Kundennummer.Equals(kunde.Kundennummer)).Any())
                            ergebnisse.Add(kunde);
                    }
                }
                else
                {

                    gesucht = ergebnisse.Where(item => item.Vorname.ToUpper().Contains(vorname.ToUpper())).ToList();
                    ergebnisse = gesucht;
                }
            }

            if (nachname != "")
            {
                if (ergebnisse.Count == 0)
                {
                    gesucht = kundenliste.Where(item => item.Nachname.ToUpper().Contains(nachname.ToUpper())).ToList();

                    foreach (Kunde kunde in gesucht)
                    {
                        if (!ergebnisse.Where(item => item.Kundennummer.Equals(kunde.Kundennummer)).Any())
                            ergebnisse.Add(kunde);
                    }
                }
                else
                {

                    gesucht = ergebnisse.Where(item => item.Nachname.ToUpper().Contains(nachname.ToUpper())).ToList();
                    ergebnisse = gesucht;
                }
            }

            if (wohnort != "")
            {
                if (ergebnisse.Count == 0)
                {
                    gesucht = kundenliste.Where(item => item.Wohnort.ToUpper().Contains(wohnort.ToUpper())).ToList();

                    foreach (Kunde kunde in gesucht)
                    {
                        if (!ergebnisse.Where(item => item.Kundennummer.Equals(kunde.Kundennummer)).Any())
                            ergebnisse.Add(kunde);
                    }
                }
                else
                {

                    gesucht = ergebnisse.Where(item => item.Wohnort.ToUpper().Contains(wohnort.ToUpper())).ToList();
                    ergebnisse = gesucht;
                }
            }


            return ergebnisse;
        }


        /// <summary>
        /// Ueberprueft, ob alle TextBoxes leer sind. Wenn dies der Fall ist
        /// werden die kommenden Fluege angezeigt. Andernfalls wird eine Suchanfrage
        /// gestellt.
        /// </summary>
        /// <returns></returns>
        private void WechselKundenFluege()
        {
            if (tb_kundennummer.Text == "" && tb_vorname.Text == "" && tb_nachname.Text == "" && tb_wohnort.Text == "")
            {
                dgv_fluegeKunden.DataSource = Fluege;
                ibtn_fluegeKunden.Text = "Kommende Flüge";
            }
            else
            {
                dgv_fluegeKunden.DataSource = Kunden;
                ibtn_fluegeKunden.Text = "Suchergebnisse";
                

                // Fange Fehler ab und ersetze die Kundennummer durch -1, falls keine
                // eingegeben wurde.
                try
                {
                    if (int.TryParse(tb_kundennummer.Text, out int userVal))
                        dgv_fluegeKunden.DataSource = SuchKunde(Kunden, userVal, tb_vorname.Text, tb_nachname.Text, tb_wohnort.Text);
                    else
                        dgv_fluegeKunden.DataSource = SuchKunde(Kunden, -1, tb_vorname.Text, tb_nachname.Text, tb_wohnort.Text);

                    dgv_fluegeKunden.Columns["Site"].Visible = false;
                    dgv_fluegeKunden.Columns["Kundennummer"].DisplayIndex = 0;
                    dgv_fluegeKunden.Columns["Nachname"].DisplayIndex = 1;
                    dgv_fluegeKunden.Columns["Vorname"].DisplayIndex = 2;
                    dgv_fluegeKunden.Columns["Wohnort"].DisplayIndex = 3;


                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
        }


        /// <summary>
        /// Fuellt die DataGridView mit Fluegen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundenSuchen_Load(object sender, EventArgs e)
        {
            dgv_fluegeKunden.DataSource = Fluege;
        }


        /// <summary>
        /// Leert die Textboxen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zuruecksetzen_Click(object sender, EventArgs e)
        {
            tb_kundennummer.Text = "";
            tb_vorname.Text = "";
            tb_nachname.Text = "";
            tb_wohnort.Text = "";
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_kundennummer_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_adresse_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Wenn alle TextBoxes leer sind werden kommende Fluege gezeigt.
        /// Andernfalls Kunden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_land_TextChanged(object sender, EventArgs e)
        {
            WechselKundenFluege();
        }

        /// <summary>
        /// Bestaetigt die Auswahl eines Kunden uber die Suchergebnisse und oeffnet
        /// das Fenster zum Bearbeiten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_auswaehlen_Click(object sender, EventArgs e)
        {
            if (dgv_fluegeKunden.Rows.Count != 0)
            {
                SelectedRow = dgv_fluegeKunden.Rows[dgv_fluegeKunden.CurrentCell.RowIndex];
                if (ibtn_fluegeKunden.Text == "Suchergebnisse")
                {
                    if (_nextForm == "KundenAnzeigen")
                    {
                        pn_anzeige.Visible = false;
                        pn_suche.Visible = false;
                        ZeigeForm(new KundenAnzeigen(mainForm, this));
                    }
                    else
                    {
                        pn_anzeige.Visible = false;
                        pn_suche.Visible = false;
                        ZeigeForm(new KundenBearbeiten(mainForm, this));
                    }
                }
                else
                    // Die Implementation der Funktion, ueber welche ein Kunde auch anhand der kommenden
                    // Fluege ausgewaehlt werden kann, ist in diesem Beleg nicht vorgesehen.
                    MessageBox.Show("Bevor Sie einen Kunden auswählen können, müssen Sie diesen über das " +
                        "Suchformular finden.", "Hinweis");
            }
            
        }

    }
}
