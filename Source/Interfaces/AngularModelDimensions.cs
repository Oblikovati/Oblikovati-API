namespace Oblikovati.API;

/// <summary>
/// The AngularModelDimensions collection object provides access to all of the angular model dimensions in a part or assembly and provides functionality to create new angular dimensions.
/// </summary>
public interface AngularModelDimensions : IEnumerable
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
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    AngularModelDimension this[object Index] { get; }
    /// <summary>
    /// Method that creates an angular dimension.
    /// </summary>
    /// <param name="Definition">Input AngularModelDimensionDefinition object that defines the dimension to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    AngularModelDimension Add([In] [MarshalAs(UnmanagedType.Interface)] AngularModelDimensionDefinition Definition);
    /// <summary>
    /// Method that creates an angular dimension definition.&nbsp;This is a not an angular dimension but an object that encapsulates all of the information that defines a dimension.&nbsp;You use the methods an properties of this object to define the dimension you want to create and then provide it as input to the Add method.
    /// </summary>
    /// <param name="IntentOne">Input GeometryIntent object that defines the first geometry to dimension to. The GeometryIntent object can be created using the CreateGeometryIntent method on the PartComponentDefinition or AssemblyComponentDefinition object.
    /// Valid entity combinations for the IntentOne, IntentTwo, and IntentThree arguments are:
    /// Three points (Vertex, WorkPoint, SketchPoint, or SketchPoint3D objects)
    /// Two linear entities (linear Edge, WorkAxis, SketchLine, SketchLine3D)
    /// A plane (planar face or work plane) and a linear entity (linear Edge, WorkAxis, SketchLine, SketchLine3D).
    /// Two planes (planar face or work plane)</param>
    /// <param name="IntentTwo">Input entity that specifies the second geometry to dimension. In the cases where the second entity is not needed this argument should be set to Nothing (null).</param>
    /// <param name="IntentThree">Input entity that specifies the third geometry to dimension. In the cases where the third entity is not needed this argument should be set to Nothing (null).</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <param name="TextPosition">Input Point object that specifies the position of the dimension text.  The point will be projected onto the orientation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    AngularModelDimensionDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentTwo, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentThree, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point TextPosition);
}
