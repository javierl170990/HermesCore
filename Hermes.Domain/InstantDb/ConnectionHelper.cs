using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain.InstantDb
{
    public class ConnectionHelper
    {
        private readonly IConfiguration _configuration;

        public ConnectionHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() => {
                return ConnectionMultiplexer.Connect(_configuration.GetConnectionString("RedisURL"));
            });
        }

       
        private static Lazy<ConnectionMultiplexer> lazyConnection;
        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }
}