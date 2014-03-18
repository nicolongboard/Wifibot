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


        public Commandes(Socket ClientSocket)
        {
            c = ClientSocket;
            InitializeComponent();
            sens = 0;
            updateSpeed = 0;
            t1 = new System.Windows.Forms.Timer();
            InitializeTimer();
            
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
            MoveRobot(updateSpeed);
        }

        private void MoveRobot(int speed)
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

        private void Commandes_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAvancer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 1;
            updateSpeed = 63;
            InitializeTimer();
        }

        private void btnGauche_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 2;
            updateSpeed = 63;
            InitializeTimer();
        }

        private void btnDroite_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 3;
            updateSpeed = 63;
            InitializeTimer();
        }

        private void btnReculer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            sens = 4;
            updateSpeed = 0;
            InitializeTimer();
        }

        private void button1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.Text = "bite";
            }
            else if (e.Button == MouseButtons.Right)
            {
                button1.Text = "cul";
            }
            
        }

        private void btnAvancer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            t1.Stop();
            updateSpeed = 0;
        }

        private void btnDroite_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            t1.Stop();
            updateSpeed = 0;
        }

        private void btnReculer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            t1.Stop();
            updateSpeed = 0;
        }

        private void btnGauche_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            t1.Stop();
            updateSpeed = 0;
        }

  

        
      

    }
}
