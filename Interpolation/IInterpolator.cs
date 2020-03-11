using System.Collections.Generic;

namespace Aptacode.Interpolation
{
    public interface IInterpolator<T>
    {
        IEnumerable<T> Interpolate(int stepCount, EaserFunction easer, params T[] points);
    }
}