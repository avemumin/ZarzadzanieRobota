using System;

namespace Robota
{
    class Majster
    {
        private Robotnicy[] robotnik;
        public Majster(Robotnicy[] robot)
        {
            robotnik = robot;
        }
        private int LiczbaZmian = 0;

        public bool ZlecPrace(string praca, int liczbaZmian)
        {
            for (int i = 0; i < robotnik.Length; i++)
                if (robotnik[i].WykonajPrace(praca, liczbaZmian))
                    return true;
            return false;

        }

        public string PrzepracujKolejnaZmiane()
        {
            LiczbaZmian++;
            string raport = "Raport zmiany numer" + LiczbaZmian + "\r\n";
            for (int i = 0; i < robotnik.Length; i++)
            {
                if (robotnik[i].CzySkonczyl())
                    raport += "Robotnik numer " + (i + 1) + " zakonczyl swoje zadanie \r\n";
                if (String.IsNullOrEmpty(robotnik[i].AktualnaRobota))
                    raport += "Robotnik numer " + (i + 1) + "nie pracuje\r\n";
                else
                    if (robotnik[i].IleJeszczeZmianZostalo > 0)
                        raport += "Robotnik numer " + (i + 1) + " robi " + robotnik[i].AktualnaRobota + "jeszcze przez " +
                            robotnik[i].IleJeszczeZmianZostalo + " zmiany \r\n";
                    else
                        raport += "Robotnica numer " + (i + 1) + " zakonczy " + robotnik[i].AktualnaRobota + " po tej zmianie \r\n";              
            }
            return raport;
        }
    }
}
