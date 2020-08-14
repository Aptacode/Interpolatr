using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec2Interpolator<T> : GenericVectorInterpolator<T, Vector2>
    {
        public override Vector2 Subtract(Vector2 left, Vector2 right) => left - right;

        public override Vector2 Normalize(Vector2 vector) => Vector2.Normalize(vector);

        public override float GetLength(Vector2 vector) => vector.Length();

        public override Vector2 Add(Vector2 left, Vector2 right) => Vector2.Add(left, right);

        public override Vector2 Multiply(Vector2 vector, float value) => Vector2.Multiply(vector, value);
    }
}