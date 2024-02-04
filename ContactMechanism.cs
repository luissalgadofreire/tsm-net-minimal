namespace TheSaultyMonk.Minimal.Representation;

public class ContactMechanism
{
    private readonly List<ContactMechanismLink> _links = new();

    public IReadOnlyList<ContactMechanismLink> Links
    {
        get => _links.AsReadOnly();
        init => _links = value.ToList();
    }


    public Guid TypeId { get; set; }
}