namespace Oblikovati.API;

/// <summary>
/// Content Center configuration Object.
/// </summary>
public interface ContentCenterConfiguration
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    DesignProject Parent { get; }
    /// <summary>
    /// Gets/Sets the content center configuration XML.
    /// </summary>
    string ConfigurationXML { get; set; }
    /// <summary>
    /// Gets the content center configuration XML that is inherited from the included project file.
    /// </summary>
    string InheritedConfigurationXML { get; }
    /// <summary>
    /// Gets the Boolean flag indicating whether the configuration data needs to be updated from the project file.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Refreshes the content center configuration XML from the project file.
    /// </summary>
    [PreserveSig]
    void Refresh();
}
