using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceToTheFlag.App.Camera.Exceptions;
public class CameraNotSupportedException : Exception
{
    public CameraNotSupportedException() : base("Camera not supported.")
    {

    }
}
