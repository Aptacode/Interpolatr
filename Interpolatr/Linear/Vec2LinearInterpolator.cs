using System.Numerics;
using Aptacode.Interpolatr.Linear.Generic;

namespace Aptacode.Interpolatr.Linear
{
    public sealed class Vec2LinearInterpolator : GenericVec2Interpolator<Vector2>
    {
        public override Vector2 FromVector(Vector2 vector) => vector;

        public override Vector2 ToVector(Vector2 value) => value;
    }
}