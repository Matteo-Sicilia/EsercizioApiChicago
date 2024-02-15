using System.Net.Http.Json;
using System.Text.Json;
using EsercizioApiChicago;

public class Artwork
{
    public string Id { get; set; }
    public string ArtworkImage { get; set; }
    public string Title { get; set; }
    public string ArtistDisplay { get; set; }
    public string DateDisplay { get; set; }
    public string Description { get; set; }
    public string PlaceOfOrigin { get; set; }
    public string Dimensions { get; set; }
    public string OnLoanDisplay { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        var url = "https://api.artic.edu/api/v1/artworks";
        var client = new HttpClient();
        var response = await client.GetFromJsonAsync<Response>(url);
        var RootFolder = "Artworks";
        Directory.CreateDirectory(RootFolder);

        foreach (var artwork in response.Data)
        {
            var folder = artwork.Id;
            Directory.CreateDirectory($"{RootFolder}\\{folder}");

            var artworkInfo = new Artwork
            {
                Title = artwork.Title,
                ArtworkImage = artwork.ImageId,
                ArtistDisplay = artwork.ArtistDisplay,
                DateDisplay = artwork.DateDisplay,
                Description = artwork.Description,
                PlaceOfOrigin = artwork.PlaceOfOrigin,
                Dimensions = artwork.Dimensions,
            };

            var json = JsonSerializer.Serialize(artworkInfo);
            File.WriteAllText($"{RootFolder}\\{folder}\\{folder}.json", json);

            string ImageUrl = $"https://www.artic.edu/iiif/2/{artworkInfo.ArtworkImage}/full/843,1000/0/default.jpg";
            var image = await client.GetByteArrayAsync(ImageUrl);
            File.WriteAllBytes($"{RootFolder}\\{folder}\\{folder}.jpg", image);

            string HtmlPage = $"<html><body><h1>{artworkInfo.Title}</h1><img src=\"{folder}.jpg\"><p>{artworkInfo.Description}</p><p>{artworkInfo.ArtistDisplay}</p><p>{artworkInfo.DateDisplay}</p><p>{artworkInfo.PlaceOfOrigin}</p></body></html>";
            File.WriteAllText($"{RootFolder}\\{folder}\\{folder}.html", HtmlPage);
        }

    }
}