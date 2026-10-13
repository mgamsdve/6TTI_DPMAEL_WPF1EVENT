using System;

namespace _6TTI_DPMAEL_WPF1EVENT
{
    public class MethodesDuProjet
    {
        public void ResoudreTrinome(
            double a, double b, double c, out string message)
        {
            if (a == 0)
            {
                message = "A doit être différent de zéro.";
                return;
            }

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                message = "Il y a une solution : " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                message = "Il y a deux solutions : " + x1 + " et " + x2;
            }
        }
    }
}