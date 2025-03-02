namespace Oblikovati.API;

/// <summary>
/// Storyboard object.
/// </summary>
public interface Storyboard
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Publication Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the PublicationTweaks collection object.
    /// </summary>
    PublicationTweaks Tweaks { get; }
    /// <summary>
    /// Read-only property that returns the ID of the storyboard.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Read-only property that returns the PublicationTrails collection object.
    /// </summary>
    PublicationTrails Trails { get; }
    /// <summary>
    /// Method that deletes the storyboard.
    /// </summary>
    [PreserveSig]
    void Delete();
}
