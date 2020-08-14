using System.Numerics;
using System.Windows;
using Aptacode.Interpolatr.Linear.Generic;

namespace Aptacode.Interpolatr.WPF
{
    public class PointInterpolator : GenericVec2Interpolator<Point>
    {
        public override Point FromVector(Vector2 value) => new Point((int) value.X, (int) value.Y);

        public override Vector2 ToVector(Point value) => new Vector2((float) value.X, (float) value.Y);
    }
}