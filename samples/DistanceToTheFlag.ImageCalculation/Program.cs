using DistanceToTheFlag.ImageCalculation;
using System.Drawing;

var actualSubjectHeight = 0;

// load image
var photoPath = "./images/sample.jpg";
var imageBytes = File.ReadAllBytes(photoPath);
var base64image = Convert.ToBase64String(imageBytes);
var imageSource = string.Format("data:image/jpg;base64,{0}", base64image);
var image = new Bitmap(photoPath);

// instantiate photograph of object class
var focalLength = image.GetFocalLength();
var sensorHeight = image.GetSensorHeight();
var photograph = new PhotographOfObject
{
    FocalLength = focalLength,
    RealHeight = actualSubjectHeight,
    ImageHeight = 1,
    ObjectHeight = 1,
    SensorHeight = sensorHeight
};

var distance = photograph.GetDistanceToObject();

