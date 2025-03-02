namespace Oblikovati.API;

/// <summary>
/// The ClientGraphics object is a collection of objects.
/// </summary>
public interface ClientGraphics : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returns the logical parent of this object.
    /// </summary>
    ClientGraphicsCollection Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of GraphicsNode objects associated with this ClientGraphics object.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    GraphicsNode Item { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    GraphicsNode ItemById { get; }
    /// <summary>
    /// Property that returns the ID of this ClientGraphics object.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Property that gets and sets whether all of the GraphicsNode objects within the ClientGraphics object are selectable. When getting this property valid values are kAllGraphicsSelectable, kNoGraphicsSelectable, and kSomeGraphicsSelectable. When setting this property kAllGraphicsSelectable and kNoGraphicsSelectable are valid.
    /// </summary>
    GraphicsSelectabilityEnum Selectable { get; set; }
    /// <summary>
    /// Property that gets and sets whether all of the GraphicsNode objects within the ClientGraphics object are visible. When getting this property valid values are kAllGraphicsVisible, kNoGraphicsVisible, and kSomeGraphicsVisible. When setting this property kAllGraphicsVisible and kNoGraphicsVisible are valid.
    /// </summary>
    GraphicsVisibilityEnum Visible { get; set; }
    /// <summary>
    /// Read-only property that returns whether the creation of this ClientGraphics object and all its associated data is non-transacting.
    /// </summary>
    bool NonTransacting { get; }
    /// <summary>
    /// Method that creates a new GraphicsNode object.
    /// </summary>
    /// <param name="NodeId">Input Long that specifies the identifier for the newly created entity. This id needs to be unique with respect to all other objects in this ClientGraphics object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsNode AddNode([In] int NodeId);
    /// <summary>
    /// Method that deletes this ClientGraphics object. This will delete all of its associated GraphicsNode objects too.
    /// </summary>
    [PreserveSig]
    void Delete();
}
