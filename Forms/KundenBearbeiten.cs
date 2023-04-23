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
    public partial class KundenBearbeiten : Form
    {
        public List<Kunde> Kunden { get; set; }
        private KundenSuchen _prevForm = null;
        private Startfenster _mainForm = null;
        private int _kundenIndex;
        

        /// <summary>
        /// Standard-Konstruktor KundenBearbeiten
        /// </summary>
        public KundenBearbeiten()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Konstruktor KundenBearbeiten.
        /// </summary>
        /// <param name="startFenster">Startfenster Form</param>
        /// <param name="vorherigesFenster">Form, von welcher aus KundenBearbeiten aufgerufen wird.</param>
        public KundenBearbeiten(Form startFenster, Form vorherigesFenster)
        {
            _prevForm = vorherigesFenster as KundenSuchen;
            _mainForm = startFenster as Startfenster;
            InitializeComponent();
        }


        /// <summary>
        /// Beim Laden der Form wird die Kundenliste geladen und in das Formular geladen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KundenBearbeiten_Load(object sender, EventArgs e)
        {
            Kunden = _mainForm.GetKunden();
            _kundenIndex = Kunden.FindIndex(a => a.Kundennummer == int.Parse(_prevForm.SelectedRow.Cells[0].Value.ToString()));
            tb_kundennummer.Text = Kunden[_kundenIndex].Kundennummer.ToString();
            tb_vorname.Text = Kunden[_kundenIndex].Vorname.ToString();
            tb_nachname.Text = Kunden[_kundenIndex].Nachname.ToString();
            dtp_geburtsdatum.Value = Kunden[_kundenIndex].Geburtsdatum.Date;
            tb_strasse.Text = Kunden[_kundenIndex].Strasse.ToString();
            tb_zipCode.Text = Kunden[_kundenIndex].Zip.ToString();
            tb_wohnort.Text = Kunden[_kundenIndex].Wohnort.ToString();
            tb_land.Text = Kunden[_kundenIndex].Land.ToString();
            cb_status.SelectedItem = Kunden[_kundenIndex].Status.ToString();
            cb_geschlecht.SelectedItem = Kunden[_kundenIndex].Geschlecht.ToString();
            tb_staatsbuergerschaft.Text = Kunden[_kundenIndex].Staatsbuergerschaft.ToString();
            tb_hausnummer.Text = Kunden[_kundenIndex].Hausnummer.ToString();
            tb_telefonnummer.Text = Kunden[_kundenIndex].Telefonnummer.ToString();
            tb_email.Text = Kunden[_kundenIndex].EMailAdresse.ToString();
        }


        /// <summary>
        /// Setzt ein Label mit einem gewaehlten Text und blendet es nach 3 Sekunden 
        /// aus.
        /// </summary>
        /// <param name="label">Label, welches den Text anzeigen soll.</param>
        /// <param name="text">Text, welcher vom Label angezeigt werden soll.</param>
        /// <param name="schriftfarbe">Schriftfarbe, in welcher das Label den Text anzeigen soll.</param>
        private void TimerLabel(Label label, string text, Color schriftfarbe)
        {
            label.Show();
            label.Text = text;
            label.ForeColor = schriftfarbe;
            Timer t = new Timer();
            t.Interval = 3000; // entspricht 3 Sekunden
            t.Tick += (s, d) =>
            {
                label.Hide();
                t.Stop();
            };
            t.Start();
        }


        /// <summary>
        /// Ueberprueft, ob die uebergebene Textbox nicht leer ist und auf Wunsch auch, 
        /// ob nur nummerische Werte eingegeben wurden.
        /// </summary>
        /// <param name="tb">Zu ueberpruefende Textbox</param>
        /// <param name="onlyNummeric">Bestimmt, ob ueberprueft werden soll, dass nur nummerische Werte eingetragen wurden.</param>
        private void CheckTextbox(TextBox tb, bool onlyNummeric)
        {
            if (onlyNummeric)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[^0-9]") ||
                tb.Text == "")
                    tb.BackColor = Color.LightCoral;
                else
                    tb.BackColor = Color.White;
            }
            else
            {
                if (tb.Text == "")
                    tb.BackColor = Color.LightCoral;
                else
                    tb.BackColor = Color.White;
            }
        }


        /// <summary>
        /// Beim Klicken auf den Speichern Button werden die im Formular eingetragenen Werte in die 
        /// eigene Kundenliste uebertragen und in die Liste des Startfensters geladen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_speichern_Click(object sender, EventArgs e)
        {
            try
            {
                Kunden[_kundenIndex].Kundennummer = int.Parse(tb_kundennummer.Text);
                Kunden[_kundenIndex].Vorname = tb_vorname.Text;
                Kunden[_kundenIndex].Nachname = tb_nachname.Text;
                Kunden[_kundenIndex].Geburtsdatum = dtp_geburtsdatum.Value;
                Kunden[_kundenIndex].Strasse = tb_strasse.Text;
                Kunden[_kundenIndex].Zip = int.Parse(tb_zipCode.Text);
                Kunden[_kundenIndex].Wohnort = tb_wohnort.Text;
                Kunden[_kundenIndex].Land = tb_land.Text;
                Kunden[_kundenIndex].Status = (Kunde.Stati)Enum.Parse(typeof(Kunde.Stati), cb_status.SelectedItem.ToString());
                Kunden[_kundenIndex].Geschlecht = (Kunde.Geschlechter)Enum.Parse(typeof(Kunde.Geschlechter), cb_geschlecht.SelectedItem.ToString());
                Kunden[_kundenIndex].Staatsbuergerschaft = tb_staatsbuergerschaft.Text;
                Kunden[_kundenIndex].Hausnummer = tb_hausnummer.Text;
                if (tb_telefonnummer.Text[0] == '+') // Evtl. + vor Telefonnummer wird entfernt
                    tb_telefonnummer.Text = tb_telefonnummer.Text.Remove(0, 1);
                Kunden[_kundenIndex].Telefonnummer = long.Parse(tb_telefonnummer.Text);
                Kunden[_kundenIndex].EMailAdresse = tb_email.Text;
                _mainForm.SetKunden(Kunden);
                TimerLabel(lb_feedback, "Speichern erfolgreich!", Color.Green);
                
            }
            catch (Exception ex)
            {
                TimerLabel(lb_feedback, "Speichern fehlgeschlagen!", Color.Red);
                Console.WriteLine("Error: " + ex);
            }
        }

        private void tb_kundennummer_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_kundennummer, true);
        }

        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_vorname, false);
        }

        private void tb_nachname_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_nachname, false);
        }

        private void tb_strasse_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_strasse, false);
        }

        private void tb_zipCode_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_zipCode, true);
        }

        private void tb_wohnort_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_wohnort, false);
        }

        private void tb_land_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_land, false);
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Funktioniert noch nicht wie es soll.
            if (cb_status.SelectedIndex == -1)
                cb_status.BackColor = Color.LightCoral;
            else
                cb_status.BackColor = Color.White;
        }

        private void cb_geschlecht_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Funktioniert noch nicht wie es soll.
            if (cb_geschlecht.SelectedIndex == -1)
                cb_geschlecht.BackColor = Color.LightCoral;
            else
                cb_geschlecht.BackColor = Color.White;
        }

        private void tb_staatsbuergerschaft_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_staatsbuergerschaft, false);
        }

        private void tb_hausnummer_TextChanged(object sender, EventArgs e)
        {
            CheckTextbox(tb_hausnummer, false);
        }

    }
}
