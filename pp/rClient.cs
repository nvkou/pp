using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace pp
{
    class rClient
    {
        private RestClient Rclient;
        public string url;
        public string header;
        public string result;
        public Dictionary<string, string> pararmeter;
        public string error;
        public Method method;
        public Exception exception;
 

        public rClient(string url,Method method,Dictionary<string,string> parameter=null) {
            this.Rclient = new RestClient(url);
        }



        
        
    }
}
