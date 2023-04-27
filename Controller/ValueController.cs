using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CihanAbay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {

        [HttpGet(Name = "Encode")]
        public string Encode()
        {
            try
            {
                string sirket = "123asdqwe567";
                string ortak = "987şlk654";
                var utc0 = new DateTime(1970,1,1,0,0,0,0, DateTimeKind.Utc);
                var issueTime = DateTime.Now;

                var iat = (int)issueTime.Subtract(utc0).TotalSeconds;
                var exp = (int)issueTime.AddMinutes(55).Subtract(utc0).TotalSeconds; // Expiration time is up to 1 hour, but lets play on safe side
                                                                                     // Arrange
                var payload = new Dictionary<string, object>()
            {
                 { "secret", sirket},
               { "exp", exp},
               { "iat", iat}
            };

                // Act
                var token = JsonWebToken.Encode(payload, ortak, JwtHashAlgorithm.HS256);
                return token;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

 
        [HttpPost(Name = "Decode")]
        public string Decode()
        {
            try
            {
                string sirket = "123asdqwe567";
                string ortak = "987şlk654";
                var utc0 = new DateTime(1970,1,1,0,0,0,0, DateTimeKind.Utc);
                var issueTime = DateTime.Now;

                var iat = (int)issueTime.Subtract(utc0).TotalSeconds;
                var exp = (int)issueTime.AddMinutes(55).Subtract(utc0).TotalSeconds; // Expiration time is up to 1 hour, but lets play on safe side
                                                                                     // Arrange
                var payload = new Dictionary<string, object>()
            {
                 { "secret", sirket},
               { "exp", exp},
               { "iat", iat}
            };
                var token = JsonWebToken.Encode(payload, ortak, JwtHashAlgorithm.HS256);
                // Act
                var tokenDecode = JsonWebToken.Decode(token, ortak);
                return token;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}