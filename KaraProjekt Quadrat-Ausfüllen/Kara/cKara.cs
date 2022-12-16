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
    public partial class cKara : PictureBox
    {
        public static bool KaraExist { set; get; }
        //Die Richtungen entsprechen den Gradangaben der Himmelsrichtungen
        //Nord=0 Ost=90 Süd=10 West=270
        public int RichtungKara { get; set; }
        public int posY { get; set; }
        public int posX { get; set; }
        public int posYFront { get; set; }
        public int posXFront { get; set; }
        public int posYRight { get; set; }
        public int posXRight { get; set; }
        public int posYLeft { get; set; }
        public int posXLeft { get; set; }
        //Grösse des Feldes, in dem Kara unterwegs ist
        public static int feldgroesse { get; set; }

        public cKara()
        {
            //InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
        }
        public cKara(int posX, int posY, int groesse)
        {
            //InitializeComponent();
            cKara.KaraExist = true;
            this.posY = posY;
            this.posX = posX;

            //Positionen Front, Rechts, Links setzen
            SetzeUmgebungspositionen();
            this.Location = new Point(0, 0);
            this.BackColor = System.Drawing.Color.Transparent;
            this.RichtungKara = 0;
            SetzeBild();

       }

        public void cMove()
        {
            switch(RichtungKara)
            {
                case 90:
                    {
                        posY += 1;
                        break;
                    }
                case 180:
                    {
                        posX += 1;
                        break;
                    }
                case 270:
                    {
                        posY -= 1;
                        break;
                    }
                case 0:
                    {
                        posX -= 1;
                        break;
                    }
            }
            if (posX == -1 && RichtungKara == 0) posX = feldgroesse - 1;
            if (posX == feldgroesse && RichtungKara == 180) posX = 0;
            if (posY == -1 && RichtungKara == 270) posY = feldgroesse - 1;
            if (posY == feldgroesse && RichtungKara == 90) posY = 0;
            SetzeUmgebungspositionen();
        }

        public void TurnLeft()
        {
            RichtungKara = (RichtungKara - 90 + 360) % 360;
            SetzeBild();
            SetzeUmgebungspositionen();
        }
        public void TurnRight()
        {
            RichtungKara = (RichtungKara + 90) % 360;
            SetzeBild();
            SetzeUmgebungspositionen();
        }


        public void SetzeBild()
        {
            if (RichtungKara==0) Image = global::Kara.Properties.Resources.bugnorth_r;
            if (RichtungKara == 90) Image = global::Kara.Properties.Resources.bugeast_r;
            if (RichtungKara == 180) Image = global::Kara.Properties.Resources.bugsouth_r;
            if (RichtungKara == 270) Image = global::Kara.Properties.Resources.bugwest_r;
        }

        public void SetzeUmgebungspositionen()
        {
            switch (RichtungKara)
            {
                case 0:
                    {
                        posXFront = (this.posX - 1 + feldgroesse) % feldgroesse;
                        posYFront = (this.posY);
                        posXRight = (this.posX);
                        posYRight = (this.posY + 1) % feldgroesse;
                        posXLeft = (this.posX);
                        posYLeft = (this.posY - 1 + feldgroesse) % feldgroesse;
                        break;
                    }
                case 90:
                    {
                        posXFront = (this.posX);
                        posYFront = (this.posY+1) % feldgroesse;
                        posXRight = (this.posX+1) % feldgroesse;
                        posYRight = (this.posY);
                        posXLeft = (this.posX - 1 + feldgroesse) % feldgroesse;
                        posYLeft = (this.posY);
                        break;
                    }
                case 180:
                    {
                        posXFront = (this.posX +1) % feldgroesse;
                        posYFront = (this.posY);
                        posXRight = (this.posX);
                        posYRight = (this.posY - 1 + feldgroesse) % feldgroesse;
                        posXLeft = (this.posX);
                        posYLeft = (this.posY +1) % feldgroesse;
                        break;
                    }
                case 270:
                    {
                        posXFront = (this.posX);
                        posYFront = (this.posY - 1 + feldgroesse) % feldgroesse;
                        posXRight = (this.posX - 1 + feldgroesse) % feldgroesse;
                        posYRight = (this.posY);
                        posXLeft = (this.posX +1) % feldgroesse;
                        posYLeft = (this.posY);
                        break;
                    }

            }


        }
    }
}
