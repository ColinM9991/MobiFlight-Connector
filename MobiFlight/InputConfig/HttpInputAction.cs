using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace MobiFlight.InputConfig
{
    public class HttpInputAction : InputAction, ICloneable
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public new const string Label = "HTTP Request";

        public const string TYPE = nameof(HttpInputAction);
        
        public Uri Url { get; set; }
        
        public override object Clone()
        {
            return new HttpInputAction
            {
                Url = new Uri(Url.ToString()),
            };
        }

        public override void ReadXml(XmlReader reader)
        {
            string url = reader["url"];

            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri parsedUri))
                throw new InvalidOperationException($"Invalid URL format {url}");

            Url = parsedUri;
        }

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("type", TYPE);
            writer.WriteAttributeString("url", Url.ToString());
        }

        public override void execute(CacheCollection cacheCollection, InputEventArgs e, List<ConfigRefValue> configRefs)
        {
            Task.Run(() => httpClient.GetAsync(Url).GetAwaiter().GetResult());
        }
    }
}