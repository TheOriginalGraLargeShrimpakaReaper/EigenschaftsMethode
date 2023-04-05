using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenschaftsMethode
{
    /// <summary>
    /// Klasse CFahrzeug$
    /// Erbt vom Klasse Form
    /// </summary>
    public partial class CFahrzeugDlg : Form
    {
        CFahrzeug Fahrzeug = new CFahrzeug();

        /// <summary>
        /// CFahrzeug Konstruktor
        /// </summary>
        public CFahrzeugDlg()
        {
            InitializeComponent();

            //  Am Anfang steht das Auto, bremsen verhindern
            if (Fahrzeug.Geschwindigkeit <= 0)
            {
                btoLangsamer.Enabled = false;
            }
        }

        /// <summary>
        /// Setzen der Eigenschaften in der Klasse CFahrzeug
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoEigenschaftenSetzen_Click(object sender, EventArgs e)
        {
            //  Werte abholen
            (bool bCheck, int intHubraum) = getFeldValueInt(txtHubraum);
            if (!bCheck)
            {
                return;
            }
            (bool bCkeck, int intPassagiere) = getFeldValueInt(txtPassagiere);
            if (!bCheck)
            {
                return;
            }
            (bool bIsCkeck, double dblKmStand) = getFeldValueDouble(txtKmStand);
            if (!bCheck)
            {
                return;
            }

            //  Eigenschaften setzen
            Fahrzeug.Hubraum = intHubraum;
            Fahrzeug.Passagiere = intPassagiere;
            Fahrzeug.KmStand = dblKmStand;
        }

        /// <summary>
        /// Werte Anzeigen
        /// Via Klasse CFahrzeug.Ausgabe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoAnzeigen_Click(object sender, EventArgs e)
        {
            string strAusgabe = Fahrzeug.Ausgabe();
            setAusgabe(lblAnzeige, strAusgabe);
        }

        /// <summary>
        /// Geschwindigkeit erhöhen via Methode CFahrzeug.beschleunigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoSchneller_Click(object sender, EventArgs e)
        {
            Fahrzeug.beschleunigen(20);
            string strAusgabe = Fahrzeug.Ausgabe();
            setAusgabe(lblAnzeige, strAusgabe);

            //  Wenn wieder Speed vorhanden, bremsen freigeben
            if(Fahrzeug.Geschwindigkeit > 0)
            {
                btoLangsamer.Enabled = true;
            }
        }

        /// <summary>
        /// Geschwindigkeit erhöhen via Methode CFahrzeug.bremsen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btoLangsamer_Click(object sender, EventArgs e)
        {
            string strGeschwindigkeit = Fahrzeug.bremsen(10);
            string strAusgabe = Fahrzeug.Ausgabe();
            setAusgabe(lblAnzeige, strAusgabe);

            //  Wenn Speed 0, Bremsen verhindern
            if(Fahrzeug.Geschwindigkeit <= 0)
            {
                btoLangsamer.Enabled = false;
            }
        }

        /// <summary>
        /// Versucht String von Übergebenen TextFeld in ein Double zu Parsen.
        /// Gibt das Resultat des Parsings sowie den geparseten Wert zurück
        /// </summary>
        /// <param name="objTextBox"></param>
        /// <returns></returns>
        public (bool bCheckbCheck, double dblReturn) getFeldValueDouble(TextBox objTextBox)
        {
            bool bChecked = Double.TryParse(objTextBox.Text, out double dblReturn);
            return (bChecked, dblReturn);
        }

        /// <summary>
        /// Versucht String von Übergebenen TextFeld in ein Integer zu Parsen.
        /// Gibt das Resultat des Parsings sowie den geparseten Wert zurück
        /// </summary>
        /// <param name="objTextBox"></param>
        /// <returns></returns>
        public (bool bCheckbCheck, int intReturn) getFeldValueInt(TextBox objTextBox)
        {
            bool bChecked = int.TryParse(objTextBox.Text, out int intReturn);
            return (bChecked, intReturn);
        }

        /// <summary>
        /// Schreibt die übergebene Ausgabe in das übergebene Label
        /// </summary>
        /// <param name="objLabel"></param>
        /// <param name="strAusgabe"></param>
        private void setAusgabe(Label objLabel, string strAusgabe)
        {
            objLabel.Text = strAusgabe;
        }


    }
}
