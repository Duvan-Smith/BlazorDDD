using System;
using System.Net;

namespace Blazor.Aplicacion.Dto.Base
{
    [Serializable]
    public class DataTransferObject
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
    }
}