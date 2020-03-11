using System.Collections.Generic;

namespace Aptacode.Interpolatr
{
    public interface ILinearInterpolator<T>
    {
        IEnumerable<T> Interpolate(int stepCount, EaserFunction easer, params T[] points);
        IEnumerable<T> Interpolate(int stepCount, EaserFunction easer, T from, T to);
    }
}