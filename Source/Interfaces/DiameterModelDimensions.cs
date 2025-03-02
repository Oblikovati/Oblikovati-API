namespace Oblikovati.API;

/// <summary>
/// The DiameterModelDimensions collection object provides access to all of the diameter model dimensions in a part or assembly and provides functionality to create new diameter dimensions.
/// </summary>
public interface DiameterModelDimensions : IEnumerable
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
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    DiameterModelDimension Item { get; }
    /// <summary>
    /// Method that creates a diameter dimension.
    /// </summary>
    /// <param name="Definition">Input DiameterModelDimensionDefinition object that defines the dimension to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    DiameterModelDimension Add([In] [MarshalAs(UnmanagedType.Interface)] DiameterModelDimensionDefinition Definition);
    /// <summary>
    /// Method that creates a diameter dimension definition.&nbsp;This is a not a diameter dimension but an object that encapsulates all of the information that defines a dimension.&nbsp;You use the methods and properties of this object to define the dimension you want to create and then provide it as input to the Add method.
    /// </summary>
    /// <param name="Intent">Input GeometryIntent object that defines the geometry to dimension to.  For a diameter dimension this can be a circular edge, cylindrical face, sketch arc, or sketch circle.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <param name="LandingPosition">Input Point object that specifies the landing position of the dimension.  The point will be projected onto the orientation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    DiameterModelDimensionDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point LandingPosition);
}
