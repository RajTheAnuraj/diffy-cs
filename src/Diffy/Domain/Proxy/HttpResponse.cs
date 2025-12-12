namespace Diffy.Domain.Proxy;

public class HttpResponse : HttpMessage
{
    public string Status { get; set; }

    public HttpResponse() : base()
    {
        Status = string.Empty;
    }

    public HttpResponse(string status, Dictionary<string, string> headers, string body) 
        : base(headers, body)
    {
        Status = status;
    }

    public override string ToString()
    {
        return $"\nstatus = {Status}\nmessage =\n{base.ToString()}\n";
    }
}
