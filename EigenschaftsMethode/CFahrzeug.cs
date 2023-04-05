using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EigenschaftsMethode
{
    /// <summary>
    /// 
    /// </summary>
    public class CFahrzeug
    {
        private double m_dblKmStand;
        private int m_intGeschwindigkeit;
        private int m_intHubraum;
        private int m_intPassagiere;

        /// <summary>
        /// 
        /// </summary>
        public int Geschwindigkeit
        {
            get
            {
                return m_intGeschwindigkeit;
            }
            set
            {
                m_intGeschwindigkeit = value;
                //if(m_intGeschwindigkeit < 0)
                //{
                //    m_intGeschwindigkeit =  0;
                //}
            }
        }

        /// <summary>
        /// Eigenschaft Hubraum mit getter / setter
        /// </summary>
        public int Hubraum
        {
            get
            {
                return m_intHubraum;
            }
            set
            {
                m_intHubraum = value;
            }
        }

        /// <summary>
        /// Eigenschaft KmStand mit getter / setter
        /// </summary>
        public double KmStand
        {
            get
            {
                return m_dblKmStand;
            }
            set
            {
                m_dblKmStand = value;
            }
        }

        /// <summary>
        /// Eigenschaft Passagiere mit getter / setter
        /// </summary>
        public int Passagiere
        {
            get
            {
                return m_intPassagiere;
            }
            set
            {
                m_intPassagiere = value;
            }
        }

        /// <summary>
        /// Methode Ausgabe, die Felder in einen String zusammenfasst
        /// </summary>
        /// <returns></returns>
        public string Ausgabe()
        {
            //throw new System.NotImplementedException();
            string strAusgabe = "";
            string strGeschwindigkeit = m_intGeschwindigkeit.ToString();
            string strHubraum = m_intHubraum.ToString();
            string strPassagiere = m_intPassagiere.ToString();
            string strKmStand = m_dblKmStand.ToString("0.00");

            strAusgabe += "Geschwindigkeit: " + strGeschwindigkeit + "\n";
            strAusgabe += "Hubraum: " + strHubraum + "\n";
            strAusgabe += "Passagiere: " + strPassagiere + "\n";
            strAusgabe += "Km Stand: " + strKmStand + "\n";
            return strAusgabe;
        }

        /// <summary>
        /// Methode beschleunigen
        /// Erhöht das Feld m_intGeschwindigkeit via setter um den übergebenen Wert
        /// </summary>
        /// <param name="intWert"></param>
        public void beschleunigen(int intWert)
        {
            //throw new System.NotImplementedException();
            Geschwindigkeit += intWert;
        }

        /// <summary>
        /// Reduziert den Wert des Feldes m_intGeschwindigkeit via setter um den übergebenen Wert
        /// </summary>
        /// <param name="wert"></param>
        /// <returns></returns>
        public string bremsen(int wert)
        {
            //throw new System.NotImplementedException();
            Geschwindigkeit -= wert;

            string strGeschwindigkeit = Geschwindigkeit.ToString();
            return strGeschwindigkeit;
        }
    }
}