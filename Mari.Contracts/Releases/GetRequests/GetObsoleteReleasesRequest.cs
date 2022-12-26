using Mari.Contracts.Common.Routes.Server;
using Mari.Contracts.Releases.Responses;
using Mari.Http.Requests;

namespace Mari.Contracts.Releases.GetRequests;

public class GetObsoleteReleasesRequest : GetRequest<IEnumerable<ReleaseResponse>>
{
    public const string ConstRouteTemplate = $"{ServerRoutes.Controllers.Release}/obsolete";
    public override string RouteTemplate => ConstRouteTemplate;
}
