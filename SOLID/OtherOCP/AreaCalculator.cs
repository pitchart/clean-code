using System.Collections.Generic;

namespace SOLID.OtherOCP
{
    public class AreaCalculator
    {
        public int SumAreas(List<IFigure> figures)
        {
            var area = 0;
            foreach (var figure in figures)
            {
                if (figure is Rectangle)
                {
                    var rectangle = (Rectangle) figure;
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