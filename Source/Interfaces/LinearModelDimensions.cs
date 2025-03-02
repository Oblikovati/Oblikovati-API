namespace Oblikovati.API;

/// <summary>
/// The LinearModelDimensions collection object provides access to all of the linear model dimensions in a part or assembly and provides functionality to create new linear dimensions.
/// </summary>
public interface LinearModelDimensions : IEnumerable
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
    LinearModelDimension Item { get; }
    /// <summary>
    /// Method that creates a linear dimension.
    /// </summary>
    /// <param name="Definition">Input LinearModelDimensionDefinition object that defines the dimension to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearModelDimension Add([In] [MarshalAs(UnmanagedType.Interface)] LinearModelDimensionDefinition Definition);
    /// <summary>
    /// Method that creates a linear dimension definition.&nbsp;This is a not a linear dimension but an object that encapsulates all of the information that defines a dimension.&nbsp;You use the methods an properties of this object to define the dimension you want to create and then provide it as input to the Add method.
    /// </summary>
    /// <param name="IntentOne">Input GeometryIntent object that defines the first geometry to dimension to. The GeometryIntent object can be created using the CreateGeometryIntent method on the PartComponentDefinition or AssemblyComponentDefinition object.
    /// Valid entity combinations for the IntentOne and IntentTwo arguments are:
    /// Two points.
    /// Two linear entities. (Non-parallel lines will result in an angular dimension.)
    /// A linear entity and a point.
    /// A point and a linear entity.
    /// One linear entity.
    /// One circular entity (with DimensionType set to kAlignedDimensionType for chord length and kArcLengthDimensionType for arc length)</param>
    /// <param name="IntentTwo">Input entity that specifies the second geometry to dimension. In the cases where there is only one entity needed this argument should be set to Nothing (null);</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <param name="TextPosition">Input Point object that specifies the position of the dimension text.  The point will be projected onto the orientation plane.</param>
    /// <param name="DimensionType">Input DimensionTypeEnum that specifies the linear dimension type. Valid values (based on the input intents) are kAlignedDimensionType, kHorizontalDimensionType, kVerticalDimensionType, kArcLengthDimensionType, kSymmetricDimensionType, kDiametricDimensionType, and kArcLengthDimensionType
    /// An error will occur if the specified type is invalid for the input intents. For instance, kSymmetricDimensionType & kDiametricDimensionType are valid only when two intents are providedone intent is provided as input. the first intent (an edge) is specified. kArcLengthDimensionType is only valid if two intents are supplied and they represent end points of an arc or a single intent is supplied and it represents an arc.</param>
    /// <returns></returns>
    [PreserveSig]
    LinearModelDimensionDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentTwo, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point TextPosition, [In] DimensionTypeEnum DimensionType);
}
