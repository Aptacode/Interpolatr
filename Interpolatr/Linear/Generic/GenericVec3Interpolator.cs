using System.Numerics;

namespace Aptacode.Interpolatr.Linear.Generic
{
    public abstract class GenericVec3Interpolator<T> : GenericVectorInterpolator<T, Vector3>
    {
        public override Vector3 Subtract(Vector3 from, Vector3 to)
        {
            return from - to;
        }

        public override Vector3 Normalize(Vector3 from)
        {
            return Vector3.Normalize(from);
        }

        public override float GetLength(Vector3 vector)
        {
            return vector.Length();
        }

        public override Vector3 Add(Vector3 from, Vector3 to)
        {
            return Vector3.Add(from, to);
        }

        public override Vector3 Multiply(Vector3 from, float value)
        {
            return Vector3.Multiply(from, value);
        }
    }
}