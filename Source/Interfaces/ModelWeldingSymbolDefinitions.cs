namespace Oblikovati.API;

/// <summary>
/// The ModelWeldingSymbolDefinitions collection object provides access to the definitions for a model welding  symbol and provides methods to create additional ones.
/// </summary>
public interface ModelWeldingSymbolDefinitions : IEnumerable
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    ModelWeldingSymbolDefinition this[int Index] { get; }
    /// <summary>
    /// Gets and sets the annotation plane for the welding symbol.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Gets and sets the annotation plane definition for the symbol.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Gets and sets the associated geometries. Valid geometries include faces, edges and vertices.
    /// </summary>
    ObjectCollection AssociatedGeometries { get; set; }
    /// <summary>
    /// Gets and sets the geometric entity the welding symbol is attached to.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-only property that returns the leader associated with the model welding symbol.
    /// </summary>
    ModelLeader Leader { get; }
    /// <summary>
    /// Gets and sets the position of the welding symbol in the part or assembly. The point is projected onto the orientation plane.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Method that creates a new ModelWeldingSymbolDefinition.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long value indicating the target index to position this new ModelWeldingSymbolDefinition. The newly created ModelWeldingSymbolDefinition will be placed just before the target index, if not provided the newly created ModelWeldingSymbolDefinition will be placed as the first one.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelWeldingSymbolDefinition Add([In] [MarshalAs(UnmanagedType.Struct)] object? TargetIndex = default);
    /// <summary>
    /// Method that removes the specified ModelWeldingSymbolDefinition from the ModelWeldingSymbolDefinitions collection.
    /// </summary>
    /// <param name="Index">Input Long value indicating the index of the ModelWeldingSymbolDefinition to remove.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that creates a copy of this ModelWeldingSymbolDefinitions object. The new ModelWeldingSymbolDefinitions object is independent of any model welding&nbsp;symbol. It can be edited and used as input to edit an existing model welding&nbsp;symbol or to create a new m.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelWeldingSymbolDefinitions Copy();
}
