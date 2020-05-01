﻿using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace WarhammerProfessionApp.Utility
{
    public static class ClaimsReader
    {
        public static int GetUserId(HttpRequest request)
        {
            var principal = request.HttpContext.Request.HttpContext.User;

            if (!(principal?.Identity is ClaimsIdentity identity))
                return 0;

            var claim = identity.Claims.FirstOrDefault(a => a.Type.Equals(ClaimTypes.Name)).Value;

            return int.Parse(claim);
        }
    }
}