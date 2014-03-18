using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;



namespace Wifibot
{
    public partial class Commandes : Form
    {
        private Socket c;
        private System.Windows.Forms.Timer t1;
        private int sens;
        private int updateSpeed;


        public Commandes(Socket ClientSocket, int application)
        {
            if (application == 1)
            {
                c = ClientSocket;
                InitializeComponent();
                sens = 0;
                t1 = new System.Windows.Forms.Timer();
                InitializeTimer();
            }
            else if (application == 0)
            {
                c = ClientSocket;
                InitializeComponent();
                sens = 0;
                t1 = new System.Windows.Forms.Timer();
                InitializeTimer();
            }
        }

        private void InitializeTimer()
        {
            t1.Interval = 200;
            t1.Tick += new EventHandler(this.Tick);
            t1.Enabled = true;
        }

        private void Tick(object sender, EventArgs e)
        {
            updateSpeed += 8;

            //MoveRobotSim();
            MoveRobot();
        }

        private void MoveRobotSim()
        {
            byte[] message2 = new byte[2];
            switch(sens)
            {   
                case 1: //Avancer
                        message2[0] = 127; //Roue de gauche
                        message2[1] = 127; //Roue de droite
                        c.Send(message2);
                    break;
                case 2: //A gauche
                        message2[0] = 0; //Roue de gauche
                        message2[1] = 127; //Roue de droite
                        c.Send(message2);
                    break;
                case 3://A droite
                        message2[0] = 127; //Roue de gauche
                        message2[1] = 0; //Roue de droite
                        c.Send(message2);
                    break;
                case 4: //Reculer
                    /*if (speed >= 63)
                        speed = 63;
                    else
                    {*/
                        message2[0] = 63; //Roue de gauche
                        message2[1] = 63; //Roue de droite
                        c.Send(message2);
                    //}
                    break;
                default:
                        message2[0] = 0; //Roue de gauche
                        message2[1] = 0; //Roue de droite
                        c.Send(message2);
                    break;
            }
        }
        private void MoveRobot()
        {
            byte[] message = new byte[9];
            byte[] tmp = new byte[6];
            int crcResult;
            switch (sens)
            {
                  
                case 1: //Avancer
                   message[0] = 255;
                   message[1] = 0x07;
                   message[2] = 120;
                   message[3] = 0;
                   message[4] = 120;
                   message[5] = 0;
                   message[6] = 80;

                   tmp[0] = 0x07;
                   tmp[1] = 120;
                   tmp[2] = 0;
                   tmp[3] = 120;
                   tmp[4] = 0;
                   tmp[5] = 80;

                   crcResult = Crc16(tmp);

                   message[7] = (byte)crcResult;
                   message[8] = (byte)(crcResult >> 8);
                   c.Send(message);
                   break;

                case 2: //A gauche
                   message[0] = 255;
                   message[1] = 0x07;
                   message[2] = 80;
                   message[3] = 0;
                   message[4] = 120;
                   message[5] = 0;
                   message[6] = 80;

                   
                   tmp[0] = 0x07;
                   tmp[1] = 80;
                   tmp[2] = 0;
                   tmp[3] = 120;
                   tmp[4] = 0;
                   tmp[5] = 80;

                   crcResult = Crc16(tmp);

                   message[7] = (byte)crcResult;
                   message[8] = (byte)(crcResult >> 8);
                   c.Send(message);
                   break;

                case 3://A droite
                   message[0] = 255;
                   message[1] = 0x07;
                   message[2] = 120;
                   message[3] = 0;
                   message[4] = 80;
                   message[5] = 0;
                   message[6] = 80;

                   
                   tmp[0] = 0x07;
                   tmp[1] = 120;
                   tmp[2] = 0;
                   tmp[3] = 80;
                   tmp[4] = 0;
                   tmp[5] = 80;

                   crcResult = Crc16(tmp);

                   message[7] = (byte)crcResult;
                   message[8] = (byte)(crcResult >> 8);
                   c.Send(message);
                   break;
                case 4: //Reculer
                   message[0] = 255;
                   message[1] = 0x07;
                   message[2] = 120;
                   message[3] = 0;
                   message[4] = 120;
                   message[5] = 0;
                   message[6] = 0;

                   
                   tmp[0] = 0x07;
                   tmp[1] = 120;
                   tmp[2] = 0;
                   tmp[3] = 120;
                   tmp[4] = 0;
                   tmp[5] = 0;

                   crcResult = Crc16(tmp);

                   message[7] = (byte)crcResult;
                   message[8] = (byte)(crcResult >> 8);
                   c.Send(message);
                    //}
                    break;
                default:
                   message[0] = 255;
                   message[1] = 0x07;
                   message[2] = 0;
                   message[3] = 0;
                   message[4] = 0;
                   message[5] = 0;
                   message[6] = 0;

                   
                   tmp[0] = 0x07;
                   tmp[1] = 0;
                   tmp[2] = 0;
                   tmp[3] = 0;
                   tmp[4] = 0;
                   tmp[5] = 0;

                   crcResult = Crc16(tmp);

                   message[7] = (byte)crcResult;
                   message[8] = (byte)(crcResult >> 8);
                   c.Send(message);
                    break;
            }
        }


        private void Commandes_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAvancer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 1;
        }

        private void btnGauche_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 2;
        }

        private void btnDroite_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 3;
        }

        private void btnReculer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 4;
        }

        private void btnAvancer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 0;
        }

        private void btnDroite_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 0;
        }

        private void btnReculer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 0;
        }

        private void btnGauche_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 0;
        }

        int Crc16(byte[] Adresse_tab)
        {
            int Crc = 0xFFFF;
            int CptOctet;
            int CptBit = 0;
            int Taille_max = Adresse_tab.Length;

            for (CptOctet = 0; CptOctet < Taille_max; CptOctet++)
            {
                Crc ^= Adresse_tab[CptOctet];
                for (CptBit = 0; CptBit < 8; CptBit++)
                {
                    if (Crc % 2 != 0)
                    {
                        Crc = (Crc >> 1) ^ 0xA001;

                    }
                    else
                    {
                        Crc = (Crc >> 1);
                    }

                }
            }
            return (Crc);
        }

        private void Commandes_FormClosing(object sender, FormClosingEventArgs e)
        {
            t1.Dispose();
            c.Close();
            this.Dispose();
        }

    }
}
