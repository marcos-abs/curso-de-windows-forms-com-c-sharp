﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace Certweb.Internet {
    public class GerenciadorDeAcesso {
        public static string AcessarLink(string link) {
            WebClient client = new WebClient();
            return client.DownloadString(link);
        }
    }
}
