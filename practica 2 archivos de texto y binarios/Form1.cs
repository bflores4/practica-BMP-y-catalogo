using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace practica_2_archivos_de_texto_y_binarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string URL;
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            Stream imagen = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
           
            openFileDialog1.Filter = "Archivos BMP (*.BMP) | *.BMP| All files(*.*) | *.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((imagen = openFileDialog1.OpenFile()) != null)
                    {
                        using (imagen)
                        {
                            BinaryReader br = new BinaryReader(imagen);
                            //Leer los primeros dos bytes para validar que es imagen tipo MBP
                            char primerByte = br.ReadChar();
                            char segundoByte = br.ReadChar();

                            if (primerByte == 'B' && segundoByte == 'M')
                            {
                                //Si es BMP
                                int fileSize = br.ReadInt32();//leer el tamaño del archivo 4 bytes= 32 bits
                                txtSizeBytes.Text = Convert.ToString(fileSize);

                                imagen.Seek(18, SeekOrigin.Begin); //colocar el apuntador para leer el byte 19 
                                int anchura = br.ReadInt32();
                                txtAncho.Text = Convert.ToString(anchura);
                                int altura = br.ReadInt32();
                                txtLargo.Text = Convert.ToString(altura);

                                imagen.Seek(28, SeekOrigin.Begin);
                                int bitsXpixel = br.ReadInt16();
                                txtBitsByPixel.Text = Convert.ToString(bitsXpixel);
                            }
                            else
                            {
                                MessageBox.Show("El archivo no es de tipo BMP");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo abrir el archivo. Original error: " + ex.Message);
                }
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog elArchivo = new SaveFileDialog();
            elArchivo.Filter = "Archivos txt| *.txt";

            if (elArchivo.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(elArchivo.FileName))
                {
                    string xml = "" +

                        "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n" +
                        "<registro>\r\n" +
                        "\t<primerNombre>" + txtprimerNombre.Text + "</primerNombre>\r\n" +
                        "\t<apellido>" + txtApellido.Text + "</apellido>\r\n" +
                        "\t<edad>" + txtEdad.Text + "</edad>\r\n" +
                        "\t<lugarNacimiento>" + txtLugarNacimiento.Text + "</lugarNacimiento>\r\n" +
                        "\t<estadoCivil>" + txtEstadoCivil.Text + "</estadoCivil>\r\n" +
                        "</registro>";

                        /*
                        "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n" + //remplazando texto
                        "<registro>\r\n" +
                        "\t<primerNombre>--nombre--</primerNombre>\r\n" +
                        "\t<apellido>--apellido--</apellido>\r\n" +
                        "\t<edad>--edad--</edad>\r\n" +
                        "\t<lugarNacimiento>--lugar--</lugarNacimiento>\r\n" +
                        "\t<estadoCivil>--civil--</estadoCivil>\r\n" +
                        "</registro>";*/

                    FileStream catalogo = new FileStream(elArchivo.FileName, FileMode.Create);
                    MessageBox.Show("Archivo creado");
                    StreamWriter writer = new StreamWriter(catalogo);
                    /*
                    writer.Write(xml.Replace("--nombre--",txtprimerNombre.Text)
                        .Replace("--apellido--", txtApellido.Text)
                        .Replace("--edad--", txtEdad.Text)
                        .Replace("--lugar--", txtLugarNacimiento.Text)
                        .Replace("--civil--", txtEstadoCivil.Text));
                        */
                    writer.Write(xml);
                    writer.Close();
                    catalogo.Close();
                }
            }
        }
    }
    
}
