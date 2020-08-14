using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec4Interpolator<T> : GenericVectorInterpolator<T, Vector4>
    {
        public override Vector4 Subtract(Vector4 from, Vector4 to) => from - to;

        public override Vector4 Normalize(Vector4 from) => Vector4.Normalize(from);

        public override float GetLength(Vector4 vector) => vector.Length();

        public override Vector4 Add(Vector4 from, Vector4 to) => Vector4.Add(from, to);

        public override Vector4 Multiply(Vector4 from, float value) => Vector4.Multiply(from, value);
    }
}