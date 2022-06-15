using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceToTheFlag.ImageCalculation;
internal class PhotographOfObject
{
    public double FocalLength { get; init; }
    public double RealHeight { get; init; }
    public int ImageHeight { get; init; } // pixels
    public int ObjectHeight { get; init; } // pixels
    public double SensorHeight { get; init; }
    public double GetDistanceToObject()
    {
        return (FocalLength * RealHeight * ImageHeight) /
            (ObjectHeight * SensorHeight);
    }

}