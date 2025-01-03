using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepJan25
{
    public interface IGeometryDraw //Kontrakt, alt er abstract
    {
        void DrawCircle(int x, int y, int r);
        void DrawRectangle(int x, int y, int x1, int y1);
        int CalculateArea();

    }
}
