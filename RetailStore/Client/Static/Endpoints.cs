using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailStore.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string CreatesEndpoint = $"{Prefix}/creates";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string ItemsEndpoint = $"{Prefix}/items";
        public static readonly string CheckoutsEndpoint = $"{Prefix}/Checkouts";
    }
}
