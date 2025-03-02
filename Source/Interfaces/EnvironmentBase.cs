namespace Oblikovati.API;

/// <summary>
/// Represents a EnvironmentBase Object.
/// </summary>
public interface EnvironmentBase
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Application Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Internal Name of the EnvironmentBase.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Display Name of the EnvironmentBase.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarBase DefaultToolBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarBase DefaultPanelBar { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarList PanelBarList { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarBase MenuBar { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandBarBase CurrentPanelBar { get; set; }
}
