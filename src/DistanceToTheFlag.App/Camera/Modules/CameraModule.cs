using DistanceToTheFlag.App.Camera.Exceptions;

namespace DistanceToTheFlag.App.Camera.Modules;
public class CameraModule : ICameraModule
{
    public async Task<FileResult> TakePhoto()
    {
        if (!MediaPicker.Default.IsCaptureSupported)
        {
            throw new CameraNotSupportedException();
        }

        FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
        if (photo != null)
        {
            // save the file into local storage
            string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

            using Stream sourceStream = await photo.OpenReadAsync();
            using FileStream localFileStream = File.OpenWrite(localFilePath);

            await sourceStream.CopyToAsync(localFileStream);
        }
        return photo;
    }
}
