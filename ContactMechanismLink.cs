namespace TheSaultyMonk.Minimal.Representation;

public class ContactMechanismLink {
  
  public string Description { get; set; } = string.Empty;
  
  public ContactMechanism? FromContactMechanism { get; set; }
  public ContactMechanism? ToContactMechanism { get; set; }
  
  public Guid FromContactMechanismId { get; set; }
  public Guid ToContactMechanismId { get; set; }

}