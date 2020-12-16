using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace HotChocoAuthExample
{
    public class TestAuthorize : IAuthorizationRequirement
    {


    }

    public class TestAuthorizeHandler : AuthorizationHandler<TestAuthorize>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, TestAuthorize requirement)
        {
            //return Task.CompletedTask;
            context.Succeed(requirement);
        }
    }
}
