﻿using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption;

public static class SigningCredentialHelper
{
    public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
    {
        return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
    }
}
