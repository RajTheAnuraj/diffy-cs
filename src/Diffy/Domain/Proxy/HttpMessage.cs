using System.Collections.Generic;

namespace Diffy.Domain.Proxy;

public abstract class HttpMessage
{
    public Dictionary<string, string> Headers { get; set; }
    public string Body { get; set; }

    protected HttpMessage()
    {
        Headers = new Dictionary<string, string>();
        Body = string.Empty;
    }

    protected HttpMessage(Dictionary<string, string> headers, string body)
    {
        Headers = headers ?? new Dictionary<string, string>();
        Body = body ?? string.Empty;
    }

    public override string ToString()
    {
        var headerString = string.Join("\n", 
            Headers.Select(entry => $"{entry.Key} : {entry.Value}"));
        return $"\n{headerString}\n{Body}";
    }
}
