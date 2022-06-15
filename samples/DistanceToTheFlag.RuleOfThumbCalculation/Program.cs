// See https://aka.ms/new-console-template for more information
var sameSizeThumbAsSubject = new ThumbCalculation
{
    PixelReferenceHeight = 1,
    PixelSubjectHeight = 1,
    ActualReferenceHeight = 2.5, // inches
    ActualSubjectHeight = 36, // inches
    ActualReferenceDistance = 22, // inches
};

var distance = sameSizeThumbAsSubject.CalculateDistanceAway();
Console.WriteLine(distance);
// should be about 6 yards, or 216 inches

internal class ThumbCalculation
{
    public int PixelReferenceHeight { get; set; }
    public int PixelSubjectHeight { get; set; }
    public double ActualReferenceHeight { get; set; }
    public double ActualSubjectHeight { get; set; }
    public double ActualReferenceDistance { get; set; }
    public double CalculateDistanceAway()
    {
        var heightRatio = PixelSubjectHeight / PixelReferenceHeight;
        var distance = ActualReferenceDistance / ActualReferenceHeight * ActualSubjectHeight * heightRatio;
        return distance;
    }
}