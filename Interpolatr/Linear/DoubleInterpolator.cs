using System;
using System.Collections.Generic;
using System.Linq;

namespace Aptacode.Interpolatr.Linear
{
    public sealed class DoubleInterpolator : ILinearInterpolator<double>
    {
        public IEnumerable<double> Interpolate(int stepCount, EaserFunction easer, double[] points)
        {
            if (stepCount <= 0)
            {
                yield break;
            }

            //Get the list of edges
            var edges = GetEdges(points);

            //The distance to travel per step
            var velocity = TotalEdgeLength(edges) / stepCount;

            if (velocity <= 0)
            {
                for (var i = 0; i < stepCount; i++)
                {
                    yield return points.Last();
                }
            }
            else
            {
                //Yield a point for each step
                foreach (var (pointA, pointB, edge) in edges)
                {
                    var edgeSteps = Math.Abs(edge) / velocity;
                    foreach (var value in Interpolate((int) edgeSteps, easer, pointA, pointB))
                    {
                        yield return value;
                    }
                }
            }
        }

        public IEnumerable<double> Interpolate(int stepCount, EaserFunction easer, double from, double to)
        {
            if (stepCount <= 0)
            {
                yield break;
            }

            var edgeLength = to - from;

            for (var stepIndex = 1; stepIndex < stepCount; stepIndex++)
            {
                yield return from + edgeLength * easer(stepIndex, stepCount);
            }

            //Return the last point for this step
            yield return to;
        }

        private List<(double, double, double)> GetEdges(IReadOnlyList<double> keyPoints)
        {
            //Point A, Point B, Length
            var edges = new List<(double, double, double)>();

            for (var i = 1; i < keyPoints.Count; i++)
            {
                edges.Add((keyPoints[i - 1], keyPoints[i], keyPoints[i] - keyPoints[i - 1]));
            }

            return edges;
        }

        public double TotalEdgeLength(IReadOnlyList<(double, double, double)> edges)
        {
            return edges.Sum(edge => Math.Abs(edge.Item3));
        }
    }
}