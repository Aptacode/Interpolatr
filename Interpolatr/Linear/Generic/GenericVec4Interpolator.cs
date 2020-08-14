using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec4Interpolator<T> : GenericVectorInterpolator<T, Vector4>
    {
        public override Vector4 Subtract(Vector4 left, Vector4 right) => left - right;

        public override Vector4 Normalize(Vector4 vector) => Vector4.Normalize(vector);

        public override float GetLength(Vector4 vector) => vector.Length();

        public override Vector4 Add(Vector4 left, Vector4 right) => Vector4.Add(left, right);

        public override Vector4 Multiply(Vector4 vector, float value) => Vector4.Multiply(vector, value);
    }
}