namespace Oblikovati.API;

/// <summary>
/// The ModelSurfaceTextureSymbols collection object provides access to all of the surface texture symbols in a part or assembly and provides functionality to create new surface texture symbols.
/// </summary>
public interface ModelSurfaceTextureSymbols : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    ModelSurfaceTextureSymbol Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a surface texture symbol.
    /// </summary>
    /// <param name="Definition">Input ModelSurfaceTextureSymbolDefinition object that defines the leader note to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelSurfaceTextureSymbol Add([In] [MarshalAs(UnmanagedType.Interface)] ModelSurfaceTextureSymbolDefinition Definition);
    /// <summary>
    /// Method that creates a surface texture symbol definition.&nbsp;This is a not a surface texture symbol but an object that encapsulates all of the information that defines a surface texture symbol.&nbsp;You use the methods and properties of this object to define the surface texture symbol you want to create and then provide it as input to the Add method.
    /// </summary>
    /// <param name="LeaderPoints">ObjectCollection containing a series of Point objects representing the leader originating at the note. The last item in the collection (even if it is the only item) can be a GeometryIntent object indicating the geometry to attach the leader to. The ObjectCollection must contain at least one item, else the method will fail.  The points are projected onto the orientation plane.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelSurfaceTextureSymbolDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition);
}
