using System.Collections.Generic;

namespace Aptacode.Interpolatr
{
    public interface ILinearInterpolator<T>
    {
        IEnumerable<T> Interpolate(int stepCount, EaserFunction easer, T pointA, T pointB);
        IEnumerable<T> Interpolate(int stepCount, EaserFunction easer, T[] points);
    }
}