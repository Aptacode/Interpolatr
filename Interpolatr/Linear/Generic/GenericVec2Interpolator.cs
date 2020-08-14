using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec2Interpolator<T> : GenericVectorInterpolator<T, Vector2>
    {
        public override Vector2 Subtract(Vector2 from, Vector2 to) => from - to;

        public override Vector2 Normalize(Vector2 from) => Vector2.Normalize(from);

        public override float GetLength(Vector2 vector) => vector.Length();

        public override Vector2 Add(Vector2 from, Vector2 to) => Vector2.Add(from, to);

        public override Vector2 Multiply(Vector2 from, float value) => Vector2.Multiply(from, value);
    }
}