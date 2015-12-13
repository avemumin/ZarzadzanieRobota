using System;
using System.Windows.Forms;

namespace Robota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            robotaDoWykonania.SelectedIndex = 0;
            Robotnicy[] rob = new Robotnicy[5];
            rob[0] = new Robotnicy(new string[] { "Młotkowy","Wiertarkowy" });
            rob[1] = new Robotnicy(new string[] { "Spawacz" });
            rob[2] = new Robotnicy(new string[] { "Ślusarz" });
            rob[3] = new Robotnicy(new string[] { "Opierdalacz" });
            rob[4] = new Robotnicy(new string[] { "Wiertarkowy" });
            miszczu = new Majster(rob);
        }
        private Majster miszczu;
        private void przypiszPrace_Click(object sender, EventArgs e)
        {
            miszczu.ZlecPrace(robotaDoWykonania.Text, (int)liczbaZmian.Value);

        }

        private void przepracujKolejnaZmiane_Click(object sender, EventArgs e)
        {
            raport.Text = miszczu.PrzepracujKolejnaZmiane();
        }
    }
}
