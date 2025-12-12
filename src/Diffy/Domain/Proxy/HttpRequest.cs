namespace Diffy.Domain.Proxy;

public class HttpRequest : HttpMessage
{
    public string Method { get; set; }
    public string Uri { get; set; }
    public string Path { get; set; }
    public Dictionary<string, string> Params { get; set; }
    public string RoutingMode { get; set; }

    public HttpRequest() : base()
    {
        Method = string.Empty;
        Uri = string.Empty;
        Path = string.Empty;
        Params = new Dictionary<string, string>();
        RoutingMode = string.Empty;
    }

    public HttpRequest(string method, string uri, string path, 
        Dictionary<string, string> parameters, Dictionary<string, string> headers, 
        string body, string routingMode) : base(headers, body)
    {
        Method = method;
        Uri = uri;
        Path = path;
        Params = parameters ?? new Dictionary<string, string>();
        RoutingMode = routingMode;
    }

    public override string ToString()
    {
        var paramsString = string.Join(", ", 
            Params.Select(kvp => $"{kvp.Key}={kvp.Value}"));
        return $"path = {Path}\nparams =\n{paramsString}\nmessage =\n{base.ToString()}\n";
    }
}
