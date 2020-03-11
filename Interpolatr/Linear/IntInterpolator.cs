using System;
using System.Collections.Generic;
using System.Linq;

namespace Aptacode.Interpolatr.Linear
{
    public sealed class IntInterpolator : ILinearInterpolator<int>
    {
        public IEnumerable<int> Interpolate(int stepCount, EaserFunction easer, params int[] points)
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
                //If the distance to travel per step is 0 then return the last destination
                //for each step
                for (var i = 0; i < stepCount; i++)
                {
                    yield return points.Last();
                }
            }
            else
            {
                //for each edge
                foreach (var (pointA, pointB, edge) in edges)
                {
                    //Calculate how many steps this edge has
                    var edgeSteps = Math.Abs(edge) / velocity;
                    //Return a value for each step along this edge
                    foreach (var value in Interpolate(edgeSteps, easer, pointA, pointB))
                    {
                        yield return value;
                    }
                }
            }
        }

        public IEnumerable<int> Interpolate(int stepCount, EaserFunction easer, int from, int to)
        {
            if (stepCount <= 0)
            {
                yield break;
            }

            var edgeLength = to - from;

            for (var stepIndex = 1; stepIndex < stepCount; stepIndex++)
            {
                yield return from + (int) (edgeLength * easer(stepIndex, stepCount));
            }

            //Return the last point for this step
            yield return to;
        }

        private static List<(int, int, int)> GetEdges(IEnumerable<int> keyPoints)
        {
            var keyPointList = keyPoints.ToList();
            //Point A, Point B, Length
            var edges = new List<(int, int, int)>();

            for (var i = 1; i < keyPointList.Count; i++)
            {
                edges.Add((keyPointList[i - 1], keyPointList[i], keyPointList[i] - keyPointList[i - 1]));
            }

            return edges;
        }

        public int TotalEdgeLength(IEnumerable<(int, int, int)> edges)
        {
            return edges.Sum(edge => Math.Abs(edge.Item3));
        }
    }
}