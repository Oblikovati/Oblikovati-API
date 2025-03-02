namespace Oblikovati.API;

/// <summary>
/// The ProjectedCuts object provides access to all of the projected cut edges on the sketch.
/// </summary>
public interface ProjectedCuts : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified ProjectedCut object from the collection.
    /// </summary>
    ProjectedCut Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds projected cut edges by intersecting the model with the sketch plane and creating the resulting sketch entities. This method performs the same function as the Project Cut Edges command.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ProjectedCut Add();
}
