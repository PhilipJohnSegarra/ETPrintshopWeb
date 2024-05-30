using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ImagesController : ControllerBase
{
    private readonly IWebHostEnvironment _environment;

    public ImagesController(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    [HttpGet("{imageName}")]
    public IActionResult GetImage(string imageName)
    {
        var path = Path.Combine(_environment.ContentRootPath,
                    _environment.EnvironmentName, "unsafe_uploads", imageName);

        if (!System.IO.File.Exists(path))
        {
            return NotFound("none");
        }

        var mimeType = GetMimeType(imageName);
        var image = System.IO.File.OpenRead(path);
        return File(image, mimeType);
    }

    private string GetMimeType(string fileName)
    {
        var extension = Path.GetExtension(fileName).ToLowerInvariant();

        return extension switch
        {
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".gif" => "image/gif",
            ".bmp" => "image/bmp",
            ".tiff" => "image/tiff",
            _ => "application/octet-stream",
        };
    }
}
