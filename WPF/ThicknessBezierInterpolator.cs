using System.Numerics;
using System.Windows;
using Aptacode.Interpolatr.Bezier;

namespace Aptacode.Interpolatr.WPF
{
    public class ThicknessBezierInterpolator : VectorBezierInterpolator<Thickness>
    {
        public override Vector2 ToVector(Thickness value) =>
            new Vector2((float) value.Left, (float) value.Top); //(float) value.Right, (float) value.Bottom);

        public override Thickness FromVector(Vector2 value) =>
            new Thickness(value.X, value.Y, 0, 0); //value.Z, value.W);
    }
}