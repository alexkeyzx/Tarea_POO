using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proyecto_Ahora_sisi
{
    public delegate void MiDelegado(Bitmap bitmap, Rectangle bounds);
    
    class Carta
    {
        public event MiDelegado Guardado;

        private string _strNombre;

        public string strNombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private int _intx;

        public int intX
        {
            get { return _intx; }
            set { _intx = value; }
        }
        private int _intY;

        public int intY
        {
            get { return _intY; }
            set { _intY = value; }
        }
        private Size _intLimites;

        public Size intLimites
        {
            get { return _intLimites; }
            set { _intLimites = value; 
            
            }
        }


        public void guardar(Bitmap bitmap, Rectangle bounds)
        {
            bitmap = new Bitmap(bounds.Width, bounds.Height);
            int izquierda = bounds.Left + 20;
            int superior = bounds.Top + 43;
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(izquierda, superior), new Point(intX,intY), intLimites);
            bitmap.Save("C:\\Barajas\\" + strNombre + ".png", ImageFormat.Png);
            Guardado(bitmap, bounds);
        }
      

        
    }
}

