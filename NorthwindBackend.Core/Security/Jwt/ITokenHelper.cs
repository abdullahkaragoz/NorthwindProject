﻿using NorthwindBackend.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindBackend.Core.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
