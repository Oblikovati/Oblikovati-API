namespace Oblikovati.API;

/// <summary>
/// The SketchBlocks collection object provides access to all sketch block instances within a sketch and provides methods to create additional block instances.
/// </summary>
public interface SketchBlocks : IEnumerable
{
    /// <summary>
    /// Returns the specified SketchBlock object from the collection.
    /// </summary>
    SketchBlock Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a sketch block instance using existing sketch objects. A sketch block definition is implicitly created. The newly created SketchBlock object is returned.
    /// </summary>
    /// <param name="SketchObjects">Input ObjectCollection that specifies the sketch entities to create the sketch block from. The collection can contain SketchEntity, (other) SketchBlock, SketchImage and TextBox objects.</param>
    /// <param name="Name">Optional input String that specifies a name for the sketch block definition. If not provided, the name is automatically generated.</param>
    /// <param name="InsertionPoint">Optional input Point2d object that specifies the insertion point for the sketch block. The insertion sketch point is created in space and no constraints are created on the insertion point. The insertion point can be retrieved using SketchBlockDefinition.InsertionPoint property and constraints can be added to it. If not specified, a default insertion point is chosen.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchBlock Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchObjects, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? InsertionPoint = default);
    /// <summary>
    /// Method that creates a sketch block instance based on the \input definition. The newly created SketchBlock object is returned.
    /// </summary>
    /// <param name="Definition">Input SketchBlockDefinition that specifies the definition to create the instance from.</param>
    /// <param name="Position">Input Point2d object that specifies the placement point for the block in sketch space. The block is placed such that the insertion point of the sketch block definition coincides with this point.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchBlock AddByDefinition([In] [MarshalAs(UnmanagedType.Interface)] SketchBlockDefinition Definition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position);
}
