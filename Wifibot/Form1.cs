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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void simulateur()
        {
            System.Diagnostics.ProcessStartInfo myInfo = new System.Diagnostics.ProcessStartInfo();
            myInfo.FileName = "wifibot.exe";
            myInfo.WorkingDirectory = "C:\\Users\\TARZHULK\\Documents\\Cour\\ESIREM\\Projet Wifibot\\WifiBot\\Développement\\WifibotLabSim\\WifibotLab";
            System.Diagnostics.Process.Start(myInfo);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            simulateur();
            for (int i = 0; i < 5000; i++) { }
            
            IPAddress ip2 = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEnd2 = new IPEndPoint(ip2, 15020);
            Socket ClientSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ClientSocket2.Connect(ipEnd2);
            if (ClientSocket2.Connected)
            {
                MessageBox.Show("Connexion au simulateur ok");
                Commandes c = new Commandes(ClientSocket2,0);
                c.Show();
                
            }
            else
            {
                MessageBox.Show("Erreur, Simulateur non connecté ou erreur de connexion");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
               IPAddress ip = IPAddress.Parse("192.168.1.103");
               IPEndPoint ipEnd = new IPEndPoint(ip, 15020);
               Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

               ClientSocket.Connect(ipEnd);
               if (ClientSocket.Connected)
               {
                   MessageBox.Show("Connexion OK");
                   Commandes c = new Commandes(ClientSocket,1);
                   c.Show();
               }
               else
               {
                   MessageBox.Show("ERREUR");
               }
        }

        void SendMsg(char[] message, Socket ClientSocket)
        {
            byte[] msg = System.Text.Encoding.UTF8.GetBytes(message);
            int DtSent = ClientSocket.Send(msg, msg.Length, SocketFlags.None);
            if (DtSent == 0)
            {
                MessageBox.Show("Aucune donnée n'a été envoyé");
            }
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

    }
}