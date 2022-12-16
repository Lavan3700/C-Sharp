using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;

namespace KaraProjekt
{
    //cKara Version 1.1 by Barbara Bielawski
    public partial class KaraWorld : UserControl
    {
        Zelle[,] world;
        int groesse, zellengroesse = 30;
        int spalte, zeile;
        int geschschwindigkeit = 500;
        cKara ckara=null;
        List<Zelle.Inhalt> worldList = new List<Zelle.Inhalt>();

        public KaraWorld()
        {
            InitializeComponent();
            groesse = 15;
            cKara.feldgroesse = groesse;
            for(int i=0;i<groesse*groesse;i++)
            {
                worldList.Add(Zelle.Inhalt.Leer);
            }
            ErstelleWorld();
            lstZellinhalt.SelectedIndex = 0;
       }

        private void ErstelleWorld()
        {
            pnlWorld.Size = new Size(groesse * zellengroesse, groesse * zellengroesse);
            world = new Zelle[groesse, groesse];
            if (cKara.KaraExist == false)
            {
                ckara = new cKara(5,5, zellengroesse);
            }
            for (int i = 0; i < groesse; i++)
            {
                for (int j = 0; j < groesse; j++)
                {
                    world[i, j] = new Zelle(i , j , zellengroesse,worldList[i*groesse+j]);
                    if (i == ckara.posY && j == ckara.posX)
                    {
                        world[i, j].Controls.Add(ckara);
                        world[i, j].BackColor = Color.Transparent;
                    }
                    this.pnlWorld.Controls.Add(world[i, j]);
                }
            }
        }

        private void LoescheWorld()
        {
            ckara = null;
            cKara.KaraExist = false;
            world = null;
        }

        private void lstZellinhalt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zelle.TemporärerZellinhalt = Zelle.Inhalt.Leer;
            switch (lstZellinhalt.SelectedIndex)
            {
                case 0: Zelle.TemporärerZellinhalt = Zelle.Inhalt.Leer; break;
                case 1: Zelle.TemporärerZellinhalt = Zelle.Inhalt.Baum; break;
                case 2: Zelle.TemporärerZellinhalt = Zelle.Inhalt.Kleeblatt; break;
            }
        }

