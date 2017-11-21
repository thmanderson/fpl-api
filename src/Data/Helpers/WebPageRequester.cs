﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FPL.Data.Helpers
{
    public static class WebPageRequester
    {
        private static string _HEADERS_ACCEPT            = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        private static string _HEADERS_ACCEPT_ENCODING   = "gzip, deflate";
        private static string _HEADERS_ACCEPT_LANGUAGE   = "en-gb,en;q=0.5";
        private static string _HEADERS_USER_AGENT        = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:17.0) Gecko/20100101 Firefox/17.0"; // just a dummy user agent that looks like a real browser
        
        public static string Post(string url, string data, ref CookieContainer refCookies)
        {
            return MakeRequest(url, "application/x-www-form-urlencoded", "POST", data, ref refCookies);
        }

        public static string Get(string url, ref CookieContainer refCookies)
        {
            return MakeRequest(url, "text/html", "GET", null, ref refCookies);
        }

        private static string MakeRequest(string url, string contenttype, string method, string data, ref CookieContainer refCookies)
        {
            // create new request
            var req = (HttpWebRequest)System.Net.HttpWebRequest.Create(url);

            // add headers as per browser
            req.Accept                      = _HEADERS_ACCEPT;
            req.UserAgent                   = _HEADERS_USER_AGENT;
            req.Headers["Accept-Encoding"]  = _HEADERS_ACCEPT_ENCODING;
            req.Headers["Accept-Language"]  = _HEADERS_ACCEPT_LANGUAGE; 
            req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            // Set method/content type
            req.ContentType = contenttype;
            req.Method = method;

            // Add cookies
            if (refCookies == null)
                refCookies = new CookieContainer();
            req.CookieContainer = refCookies;
            
            if (data != null)
            {
                // _logger.WriteDebugMessage("WebPageRequester.MakeRequest - Sending data");

                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
                req.ContentLength = bytes.Length;

                using (System.IO.Stream os = req.GetRequestStream())
                {
                    os.Write(bytes, 0, bytes.Length); //Push it out there
                    os.Close();
                }
            }

            // _logger.WriteDebugMessage("WebPageRequester.MakeRequest - Reading response");

            using (System.Net.HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                // if (resp == null)
                    // _logger.WriteErrorMessage("WebPageRequester.MakeRequest - No response received");
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                var strResponse = sr.ReadToEnd().Trim();
                //_logger.WriteInfoMessage("WebPageRequester.MakeRequest - Response: " + strResponse);
                //_logger.WriteDebugMessage("WebPageRequester.MakeRequest - Response Content Length: " + resp.ContentLength);
                //_logger.WriteDebugMessage("WebPageRequester.MakeRequest - Response Content Encoding: " + resp.ContentEncoding);
                //_logger.WriteDebugMessage("WebPageRequester.MakeRequest - Response Content Type: " + resp.ContentType);
                //_logger.WriteDebugMessage("WebPageRequester.MakeRequest - Response Character Set: " + resp.CharacterSet);
                return strResponse;
            }
        }
    }
}
