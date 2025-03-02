namespace Oblikovati.API;

/// <summary>
/// The RepresentationsManager object provides access to all types of representations in an assembly, and design view representations in a part.
/// </summary>
public interface RepresentationsManager
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AssemblyComponentDefinition _Parent { get; }
    /// <summary>
    /// Property that returns the parent AssemblyComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the PositionalRepresentations collection object. This property returns Nothing in part documents.
    /// </summary>
    PositionalRepresentations PositionalRepresentations { get; }
    /// <summary>
    /// Property that returns the active PositionalRepresentation object. This property returns Nothing in part documents.
    /// </summary>
    PositionalRepresentation ActivePositionalRepresentation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LevelOfDetailRepresentations LevelOfDetailRepresentations { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    LevelOfDetailRepresentation ActiveLevelOfDetailRepresentation { get; }
    /// <summary>
    /// Property that returns the DesignViewRepresentations collection object.
    /// </summary>
    DesignViewRepresentations DesignViewRepresentations { get; }
    /// <summary>
    /// Property that returns the active DesignViewRepresentation object.
    /// </summary>
    DesignViewRepresentation ActiveDesignViewRepresentation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string PrivateRepresentationFileName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool PrivateRepresentationFileLoaded { get; set; }
}