        private void btnPositioniere_Click(object sender, EventArgs e)
        {
            try
            {
                zeile = Convert.ToInt32(txtZeile.Text) - 1;
                if (zeile < 0)
                {
                    zeile = 0;
                    txtZeile.Text = "1";
                }
                if (zeile > groesse - 1)
                {
                    zeile = groesse - 1;
                    txtZeile.Text = Convert.ToString(groesse);
                }
                spalte = Convert.ToInt32(txtSpalte.Text) - 1;
                if (spalte < 0)
                {
                    spalte = 0;
                    txtSpalte.Text = "1";
                }
                if (spalte > groesse - 1)
                {
                    spalte = groesse - 1;
                    txtSpalte.Text = Convert.ToString(groesse);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Die Textbox muss Zahlen enthalten");
            }

            if (world[spalte, zeile].Zellinhalt != Zelle.Inhalt.Baum )
                        {
                            for (int i = 0; i < groesse; i++)
                                {
                                    for (int j = 0; j < groesse; j++)
                                    {
                                        if (world[i, j].Zellinhalt == Zelle.Inhalt.Kara)
                                        {
                                            world[i, j].Zellinhalt = Zelle.Inhalt.Leer;
                                            world[i, j].setzeHintergrundBild(); 
                                        }
                                    }
                                }
                            world[spalte, zeile].Controls.Add(ckara);
                            ckara.posX = zeile;
                            ckara.posY = spalte;
                            ckara.SetzeUmgebungspositionen();
                        }
            world[spalte, zeile].setzeHintergrundBild();
            this.ResumeLayout(false);
        }

        private void btnDrehe_Click(object sender, EventArgs e)
        {
            TurnRight();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Move();
        }

        private void rdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNormal.Checked) geschschwindigkeit = 500;
            if (rdbSchnell.Checked) geschschwindigkeit = 200;
            if (rdbSuperSchnell.Checked) geschschwindigkeit = 50;
        }

        private void rdbSchnell_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNormal.Checked) geschschwindigkeit = 500;
            if (rdbSchnell.Checked) geschschwindigkeit = 200;
            if (rdbSuperSchnell.Checked) geschschwindigkeit = 50;
        }

        #region World Speichern und Laden
        private void btnSpeicherWorld_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            worldList.Clear();
            foreach (Zelle w in world)
            {
                worldList.Add(w.Zellinhalt);
            }
            saveFileDialog.Filter = "Text|*.txt";
            saveFileDialog.Title = "Eine Kara-World speichern";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream stream;
                stream = new System.IO.FileStream(saveFileDialog.FileName, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, worldList);
                stream.Close();
                using (StreamWriter sw = File.AppendText(saveFileDialog.FileName))
                {
                    sw.WriteLine();
                    sw.WriteLine(ckara.posX + " " + ckara.posY + " " + ckara.RichtungKara);
                    sw.Close();
                }
            }
        }

        private void btnLadeWorld_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath))\UserWorlds";
            openFileDialog.Title = "Eine Kara-World öffnen";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open); ;
                    BinaryFormatter formatter = new BinaryFormatter();
                    worldList = (List<Zelle.Inhalt>)formatter.Deserialize(fs);
                    LoescheWorld();
                    pnlWorld.Controls.Clear();
                    ErstelleWorld();
                    fs.Close();
                    using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                    {
                        string s = "";
                        string[] pos = null;
                        while ((s = sr.ReadLine()) != null) pos = s.Split(' ');
                        txtZeile.Text = Convert.ToString(Convert.ToInt32(pos[0]) + 1);
                        txtSpalte.Text = Convert.ToString(Convert.ToInt32(pos[1]) + 1);
                        int nKaraAusrichtung = 0;
                        if(pos.Length>2 && Int32.TryParse(pos[2], out nKaraAusrichtung))
                        {
                            ckara.RichtungKara = nKaraAusrichtung;
                            ckara.SetzeBild();
                        }
                        btnPositioniere_Click(btnPositioniere, e);
                    }

                }
                catch (SerializationException exc)
                {
                    // die Datei kann nicht deserialisiert werden
                    Console.WriteLine(exc.Message);
                }
                catch (IOException exc)
                {
                    // Beim Versuch, die Datei zu öffnen, ist ein Fehler aufgetreten.
                    Console.WriteLine(exc.Message);
                }
                pnlWorld.Refresh();
            }
        }

        #endregion
        
        #region Kara-Methoden
        public new void Move()
        {
            if (!TreeFront())
            {
                ckara.cMove();
                world[ckara.posY, ckara.posX].Controls.Add(ckara);
                this.Refresh();
                System.Threading.Thread.Sleep(geschschwindigkeit);
            }
            else
            {
                MessageBox.Show("Achtung Baum!!!");
            }
        }

        public void TurnRight()
        {
            ckara.TurnRight();
            this.Refresh();
            System.Threading.Thread.Sleep(geschschwindigkeit);
        }
        public void TurnLeft()
        {
            ckara.TurnLeft();
            this.Refresh();
            System.Threading.Thread.Sleep(geschschwindigkeit);
        }

        public bool TreeFront()
        {
            int zeileBaum = ckara.posXFront;
            int spalteBaum = ckara.posYFront;
            if (world[spalteBaum, zeileBaum].Zellinhalt == Zelle.Inhalt.Baum)
            {
                return true;
            }
            else return false;
        }
        public bool TreeRight()
        {
            int zeileBaum = ckara.posXRight;
            int spalteBaum = ckara.posYRight;
            if (world[spalteBaum, zeileBaum].Zellinhalt == Zelle.Inhalt.Baum)
            {
                return true;
            }
            else return false;
        }
        public bool TreeLeft()
        {
            int zeileBaum = ckara.posXLeft;
            int spalteBaum = ckara.posYLeft;
            if (world[spalteBaum, zeileBaum].Zellinhalt == Zelle.Inhalt.Baum)
            {
                return true;
            }
            else return false;
        }
        public bool OnLeaf()
        {
            int zeileBlatt = ckara.posX;
            int spalteBlatt = ckara.posY;
            if (world[spalteBlatt, zeileBlatt].Zellinhalt == Zelle.Inhalt.Kleeblatt)
            {
                return true;
            }
            else return false;
        }


        public void PutLeaf()
        {
            int zeileBlatt = ckara.posX;
            int spalteBlatt = ckara.posY;
            if (world[spalteBlatt, zeileBlatt].Zellinhalt == Zelle.Inhalt.Leer)
            {
                world[spalteBlatt, zeileBlatt].Zellinhalt = Zelle.Inhalt.Kleeblatt;
                world[spalteBlatt, zeileBlatt].setzeHintergrundBild();
                this.Refresh();
                System.Threading.Thread.Sleep(geschschwindigkeit);
            }
            else MessageBox.Show("Da liegt schon ein Blatt");
        }
        public void RemoveLeaf()
        {
            int zeileBlatt = ckara.posX;
            int spalteBlatt = ckara.posY;
            if (world[spalteBlatt, zeileBlatt].Zellinhalt == Zelle.Inhalt.Kleeblatt)
            {
                world[spalteBlatt, zeileBlatt].Zellinhalt = Zelle.Inhalt.Leer;
                world[spalteBlatt, zeileBlatt].setzeHintergrundBild();
                this.Refresh();
                System.Threading.Thread.Sleep(geschschwindigkeit);
            }
            else MessageBox.Show("Da liegt gar kein Blatt");
        } 
        #endregion
    }
}
