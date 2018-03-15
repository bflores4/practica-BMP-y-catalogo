using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_archivos_de_texto_y_binarios
{
    class ImagenBMP
    {
        private int _sizeBytes;
        private int _widthBMP;
        private int _heightBMP;
        private int _bitsByPixel;

        public int sizeBytes
        { get { return _sizeBytes; } }
        public int width
        { get { return _widthBMP; } }
        public int heightBMP
        { get { return _heightBMP; } }
        public int bitsByPixel
        { get { return _bitsByPixel; } }

        public ImagenBMP()
        {
            _sizeBytes = 11;
            _widthBMP = 22;
            _heightBMP = 33;
            _bitsByPixel = 44;
        }

        public ImagenBMP(int sizeBytes, int widthBMP, int height, int bitsByPixel)
        {
            _sizeBytes = sizeBytes;
            _widthBMP = widthBMP;
            _heightBMP = heightBMP;
            _bitsByPixel = bitsByPixel;
        }

        public override string ToString()
        {
            return "Tamaño en bytes: " + _sizeBytes.ToString() +
                "Ancho de imagen: " + _widthBMP.ToString() +
                "Alto de imagen: " + _heightBMP.ToString() +
                "Bits por pixel: " + _bitsByPixel.ToString();
        }
    }
}
