using System;

namespace Robota
{
    class Robotnicy
    {

       
        public Robotnicy(string[] robotaKtoraTrzebaWykonac)
        {
            this.robotyKtoreMogeRobic = robotaKtoraTrzebaWykonac;
        }
        private string aktualnaRobota = "";
        public string AktualnaRobota { get { return aktualnaRobota; } }
        public int IleJeszczeZmianZostalo
        {
            get
            {
                return zmianyDoPrzepracowania - zmianyPrzepracowane;
            }
        }

        private string[] robotyKtoreMogeRobic;
        private int zmianyDoPrzepracowania;
        private int zmianyPrzepracowane;

        public bool WykonajPrace(string praca, int liczbaZmian)
        {
            if (!String.IsNullOrEmpty(aktualnaRobota))
                return false;
            for (int i = 0; i < robotyKtoreMogeRobic.Length; i++)
                if (robotyKtoreMogeRobic[i] == praca)
                {
                    aktualnaRobota = praca;
                    zmianyDoPrzepracowania = liczbaZmian;
                    zmianyPrzepracowane = 0;
                    return true;

                }
            return false;
        }

        public bool CzySkonczyl()
        {
            if (string.IsNullOrEmpty(aktualnaRobota))
                return false;
            zmianyPrzepracowane++;
            if (zmianyPrzepracowane > zmianyDoPrzepracowania)
            {
                zmianyPrzepracowane = 0;
                zmianyDoPrzepracowania = 0;
                aktualnaRobota = "";
                return true;
            }
            else
                return false;
        }
    }
}
