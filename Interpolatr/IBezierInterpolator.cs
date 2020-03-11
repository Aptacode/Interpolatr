using System.Collections.Generic;

namespace Aptacode.Interpolatr
{
    public interface IBezierInterpolator<T>
    {
        IEnumerable<T> Interpolate(int stepCount, EaserFunction easer, params T[] points);
    }
}