using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraProjekt
{
    //cKara Version 1.1 by Barbara Bielawski
    public partial class Zelle : UserControl
    {
        public enum Inhalt {Leer, Kara, Baum, Kleeblatt };
        public Inhalt Zellinhalt = Inhalt.Leer;
        public static Inhalt TemporärerZellinhalt { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }

        public Zelle()
        {
            InitializeComponent();
        }
        public Zelle(int posX, int posY, int groesse, Inhalt zellinhalt)
        {
            InitializeComponent();
            this.posX = posX;
            this.posY = posY;
            this.Location = new Point(posX*groesse, posY*groesse);
            this.Size = new Size(groesse, groesse);
            this.Zellinhalt = zellinhalt;
            setzeHintergrundBild();
        }
        public void setzeHintergrundBild()
        {
            switch(Zellinhalt)
            {
                case (Inhalt.Leer):
                    {
                        BackgroundImage = null;
                        break;
                    }
                case (Inhalt.Kara):
                    {
                        BackgroundImage = null;
                        break;
                    }
                case (Inhalt.Baum):
                    {
                        BackgroundImage = global::Kara.Properties.Resources.object_tree;
                        break;
                    }
                case (Inhalt.Kleeblatt):
                    {
                        BackgroundImage = global::Kara.Properties.Resources.object_leaf;
                        break;
                    }
            }
        }

        private void picInhalt_Click(object sender, EventArgs e)
        {
            Zellinhalt = TemporärerZellinhalt;
            setzeHintergrundBild();
        }
    }
}
