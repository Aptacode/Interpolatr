
# Interpolatr

### a lightweight cross platform .net tweening & Interpolation library.


NuGet package:

[![NuGet](https://img.shields.io/nuget/v/Aptacode.Interpolatr.svg?style=flat)](https://www.nuget.org/packages/Aptacode.Interpolatr/)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/042b4cf9e73b4a46aa38c55c3d4c3b0c)](https://www.codacy.com/manual/Timmoth/Aptacode.Interpolatr?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Timmoth/Aptacode.Interpolatr&amp;utm_campaign=Badge_Grade)


## User Guide

### Code Example

```csharp

double startValue = 0;
double endValue = 10;
int stepCount = 5;

IEnumerable<Double> result = DoubleInterpolator.Interpolate(stepCount, DefaultEasers.Linear, startValue, endValue);

//Expected output { 2, 4, 6, 8, 10 }

```

### Easers
Easer functions are used to determine the rate at which a transformations value changes. The graphs below show the rate at which an interpolator affected by each easer approaches its end value over time.

<p align="center">
  <img width="700" height="600" src="https://raw.githubusercontent.com/Timmoth/Aptacode.Interpolatr/master/Resources/Images/easers.png">
</p>

### Easer demos

#### Linear

![Alt Text](https://raw.githubusercontent.com/Timmoth/Aptacode.Interpolatr/master/Resources/demos/Linear.gif)

#### EaseIn

![Alt Text](https://raw.githubusercontent.com/Timmoth/Aptacode.Interpolatr/master/Resources/demos/EaseIn.gif)

#### EaseOut

![Alt Text](https://raw.githubusercontent.com/Timmoth/Aptacode.Interpolatr/master/Resources/demos/EaseOut.gif)

#### EaseInOut

![Alt Text](https://raw.githubusercontent.com/Timmoth/Aptacode.Interpolatr/master/Resources/demos/EaseInOut.gif)

#### Elastic

![Alt Text](https://raw.githubusercontent.com/Timmoth/Aptacode.Interpolatr/master/Resources/demos/Elastic.gif)


