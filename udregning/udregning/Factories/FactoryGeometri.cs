using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace udregning.Factories
{
    public class FactoryGeometri
    {
        public string KugleOverflade(string input, string knap)
        {
            double tal;
            string output;

            if (double.TryParse(input, out tal))
            {
                if (knap == "Radius")
                {//                                           tal er r eller d
                    output = "Overflade er: " + (4 * Math.PI * Math.Pow(tal, 2));
                }
                else //Diameter knappen, er det ikke den ene, må det være den anden
                {
                    tal = tal / 2;//fordi det er radius
                    output = "Overflade er: " + (4 * Math.PI * Math.Pow(tal, 2));
                }
            }
            else
            {
                output = "Indtast et tal";
            }

            return output;
        }

        public string KugleRumfang(string input, string knap)
        {
            double tal;
            string output;

            if (double.TryParse(input, out tal))
            {
                if (knap == "Radius")
                {
                    output = "Rumfang er:" + ((4 * Math.PI * Math.Pow(tal, 3) / 3));
                }
                else
                {
                    tal = tal / 2;
                    output = "Rumfang er:" + ((4 * Math.PI * Math.Pow(tal, 3) / 3));

                }
            }
            else
            {
                output = "indtast et tal";
            }

            return output;
        }


        public string PyramideRumfang(string input, string input2)
        {
            double tal;
            double tal2;
            string output;

            if (double.TryParse(input, out tal) && double.TryParse(input2, out tal2))
            {

                output = "Rumfang er:" + (1 * tal * tal2 / 3).ToString();


            }
            else
            {
                output = "indtast tal";
            }

            return output;
        }
        public string KegleRumfang(string input, string input2)
        {
            double tal;
            double tal2;
            string output;

            if (double.TryParse(input, out tal) && double.TryParse(input2, out tal2))
            {

                output = "Rumfang er:" + (1 * tal * tal2 / 3).ToString();


            }
            else
            {
                output = "indtast tal";
            }

            return output;
        }

        public string PrismerRumfang(string input, string input2)
        {
            double tal;
            double tal2;
            string output;

            if (double.TryParse(input, out tal) && double.TryParse(input2, out tal2))
            {
                output = "Rumfang er:" + (tal * tal2).ToString();
            }
            else
            {
                output = "Indtast tal";
            }
            return output;
        }

        public string CylinderRumfang(string inputR, string inputH, string knap)
        {
            double r; //radius
            double h; // Højde
            string output;

            if (double.TryParse(inputR, out r) && double.TryParse(inputH, out h))
            {
                if (knap == "Rumfang")
                {//                                          
                    output = "Rumfang  er: " + (Math.PI * Math.Pow(r, 2) * h);
                }
                else
                {

                    output = "Overflade er: " + (2 * Math.PI * r * h);
                }
            }
            else
            {
                output = "Indtast et tal";
            }
            return output;
        }

        public string Kasse(string inputH, string inputL, string inputB, string knap)
        {
            double H;
            double L;
            double B;
            string output;

            if (double.TryParse(inputH, out H) && double.TryParse(inputL, out L) && double.TryParse(inputB, out B))
            {
                if (knap == "Rumfang")
                {
                    output = "Rumfang er:" + (L * B * H);
                }
                else
                {
                    output = "Overflade er :" + ((L * H + H * B + B * L * 2));
                }


            }
            else
            {
                output = "Indtast et tal";
            }
            return output;
        }

        public string Cirkel(string inputR, string inputD, string knap)

        {
            double r;
            double d;
            string output;

            if (double.TryParse(inputR, out r) && double.TryParse(inputD, out d))

                if (knap == "Areal")
                {
                    output = "Areal er: " + (Math.PI * Math.Pow(r, 2));
                }
                else
                {
                    output = "omkreds er:" + (2 * Math.PI * r);

                }
            else
            {
                output = "Indtast et tal";
            }
            return output;
        }

        public string Parallelogram(string inputH, string inputG)
        {
            double h;
            double g;
            string output;

            if (double.TryParse(inputH, out h) && double.TryParse(inputG, out g))
            {
                output = "Areal er:" + (h * g);
            }
            else
            {
                output = "indtast et tal";
            }
            return output;

        }

        public string TrekantHeron(string inputA, string inputB, string inputC)
        {
            double a, b, c, s;
            string output;
            if (double.TryParse(inputA, out a) && double.TryParse(inputB, out b) && double.TryParse(inputC, out c))
            {
                s = (a + b + c) / 2;
                output = "Arealet er:" + Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
            else
            {
                output = "indtast et tal";
            }
            return output;






        }

        public string TrekantAreal(string inputH, string inputG)
        {
            double h;
            double g;
            string output;

            if (double.TryParse(inputH, out h) && double.TryParse(inputG, out g))
            {
                output = "Areal er:" + ((h * g) / 2);
            }
            else
            {
                output = "indtast et tal";
            }
            return output;
        }

        public string Trapez(string inputA, string inputB, string inputH)
        {
            double a;
            double b;
            double h;
            string output;

            if (double.TryParse(inputA, out a) && double.TryParse(inputB, out b) && double.TryParse(inputH, out h))
            {
                output = "Areal er:" + ((a + b * h) / 2);
            }
            else
            {
                output = "indtast et tal";
            }
            return output;

        }


        public string Rektangel(string inputL, string inputB, string knap)
        {

            double l;
            double b;
            string output;

            if (double.TryParse(inputL, out l) && double.TryParse(inputB, out b))

                if (knap == "Areal")
                {
                    output = "Areal er: " + (l * b);
                }
                else
                {
                    output = "omkreds er:" + ((l + b) * 2);

                }
            else
            {
                output = "Indtast et tal";
            }
            return output;
        }
    }
}




