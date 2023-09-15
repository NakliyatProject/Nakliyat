//using Microsoft.AspNetCore.Identity;

//namespace Prensentation.Middleware
//{
//    public class AreaMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public AreaMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task Invoke(HttpContext context)
//        {
//            if (context.User.Identity.IsAuthenticated)
//            {
//                var user = context.User;
//                var userManager = context.RequestServices.GetRequiredService<UserManager<IdentityUser>>();
                
//                    var roles = await userManager.GetRolesAsync(user);

//                if (roles.Contains("Customer"))
//                {
//                    context.Request.Path = "/CustomerArea"; // Customer alanına yönlendir
//                }
//                else if (roles.Contains("Company"))
//                {
//                    context.Request.Path = "/CompanyArea"; // Company alanına yönlendir
//                }
//            }

//            await _next(context);
//        }
//    }

//}
