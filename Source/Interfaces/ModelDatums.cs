namespace Oblikovati.API;

/// <summary>
/// ModelDatums Object.
/// </summary>
public interface ModelDatums : IEnumerable
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
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelDatum this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns a string value that indicates an unused datum text.
    /// </summary>
    string NextAvailableDatumText { get; }
    /// <summary>
    /// Method that creates a model datum.
    /// </summary>
    /// <param name="Definition">Input ModelDatumDefinition object that defines the model datum to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDatum Add([In] [MarshalAs(UnmanagedType.Interface)] ModelDatumDefinition Definition);
    /// <summary>
    /// Method that creates a model datum definition.
    /// </summary>
    /// <param name="DatumTargetPoints">Input ObjectCollection including the points that define the datum target points. Valid entities for the datum target points are:
    /// WorkPoint
    /// SketchPoint(the SketchPoint should be on the sketch that was created from a planar Face)
    /// GeometryIntent (When GeometryIntent is provided, the point should be on a planar Face. The GeometryIntent object can be created using the CreateGeometryIntent method on the PartComponentDefinition or AssemblyComponentDefinition object.).
    /// When provide the datum target points base on WorkPoint, the WorkPoint objects can not be on the same plane, and no datum target points base on other type of object can be provided. When provide the datum target points base on planar Face, all the datum target points should attach to the same Face or the Faces that are coplanar and from the same feature. When provide SketchPoint as datum target points they should be from the same planar sketch and the sketch should depend on a planar Face.</param>
    /// <param name="DatumTargetPlanes">Optional input ObjectCollection including the AnnotationPlaneDefinition objects that define the datum target planes that control the datum target texts’ orientation.</param>
    /// <param name="DatumTargetTextPositions">Optional input ObjectCollection including the Point objects that define the datum target texts’ positions.</param>
    /// <param name="DatumTargetIndices">Optional input Long array to specify the indices of the datum targets. The item count of this array should be the same as the item count of the DatumTargetPoints.</param>
    /// <param name="DatumTargetType">Optional input the ModelDatumTargetTypeEnum that specifies the datum target type. If not specified the default ModelDatumTargetTypePoint is used.</param>
    /// <param name="DatumTargetAreaValueOne">Optional input Double array that specifies the datum target area size. If not specified the default values will be used. If the DatumTargetType is specified as kModelDatumTargetTypeCircle the values indicate the area diameter, If the DatumTargetType is kModelDatumTargetTypeRectangle the values indicate the area width. For other DatumTargetType values this is ignored.</param>
    /// <param name="DatumTargetAreaValueTwo">Optional input Double array that specifies the datum target area size. If not specified the default values will be used. If the DatumTargetType is specified as kModelDatumTargetTypeRectangle the values indicate the area height. For other DatumTargetType values this is ignored.</param>
    /// <param name="DatumText">Optional input String that specifies the datum label. If not specified an available label will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection DatumTargetPoints, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumTargetPlanes = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumTargetTextPositions = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumTargetIndices = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumTargetType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumTargetAreaValueOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumTargetAreaValueTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DatumText = default);
}
