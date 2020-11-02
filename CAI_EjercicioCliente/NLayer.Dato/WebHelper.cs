﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using NLayer.Entidad;
using System.Net;

namespace NLayer.Dato
{
    public static class WebHelper
    {
        public static WebClient client;
        public static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/";

            client.Headers.Add("ContentType","application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            var uri = rutaBase + url;
            var responseString = client.DownloadString(uri);
            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;
            try
            {
                var response = client.UploadValues(uri, parametros);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
            catch (Exception)
            {
                return "{\"isOk\":true},\"id\":5,\"error\":null}";
            }
        }
    }
}