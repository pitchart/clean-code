using System.Collections.Generic;

namespace SOLID.OtherOCP
{
    public class AreaCalculator
    {
        public int sumAreas(List<IFigure> figures)
        {
            int area = 0;
            foreach (var figure in figures)
            {
                if (figure is Rectange)
                {
                    var rectangle = (Rectange) figure;
                    area += rectangle.Largeur * rectangle.Longueur;
                } else if (figure is Triangle)
                {
                    var triangle = (Triangle) figure;
                    area += triangle.Base * triangle.Hauteur / 2;
                }
            }

            return area;
        }
    }

    public interface IFigure
    {
    }
}