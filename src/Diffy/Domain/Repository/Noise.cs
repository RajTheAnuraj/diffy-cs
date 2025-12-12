using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Diffy.Domain.Repository;

public class Noise
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public string Endpoint { get; set; }
    
    public List<string> NoisyFields { get; set; }

    public Noise(string endpoint, List<string> noisyFields)
    {
        Endpoint = endpoint;
        NoisyFields = noisyFields;
    }
}
