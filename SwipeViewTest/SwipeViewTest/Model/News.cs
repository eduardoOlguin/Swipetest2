using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Xamarin.Forms;

namespace smaforetagarnaAPP.Model
{

    public partial class News
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        // public Command GoToUrlCommand { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }


        [JsonProperty("title")]
        public GuidClass Title { get; set; }

        [JsonProperty("_embedded")]
        public Embedded Embedded { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("excerpt")]
        public Content Excerpt { get; set; }

    }

    public partial class Content
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }
    }

    public partial class Embedded
    {
        //[JsonProperty("author")]
        //public EmbeddedAuthor[] Author { get; set; }

        [JsonProperty("wp:featuredmedia")]
        public WpFeaturedmedia[] WpFeaturedmedia { get; set; }

        //[JsonProperty("wp:term")]
        //public EmbeddedWpTerm[][] WpTerm { get; set; }
    }

    public partial class WpFeaturedmedia
    {
        //[JsonProperty("id")]
        //public long Id { get; set; }

        //[JsonProperty("date")]
        //public DateTimeOffset Date { get; set; }

        //[JsonProperty("slug")]
        //public string Slug { get; set; }

        //[JsonProperty("type")]
        //public WpFeaturedmediaType Type { get; set; }

        //[JsonProperty("link")]
        //public Uri Link { get; set; }

        //[JsonProperty("title")]
        //public GuidClass Title { get; set; }

        //[JsonProperty("author")]
        //public long Author { get; set; }

        //[JsonProperty("caption")]
        //public GuidClass Caption { get; set; }

        //[JsonProperty("alt_text")]
        //public string AltText { get; set; }

        //[JsonProperty("media_type")]
        //public MediaType MediaType { get; set; }

        //[JsonProperty("mime_type")]
        //public MimeType MimeType { get; set; }

        [JsonProperty("media_details")]
        public MediaDetails MediaDetails { get; set; }

        [JsonProperty("source_url")]
        public Uri SourceUrl { get; set; }

    //    [JsonProperty("_links")]
    //    public WpFeaturedmediaLinks Links { get; set; }
    }

    public partial class MediaDetails
    {
        //[JsonProperty("width")]
        //public long Width { get; set; }

        //[JsonProperty("height")]
        //public long Height { get; set; }

        //[JsonProperty("file")]
        //public string File { get; set; }

        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }

        //[JsonProperty("image_meta")]
        //public ImageMeta ImageMeta { get; set; }
    }

    public partial class Sizes
    {
        [JsonProperty("medium")]
        public Full Medium { get; set; }

        [JsonProperty("large")]
        public Full Large { get; set; }
    }

    public partial class Full
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        //[JsonProperty("mime_type")]
        //public MimeType MimeType { get; set; }

        [JsonProperty("source_url")]
        public Uri SourceUrl { get; set; }

        //[JsonProperty("uncropped", NullValueHandling = NullValueHandling.Ignore)]
        //public bool? Uncropped { get; set; }
    }




    public partial class GuidClass
    {
        [JsonProperty("rendered")]
        public string Rendered { get; set; }
    }
}
