﻿using System.Numerics;
using System.Windows;
using Aptacode.Interpolatr.Linear.Generic;

namespace Aptacode.Interpolatr.WPF
{
    public class ThicknessLinearInterpolator : GenericVec4Interpolator<Thickness>
    {
        public override Vector4 ToVector(Thickness value) => new Vector4((float) value.Left, (float) value.Top,
            (float) value.Right, (float) value.Bottom);

        public override Thickness FromVector(Vector4 value) => new Thickness(value.X, value.Y, value.Z, value.W);
    }
}