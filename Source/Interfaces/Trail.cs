namespace Oblikovati.API;

/// <summary>
/// The Trail object represents the path of an occurrence from its initial to the final position in the exploded view as a result of the tweaks applied to it.
/// </summary>
public interface Trail : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationExplodedView Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    TrailSegment this[int Index] { get; }
    /// <summary>
    /// Method that sets the visibility of the entire trail in the presentation view.
    /// </summary>
    /// <param name="Visible">Specifies whether the input object is visible in the drawing view.</param>
    [PreserveSig]
    void SetVisibility([In] bool Visible);
}
