namespace DistanceToTheFlag.App.Camera.Modules;
public interface ICameraModule
{
    public Task<FileResult> TakePhoto();
}
