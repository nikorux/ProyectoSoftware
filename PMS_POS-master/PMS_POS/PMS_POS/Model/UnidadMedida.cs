using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_POS.Model
{
    class UnidadMedida
    {
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }

        public float Conversion(String comparador, float valorTransformar)
        {
            //-----------------Masa------------------

            float transformado = 0;

            if (this.Nombre.Equals("Grano"))
            {
                switch (comparador)
                {
                    case "Grano":
                        transformado = valorTransformar;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 0.0023f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 0.0014f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 64.7989f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 0.065f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 0.000065f;
                        break;
                }
            }

            if (this.Nombre.Equals("Onza"))
            {
                switch (comparador)
                {
                    case "Onza":
                        transformado = valorTransformar;
                        break;
                    case "Grano":
                        transformado = valorTransformar * 437.5f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 28349.5f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 28.3f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 0.028f;
                        break;
                }
            }

            if (this.Nombre.Equals("Libra"))
            {
                switch (comparador)
                {
                    case "Libra":
                        transformado = valorTransformar;
                        break;
                    case "Grano":
                        transformado = valorTransformar * 7000f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 453592f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 453.592f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 0.45f;
                        break;
                }
            }

            if (this.Nombre.Equals("Miligramo"))
            {
                switch (comparador)
                {
                    case "Miligramo":
                        transformado = valorTransformar;
                        break;
                    case "Grano":
                        transformado = valorTransformar * 0.015f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 0.000035f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 0.0000022f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 0.001f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 0.000001f;
                        break;
                }
            }

            if (this.Nombre.Equals("Gramo"))
            {
                switch (comparador)
                {
                    case "Gramo":
                        transformado = valorTransformar;
                        break;
                    case "Grano":
                        transformado = valorTransformar * 15.43f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 0.035f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 0.0022f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 1000f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 0.001f;
                        break;
                }
            }

            if (this.Nombre.Equals("Kilogramo"))
            {
                switch (comparador)
                {
                    case "Kilogramo":
                        transformado = valorTransformar;
                        break;
                    case "Grano":
                        transformado = valorTransformar * 15432.36f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 35.3f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 2.20f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 100000f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 1000f;
                        break;
                }
            }

            //-----------------Volumen----------------------------

            if (this.Nombre.Equals("Cuchara de té"))
            {
                switch (comparador)
                {
                    case "Cuchara de té":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.333333f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.166667f;
                        break;
                    case "Taza":
                        transformado = valorTransformar / 0.2083f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.0104f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.0052f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.0013f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 3.1002f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 4.9289f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.0049f;
                        break;
                }
            }

            if (this.Nombre.Equals("Cuchara de madera"))
            {
                switch (comparador)
                {
                    case "Cuchara de madera":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 3f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.5f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.03125f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.0156f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.0039f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 9.3006f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 14.7867f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.0148f;
                        break;
                }
            }

            if (this.Nombre.Equals("Onza fluida"))
            {
                switch (comparador)
                {
                    case "Onza fluida":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 6f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 2f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.125f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.03125f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.0078f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 0.000186f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 29.5735f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.0296f;
                        break;
                }
            }

            if (this.Nombre.Equals("Taza"))
            {
                switch (comparador)
                {
                    case "Taza":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 48f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 8f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.5f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.25f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 0.0015f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 236.59f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.2366f;
                        break;
                }
            }

            if (this.Nombre.Equals("Medio litro"))
            {
                switch (comparador)
                {
                    case "Medio litro":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 96f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 32f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 2f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.5f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.125f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 0.002976f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 473.1765f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.4732f;
                        break;
                }
            }

            if (this.Nombre.Equals("Cuarto de galón"))
            {
                switch (comparador)
                {
                    case "Cuarto de galón":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 192f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 64f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 32f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 4f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 2f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.25f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 0.00952f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 946.3529f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.9464f;
                        break;
                }
            }

            if (this.Nombre.Equals("Galón"))
            {
                switch (comparador)
                {
                    case "Galón":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 768f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 256f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 128f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 8f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 4f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 0.0238f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 3785.4118f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 3.7854f;
                        break;
                }
            }

            if (this.Nombre.Equals("Barril"))
            {
                switch (comparador)
                {
                    case "Barril":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 32256f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 10752f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 5376f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 672f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 336f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 168f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 42f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 158987.2949f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 158.9873f;
                        break;
                }
            }

            if (this.Nombre.Equals("Mililitros"))
            {
                switch (comparador)
                {
                    case "Mililitros":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 0.2029f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.06763f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.0338f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.0042267f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.0021134f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.0010567f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.00026417f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 6.2898f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.001f;
                        break;
                }
            }

            if (this.Nombre.Equals("Litros"))
            {
                switch (comparador)
                {
                    case "Litros":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 202.8841f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 67.6280f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 33.8140f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 4.22675f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 2.1134f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 1.05669f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.26417f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 0.0062898f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 1000f;
                        break;
                }
            }

            return transformado;
        }
    }
}
