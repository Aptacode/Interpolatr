using System.Numerics;
using Aptacode.Interpolation.Interpolators.Linear.Generic;

namespace Aptacode.Interpolation.Interpolators.Linear
{
    public sealed class Vec2Interpolator : GenericVec2LinearInterpolator<Vector2>
    {
        public override Vector2 FromVector(Vector2 value)
        {
            return value;
        }

        public override Vector2 ToVector(Vector2 value)
        {
            return value;
        }
    }
}