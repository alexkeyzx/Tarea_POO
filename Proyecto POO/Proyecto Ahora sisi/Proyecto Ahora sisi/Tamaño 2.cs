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
    
    public partial class Tamaño_2 : Form
    {
        Carta carta = new Carta();
        public Tamaño_2()
        {
            InitializeComponent();
            carta.Guardado += MetodoGestor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //codigo nombramiento de fotos
            string[] Fotos = new string[55];
            Fotos[0] = "C:\\Barajas\\Tamaño 2\\1.jpg";
            Fotos[1] = "C:\\Barajas\\Tamaño 2\\2.jpg";
            Fotos[2] = "C:\\Barajas\\Tamaño 2\\3.jpg";
            Fotos[3] = "C:\\Barajas\\Tamaño 2\\4.jpg";
            Fotos[4] = "C:\\Barajas\\Tamaño 2\\5.jpg";
            Fotos[5] = "C:\\Barajas\\Tamaño 2\\6.jpg";
            Fotos[6] = "C:\\Barajas\\Tamaño 2\\7.jpg";
            Fotos[7] = "C:\\Barajas\\Tamaño 2\\8.jpg";
            Fotos[8] = "C:\\Barajas\\Tamaño 2\\9.jpg";
            Fotos[9] = "C:\\Barajas\\Tamaño 2\\10.jpg";
            Fotos[10] = "C:\\Barajas\\Tamaño 2\\11.jpg";
            Fotos[11] = "C:\\Barajas\\Tamaño 2\\12.jpg";
            Fotos[12] = "C:\\Barajas\\Tamaño 2\\13.jpg";
            Fotos[13] = "C:\\Barajas\\Tamaño 2\\14.jpg";
            Fotos[14] = "C:\\Barajas\\Tamaño 2\\15.jpg";
            Fotos[15] = "C:\\Barajas\\Tamaño 2\\16.jpg";
            Fotos[16] = "C:\\Barajas\\Tamaño 2\\17.jpg";
            Fotos[17] = "C:\\Barajas\\Tamaño 2\\18.jpg";
            Fotos[18] = "C:\\Barajas\\Tamaño 2\\19.jpg";
            Fotos[19] = "C:\\Barajas\\Tamaño 2\\20.jpg";
            Fotos[20] = "C:\\Barajas\\Tamaño 2\\21.jpg";
            Fotos[21] = "C:\\Barajas\\Tamaño 2\\22.jpg";
            Fotos[22] = "C:\\Barajas\\Tamaño 2\\23.jpg";
            Fotos[23] = "C:\\Barajas\\Tamaño 2\\24.jpg";
            Fotos[24] = "C:\\Barajas\\Tamaño 2\\25.jpg";
            Fotos[25] = "C:\\Barajas\\Tamaño 2\\26.jpg";
            Fotos[26] = "C:\\Barajas\\Tamaño 2\\27.jpg";
            Fotos[27] = "C:\\Barajas\\Tamaño 2\\28.jpg";
            Fotos[28] = "C:\\Barajas\\Tamaño 2\\29.jpg";
            Fotos[29] = "C:\\Barajas\\Tamaño 2\\30.jpg";
            Fotos[30] = "C:\\Barajas\\Tamaño 2\\31.jpg";
            Fotos[31] = "C:\\Barajas\\Tamaño 2\\32.jpg";
            Fotos[32] = "C:\\Barajas\\Tamaño 2\\33.jpg";
            Fotos[33] = "C:\\Barajas\\Tamaño 2\\34.jpg";
            Fotos[34] = "C:\\Barajas\\Tamaño 2\\35.jpg";
            Fotos[35] = "C:\\Barajas\\Tamaño 2\\36.jpg";
            Fotos[36] = "C:\\Barajas\\Tamaño 2\\37.jpg";
            Fotos[37] = "C:\\Barajas\\Tamaño 2\\38.jpg";
            Fotos[38] = "C:\\Barajas\\Tamaño 2\\39.jpg";
            Fotos[39] = "C:\\Barajas\\Tamaño 2\\40.jpg";
            Fotos[40] = "C:\\Barajas\\Tamaño 2\\41.jpg";
            Fotos[41] = "C:\\Barajas\\Tamaño 2\\42.jpg";
            Fotos[42] = "C:\\Barajas\\Tamaño 2\\43.jpg";
            Fotos[43] = "C:\\Barajas\\Tamaño 2\\44.jpg";
            Fotos[44] = "C:\\Barajas\\Tamaño 2\\45.jpg";
            Fotos[45] = "C:\\Barajas\\Tamaño 2\\46.jpg";
            Fotos[46] = "C:\\Barajas\\Tamaño 2\\47.jpg";
            Fotos[47] = "C:\\Barajas\\Tamaño 2\\48.jpg";
            Fotos[48] = "C:\\Barajas\\Tamaño 2\\49.jpg";
            Fotos[49] = "C:\\Barajas\\Tamaño 2\\50.jpg";
            Fotos[50] = "C:\\Barajas\\Tamaño 2\\51.jpg";
            Fotos[51] = "C:\\Barajas\\Tamaño 2\\52.jpg";
            Fotos[52] = "C:\\Barajas\\Tamaño 2\\53.jpg";
            Fotos[53] = "C:\\Barajas\\Tamaño 2\\54.jpg";

          
                //codigo cambiar imagenes
                Random random = new Random();
                int[] numeros = new int[16];
                numeros[0] = -2;
                numeros[1] = -2;
                numeros[2] = -2;
                numeros[3] = -2;
                numeros[4] = -2;
                numeros[5] = -2;
                numeros[6] = -2;
                numeros[7] = -2;
                numeros[8] = -2;
                numeros[9] = -2;
                numeros[10] = -2;
                numeros[11] = -2;
                numeros[12] = -2;
                numeros[13] = -2;
                numeros[14] = -2;
                numeros[15] = -2;


                for (int i = 0; i < 16; i++)
                {
                    int n = random.Next(0, 54);
                    //evita que se repitan fotos


                    //generar(1) from[matriz principal]
                    //genera el 45, entonces//  put(44),(46) on[matriz relevo]

                    //generar(1) from[matriz principal]
                    //genera el 2, entonces// put(1),(3) on[matriz relevo]
                    int na, nb;
                    na = n + 1;
                    nb = n - 1;
                    if (numeros.Contains(n) == !true)
                    {

                        if (numeros.Contains(na) == true || numeros.Contains(nb) == true)
                        {
                            i--;
                            continue;
                        }
                       
                        numeros[i] = n;
                        continue;
                    }
                    else
                    {
                        i--;
                    }


                }

                Image image = Image.FromFile(Fotos[numeros[0]]);
                pictureBox1.Image = image;
                image = Image.FromFile(Fotos[numeros[1]]);
                pictureBox2.Image = image;
                image = Image.FromFile(Fotos[numeros[2]]);
                pictureBox3.Image = image;
                image = Image.FromFile(Fotos[numeros[3]]);
                pictureBox4.Image = image;
                image = Image.FromFile(Fotos[numeros[4]]);
                pictureBox5.Image = image;
                image = Image.FromFile(Fotos[numeros[5]]);
                pictureBox6.Image = image;
                image = Image.FromFile(Fotos[numeros[6]]);
                pictureBox7.Image = image;
                image = Image.FromFile(Fotos[numeros[7]]);
                pictureBox8.Image = image;
                image = Image.FromFile(Fotos[numeros[8]]);
                pictureBox9.Image = image;
                image = Image.FromFile(Fotos[numeros[9]]);
                pictureBox10.Image = image;
                image = Image.FromFile(Fotos[numeros[10]]);
                pictureBox11.Image = image;
                image = Image.FromFile(Fotos[numeros[11]]);
                pictureBox12.Image = image;
                image = Image.FromFile(Fotos[numeros[12]]);
                pictureBox13.Image = image;
                image = Image.FromFile(Fotos[numeros[13]]);
                pictureBox14.Image = image;
                image = Image.FromFile(Fotos[numeros[14]]);
                pictureBox15.Image = image;
                image = Image.FromFile(Fotos[numeros[15]]);
                pictureBox16.Image = image;

            
        }
       
      
    
        private void Foto_Click(object sender, EventArgs e)
        {
            carta.intLimites = pictureBox17.Size;
            carta.strNombre = txtNombre.Text;
            carta.intX = pictureBox17.Bounds.X;
            carta.intY = pictureBox17.Bounds.Y;
            Rectangle bounds = this.Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            
            carta.guardar(bitmap, bounds);
            
            //carta.guardar(bitmap,bounds);


        }
        public void MetodoGestor(Bitmap bitmap, Rectangle bounds)
        {
            MessageBox.Show("Se termino de almacenar el documento en: C:\\Barajas");
        }
    }
    }

