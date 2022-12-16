using System.Windows.Forms;

namespace KaraProjekt
{
    //cKara Version 1.1 by Barbara Bielawski
    public partial class Form1 : Form
    {
        private void Main(string args)
        {
            //Hier die Anweisungen notieren
            DrawSquare(5);

            //Programmende: nächste Zeile bitte nicht löschen
            MessageBox.Show("Programmcode ausgeführt!");
        }

        void DrawSquare(int seitenlaenge)
        {
            for (int i = 0; 1 < seitenlaenge; i++)
            {
                Putx(seitenlaenge);
                kara.TurnRight();
                Putx(seitenlaenge);
                kara.TurnRight();
                Putx(seitenlaenge);
                kara.TurnRight();
                seitenlaenge--;
            }
        }

        public void KaraBewegen() 
        {
            while (true) { 
                
               if (!kara.TreeFront()) 
            {
                if (kara.OnLeaf()) 
                {
                    kara.RemoveLeaf();
                    kara.Move();
                }
                else
                {
                    kara.Move();
                }
            }
            else
            {
                if (kara.OnLeaf())
                {
                    kara.RemoveLeaf();
                    Turn180();
                        break;
                }
            }
            }
        }

        void Turn180() // Methode 1, Kara dreht um 180 Grad.
        {
            kara.TurnLeft();
            kara.TurnLeft();
        }

        void Putx(int anzahl)  // Methode 2, Blätter und bewegt sich
        {
            for (int i = 0; i < anzahl; i++)
            {
                kara.PutLeaf();
                kara.Move();
            }
        }

        void MoveX(int anzahl) 
        {
            for (int i = 0; i < anzahl; i++) 
            {
                kara.Move();
            }
        }
        private void AvoidTree()
        {
            kara.TurnLeft();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.Move();
            kara.TurnRight();
            kara.Move();
            kara.TurnLeft();
        }

        //Hier können Sie eigene Methoden einfügen

    }
}
