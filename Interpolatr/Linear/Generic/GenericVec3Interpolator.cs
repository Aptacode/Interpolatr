using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec3Interpolator<T> : GenericVectorInterpolator<T, Vector3>
    {
        public override Vector3 Subtract(Vector3 left, Vector3 right) => left - right;

        public override Vector3 Normalize(Vector3 vector) => Vector3.Normalize(vector);

        public override float GetLength(Vector3 vector) => vector.Length();

        public override Vector3 Add(Vector3 left, Vector3 right) => Vector3.Add(left, right);

        public override Vector3 Multiply(Vector3 vector, float value) => Vector3.Multiply(vector, value);
    }
}