using System.Drawing;

var actualSubjectHeight = 0;
var actualSubjectWidth = 0;

var photoPath = "./images/sample.jpg";
var imageBytes = File.ReadAllBytes(photoPath);
var base64image = Convert.ToBase64String(imageBytes);
var imageSource = string.Format("data:image/jpg;base64,{0}", base64image);
var image = new Bitmap(photoPath);
var items = image.PropertyItems;
/*
var photograph = new PhotographOfObject
{
    FocalLength = focalLength,
    RealHeight = actualSubjectHeight,
    ImageHeight = 1,
    ObjectHeight = 1,
    SensorHeight = sensorHeight
};

var distance = photograph.GetDistanceToObject();
*/
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