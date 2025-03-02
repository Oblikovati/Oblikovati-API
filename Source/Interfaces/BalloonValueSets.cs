namespace Oblikovati.API;

/// <summary>
/// The BalloonValueSets object represents a collection of objects. Note that this collection does not yet support an Add method. See the article in the overviews section.
/// </summary>
public interface BalloonValueSets : IEnumerable
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
    /// Returns the specified object from the collection.
    /// </summary>
    BalloonValueSet this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new BalloonValueSet.
    /// </summary>
    /// <param name="Component">Input object that defines the component that this balloon will be attached to. This can be one of the following: a ComponentOccurrence / ComponentOccurrenceProxy object, or a DrawingBOMRow object.</param>
    /// <returns></returns>
    [PreserveSig]
    BalloonValueSet Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Component);
}
