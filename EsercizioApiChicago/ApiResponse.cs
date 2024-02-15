using System.Text.Json.Serialization;

namespace EsercizioApiChicago
{
    public class Response
    {
        public Pagination Pagination { get; set; }
        public Data[] Data { get; set; }
        public Info Info { get; set; }
        public Config Config { get; set; }
    }

    public class Pagination
    {
        public int Total { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }
        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }
        [JsonPropertyName("next_url")]
        public string NextUrl { get; set; }
    }

    public class Data
    {
        public int Id { get; set; }
        [JsonPropertyName("api_model")]
        public string ApiModel { get; set; }
        [JsonPropertyName("api_link")]
        public string ApiLink { get; set; }
        [JsonPropertyName("is_boosted")]
        public bool IsBoosted { get; set; }
        public string Title { get; set; }
        [JsonPropertyName("alt_titles")]
        public object AltTitles { get; set; }
        public Thumbnail Thumbnail { get; set; }
        [JsonPropertyName("main_reference_number")]
        public string MainReferenceNumber { get; set; }
        [JsonPropertyName("has_not_been_viewed_much")]
        public bool HasNotBeenViewedMuch { get; set; }
        [JsonPropertyName("boost_rank")]
        public object BoostRank { get; set; }
        [JsonPropertyName("date_start")]
        public int DateStart { get; set; }
        [JsonPropertyName("date_end")]
        public int DateEnd { get; set; }
        [JsonPropertyName("date_display")]
        public string DateDisplay { get; set; }
        [JsonPropertyName("date_qualifier_title")]
        public string DateQualifierTitle { get; set; }
        [JsonPropertyName("date_qualifier_id")]
        public int? DateQualifierId { get; set; }
        [JsonPropertyName("artist_display")]
        public string ArtistDisplay { get; set; }
        [JsonPropertyName("place_of_origin")]
        public string PlaceOfOrigin { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Dimensions { get; set; }
        public DimensionsDetail[] DimensionsDetail { get; set; }
        public string MediumDisplay { get; set; }
        public string Inscriptions { get; set; }
        public string CreditLine { get; set; }
        public string CatalogueDisplay { get; set; }
        public string PublicationHistory { get; set; }
        public string ExhibitionHistory { get; set; }
        public string ProvenanceText { get; set; }
        public object Edition { get; set; }
        public string PublishingVerificationLevel { get; set; }
        public int InternalDepartmentId { get; set; }
        public int? FiscalYear { get; set; }
        public object FiscalYearDeaccession { get; set; }
        public bool IsPublicDomain { get; set; }
        public bool IsZoomable { get; set; }
        public int MaxZoomWindowSize { get; set; }
        public string CopyrightNotice { get; set; }
        public bool HasMultimediaResources { get; set; }
        public bool HasEducationalResources { get; set; }
        public bool HasAdvancedImaging { get; set; }
        public double Colorfulness { get; set; }
        public Color Color { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string LatLon { get; set; }
        public bool IsOnView { get; set; }
        public string OnLoanDisplay { get; set; }
        public object GalleryTitle { get; set; }
        public object GalleryId { get; set; }
        public object NomismaId { get; set; }
        public string ArtworkTypeTitle { get; set; }
        public int ArtworkTypeId { get; set; }
        public string DepartmentTitle { get; set; }
        public string DepartmentId { get; set; }
        public int? ArtistId { get; set; }
        public string ArtistTitle { get; set; }
        public object[] AltArtistIds { get; set; }
        public int[] ArtistIds { get; set; }
        public string[] ArtistTitles { get; set; }
        public string[] CategoryIds { get; set; }
        public string[] CategoryTitles { get; set; }
        public string[] TermTitles { get; set; }
        public string StyleId { get; set; }
        public string StyleTitle { get; set; }
        public object[] AltStyleIds { get; set; }
        public string[] StyleIds { get; set; }
        public string[] StyleTitles { get; set; }
        public string ClassificationId { get; set; }
        public string ClassificationTitle { get; set; }
        public string[] AltClassificationIds { get; set; }
        public string[] ClassificationIds { get; set; }
        public string[] ClassificationTitles { get; set; }
        public string SubjectId { get; set; }
        public string[] AltSubjectIds { get; set; }
        public string[] SubjectIds { get; set; }
        public string[] SubjectTitles { get; set; }
        public string MaterialId { get; set; }
        public string[] AltMaterialIds { get; set; }
        public string[] MaterialIds { get; set; }
        public string[] MaterialTitles { get; set; }
        public string TechniqueId { get; set; }
        public string[] AltTechniqueIds { get; set; }
        public string[] TechniqueIds { get; set; }
        public string[] TechniqueTitles { get; set; }
        public string[] ThemeTitles { get; set; }
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }
        public string[] AltImageIds { get; set; }
        public string[] DocumentIds { get; set; }
        public string[] SoundIds { get; set; }
        public object[] VideoIds { get; set; }
        public object[] TextIds { get; set; }
        public object[] SectionIds { get; set; }
        public object[] SectionTitles { get; set; }
        public object[] SiteIds { get; set; }
        public SuggestAutocompleteAll[] SuggestAutocompleteAll { get; set; }
        public string SourceUpdatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Timestamp { get; set; }
        public string SuggestAutocompleteBoosted { get; set; }
    }

    public class Thumbnail
    {
        public string Lqip { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string AltText { get; set; }
    }

    public class DimensionsDetail
    {
        public int? Depth { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public object Diameter { get; set; }
        public string Clarification { get; set; }
    }

    public class Color
    {
        public int H { get; set; }
        public int L { get; set; }
        public int S { get; set; }
        public double Percentage { get; set; }
        public int Population { get; set; }
    }

    public class SuggestAutocompleteAll
    {
        public string[] Input { get; set; }
        public Contexts Contexts { get; set; }
        public int Weight { get; set; }
    }

    public class Contexts
    {
        public string[] Groupings { get; set; }
    }

    public class Info
    {
        public string LicenseText { get; set; }
        public string[] LicenseLinks { get; set; }
        public string Version { get; set; }
    }

    public class Config
    {
        public string IiifUrl { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
