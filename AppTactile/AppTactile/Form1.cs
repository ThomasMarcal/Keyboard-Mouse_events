using GlobalHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTactile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Obtenir la position de la souris par rapport au formulaire
            Point mousePosition = this.PointToClient(Control.MousePosition);

            // Afficher la position de la souris dans la barre de titre du formulaire
            Debug.WriteLine($"Position de la souris : X={mousePosition.X}, Y={mousePosition.Y}");

        }
    }
}


