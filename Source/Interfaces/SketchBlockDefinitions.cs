namespace Oblikovati.API;

/// <summary>
/// The SketchBlockDefinitions collection object provides access to all sketch block definitions and provides methods to create additional definitions.
/// </summary>
public interface SketchBlockDefinitions : IEnumerable
{
    /// <summary>
    /// Returns the specified SketchBlockDefinition object from the collection.
    /// </summary>
    SketchBlockDefinition this[object Index] { get; }
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
    /// Method that creates a new (empty) SketchBlockDefinition. The newly created SketchBlockDefinition is returned.
    /// </summary>
    /// <param name="Name">Optional input String that specifies a name for the sketch block definition. If not provided, the name is automatically generated.</param>
    /// <param name="InsertionPoint">Optional input Point2d object that specifies the insertion point for the sketch block. The insertion sketch point is created in space and no constraints are created on the insertion point. The insertion point can be retrieved using SketchBlockDefinition.InsertionPoint property and constraints can be added to it. If not specified, a default insertion point is chosen.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchBlockDefinition Add([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? InsertionPoint = default);
}
