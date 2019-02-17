namespace graphql_dotnet_boxed_template
{
    using System.Threading.Tasks;
    using GraphQL.Server.Transports.AspNetCore;
    using Microsoft.AspNetCore.Http;

    public class GraphQLUserContextBuilder : IUserContextBuilder
    {
        public Task<object> BuildUserContext(HttpContext httpContext) =>
            Task.FromResult<object>(new GraphQLUserContext() { User = httpContext.User });
    }
}
