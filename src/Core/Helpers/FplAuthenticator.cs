using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FPL.Core.Helpers
{
    public static class FplAuthenticator
    {
        private const string _URL_GETSESSIONCOOKIES1 = "https://users.premierleague.com";
        private const string _URL_GETSESSIONCOOKIES2 = "https://users.premierleague.com/PremierUser/account/login.html";
        private const string _URL_LOGIN = "https://users.premierleague.com/PremierUser/j_spring_security_check";
        private const string _FIELD_USERNAME = "j_username";
        private const string _FIELD_PASSWORD = "j_password";

        public static CookieContainer Authenticate(string username, string password)
        {
            var cookies = new CookieContainer();
            WebPageRequester.Get(_URL_GETSESSIONCOOKIES1, ref cookies);

            // if (cookies == null || cookies.Count < 2) throw new Exception("Session cookies not set");

            var parameters = string.Format("{0}={1}&{2}={3}", _FIELD_USERNAME, username, _FIELD_PASSWORD, password);
            WebPageRequester.Post(_URL_LOGIN, parameters, ref cookies);

            if (cookies.Count < 3) throw new Exception("Authentication failed for user " + username);

            return cookies;
        }
    }
}
