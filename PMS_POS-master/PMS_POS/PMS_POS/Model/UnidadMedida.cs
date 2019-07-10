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

            float transformado = 0;

            if (this.Nombre.Equals("Grano"))
            {
                switch (comparador)
                {
                    case "Grano":
                        transformado = valorTransformar;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 437.5f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 7000f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 0.015f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 15.43f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 15432.36f;
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
                        transformado = valorTransformar * 0.0023f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 0.000035f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 0.035f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 35.27f;
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
                        transformado = valorTransformar * 0.00014f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 0.0000022f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 0.0022f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 2.20f;
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
                        transformado = valorTransformar * 64.80f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 28349.52f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 453592.37f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 1000f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 1000000f;
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
                        transformado = valorTransformar * 0.065f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 28.35f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 453.59f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 0.001f;
                        break;
                    case "Kilogramo":
                        transformado = valorTransformar * 1000f;
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
                        transformado = valorTransformar * 0.000065f;
                        break;
                    case "Onza":
                        transformado = valorTransformar * 0.028f;
                        break;
                    case "Libra":
                        transformado = valorTransformar * 0.45f;
                        break;
                    case "Miligramo":
                        transformado = valorTransformar * 0.000001f;
                        break;
                    case "Gramo":
                        transformado = valorTransformar * 0.001f;
                        break;
                }
            }

            if (this.Nombre.Equals("Cuchara de té"))
            {
                switch (comparador)
                {
                    case "Cuchara de té":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 3f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 6f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 48f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 96f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 192f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 768f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 32256f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.000202884f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.202884136f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 202.8841362f;
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
                        transformado = valorTransformar * 0.333333333f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 2f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 32f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 64f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 256f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 10752f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.000068f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.067628045f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 67.6280454f;
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
                        transformado = valorTransformar * 0.166666667f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.5f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 8f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 32f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 128f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 5376f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.000034f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.033814023f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 33.8140227f;
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
                        transformado = valorTransformar * 0.020833333f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.125f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 2f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 4f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 16f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 672f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.0000042f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.004226753f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 4.226752838f;
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
                        transformado = valorTransformar * 0.010416667f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.03125f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.5f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 2f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 8f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 336f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.0000021f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.002113376f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 2.113376419f;
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
                        transformado = valorTransformar * 0.005208333f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.015625f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.03125f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.25f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.5f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 4f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 168f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.0000011f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.001056688f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 1.056688209f;
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
                        transformado = valorTransformar * 0.001302083f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.00390625f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.0078125f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.0625f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.125f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.25f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 42f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.00000026f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.000264172f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.264172052f;
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
                        transformado = valorTransformar * 0.000031f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.000093f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.000186012f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.001488095f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.00297619f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.005952381f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 0.023809524f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.0000000063f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.0000063f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 0.006289811f;
                        break;
                }
            }

            if (this.Nombre.Equals("Milímetros cb"))
            {
                switch (comparador)
                {
                    case "Milímetros cb":
                        transformado = valorTransformar;
                        break;
                    case "Cuchara de té":
                        transformado = valorTransformar * 4928.921594f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 14786.76478f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 29573.52956f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 236588.2365f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 473176.473f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 946352.946f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 3785411.784f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 158987294.9f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 1000f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 1000000f;
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
                        transformado = valorTransformar * 4.928921594f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 14.78676478f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 29.57352956f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 236.5882365f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 473.176473f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 946.352946f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 3785.411784f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 158987.2949f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.001f;
                        break;
                    case "Litros":
                        transformado = valorTransformar * 1000f;
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
                        transformado = valorTransformar * 0.004928922f;
                        break;
                    case "Cuchara de madera":
                        transformado = valorTransformar * 0.014786765f;
                        break;
                    case "Onza fluida":
                        transformado = valorTransformar * 0.02957353f;
                        break;
                    case "Taza":
                        transformado = valorTransformar * 0.236588237f;
                        break;
                    case "Medio litro":
                        transformado = valorTransformar * 0.473176473f;
                        break;
                    case "Cuarto de galón":
                        transformado = valorTransformar * 0.946352946f;
                        break;
                    case "Galón":
                        transformado = valorTransformar * 3.785411784f;
                        break;
                    case "Barril":
                        transformado = valorTransformar * 158.9872949f;
                        break;
                    case "Milímetros cb":
                        transformado = valorTransformar * 0.000001f;
                        break;
                    case "Mililitros":
                        transformado = valorTransformar * 0.001f;
                        break;
                }
            }

            return transformado;
        }
    }
}
