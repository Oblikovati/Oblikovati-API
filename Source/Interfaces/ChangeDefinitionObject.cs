namespace Oblikovati.API;

public interface ChangeDefinitionObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ChangeManager Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string CommandName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandTypesEnum ChangeType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    ChangeProcessor CreateChangeProcessor();
}
