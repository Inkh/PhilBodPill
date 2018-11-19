using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PhilBodPill.Models.Handlers
{
    public class ForbiddenNameRequirement : AuthorizationHandler<ForbiddenNameRequirement>, IAuthorizationRequirement
    {
        string _badName;

        public ForbiddenNameRequirement(string badName)
        {
            _badName = badName.ToLower();
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ForbiddenNameRequirement requirement)
        {
            if(!context.User.HasClaim(c => c.Type == "firstNameLower"))
            {
                return Task.CompletedTask;
            }

            string nameToCheck = context.User.Claims.First(n => n.Type == "firstNameLower").Value;

            if(nameToCheck != _badName)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
