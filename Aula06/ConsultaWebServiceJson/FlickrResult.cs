using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaWebServiceJson
{
    [DataContract]
    public class FlickrResult
    {
        [DataMember(Name = "photos")]
        public FlickrPhotos Photos { get; set; }
    }

    [DataContract]
    public class FlickrPhotos
    {
        [DataMember(Name = "photo")]
        public IList<Imagem> Photo { get; set; }
    }

    [DataContract]
    public class Imagem
    {
        [DataMember(Name = "farm")]
        public string Farm { get; set; }

        [DataMember(Name = "server")]
        public string Server { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "secret")]
        public string Secret { get; set; }

        public string URL
        {
            get
            {
                return "https://farm" + Farm + ".staticflickr.com/" + Server + "/" + Id + "_" + Secret + ".jpg";
            }
        }
    }
}
