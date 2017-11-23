﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace KenticoCloud.ContentManagement
{
    public sealed class ContentItemPutModel
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("sitemap_locations", Required = Required.Always)]
        public ICollection<ManageApiReference> SitemapLocations { get; set; }
    }
}
