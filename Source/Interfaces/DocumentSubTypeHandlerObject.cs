namespace Oblikovati.API;

public interface DocumentSubTypeHandlerObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ApplicationName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    EnvironmentBase DefaultEnvironment { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DocumentSubTypeID { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UserChangeable { get; set; }
}
