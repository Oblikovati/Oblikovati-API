namespace Oblikovati.API;

/// <summary>
/// The ModelAnnotations collection object provides access to all of the annotations in a part or assembly.  This includes dimensions and other types of annotations.
/// </summary>
public interface ModelAnnotations : IEnumerable
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
    /// Method that returns the specified model annotation object from the collection.
    /// </summary>
    ModelAnnotation Item { get; }
    /// <summary>
    /// Read-only property that returns the ModelFeatureControlFrames collection object.&nbsp;This object provides access to all of the feature controls frames in the part or assembly.
    /// </summary>
    ModelFeatureControlFrames ModelFeatureControlFrames { get; }
    /// <summary>
    /// Read-only property that returns the ModelSurfaceTextureSymbols collection object.&nbsp;This object provides access to all of the surface texture symbols in the part or assembly.
    /// </summary>
    ModelSurfaceTextureSymbols ModelSurfaceTextureSymbols { get; }
    /// <summary>
    /// Read-only property that returns the ModelDimensions collection object.&nbsp;This object provides access to all of the model dimensions in the part or assembly.
    /// </summary>
    ModelDimensions ModelDimensions { get; }
    /// <summary>
    /// Read-only property that returns the ModelHoleThreadNotes collection object.&nbsp;This object provides access to all of the model dimensions in the part or assembly.
    /// </summary>
    ModelHoleThreadNotes ModelHoleThreadNotes { get; }
    /// <summary>
    /// Read-only property that returns the ModelLeaderNotes collection object.&nbsp;This object provides access to all of the model dimensions in the part or assembly.
    /// </summary>
    ModelLeaderNotes ModelLeaderNotes { get; }
    /// <summary>
    /// Read-only property that returns the ModelDatumIdentifiers collection object. This object provides access to all of the datum ID’s in the part or assembly.
    /// </summary>
    ModelDatumIdentifiers ModelDatumIdentifiers { get; }
    /// <summary>
    /// Read-only property that returns ModelCompositeAnnotations collection object.
    /// </summary>
    ModelCompositeAnnotations ModelCompositeAnnotations { get; }
    /// <summary>
    /// Returns ModelGeneralNotes collection object.
    /// </summary>
    ModelGeneralNotes ModelGeneralNotes { get; }
    /// <summary>
    /// Returns the ModelDatums collection object.
    /// </summary>
    ModelDatums ModelDatums { get; }
    /// <summary>
    /// Returns the ModelWeldingSymbols collection object.
    /// </summary>
    ModelWeldingSymbols ModelWeldingSymbols { get; }
    /// <summary>
    /// Method that determines all of the valid annotation planes for the given input.&nbsp;The definitions for these annotation planes is returned as a collection, allowing you to select the desired annotation plane to use when creating annotation.
    /// </summary>
    /// <param name="AnnotationType">Input AnnotationTypeEnum that defines the type of annotation you intend on using the annotation plane to create.</param>
    /// <param name="IntentOne">Input GeometryIntent object that defines the first geometry that specifies the position of the annotation plane.</param>
    /// <param name="IntentTwo">Optional Input GeometryIntent object that defines the second geometry that specifies the position of the annotation plane.  If there is only one geometry defininng the annotation plane, you can pass Nothing for this argument.</param>
    /// <param name="IntentThree">Optional Input GeometryIntent object that defines the third geometry that specifies the position of the annotation plane.  If there is only one or two geometries defining the annotation plane, you can pass Nothing for this argument.</param>
    /// <param name="XAxis">Input linear entity that defines the x-axis of the annotation plane.  If not provided a default orientation is determined.  A valid input object for the axis is a linear edge, work axis, 2D sketch line.</param>
    /// <returns></returns>
    [PreserveSig]
    AnnotationPlaneDefinitionsEnumerator CreateAnnotationPlaneDefinitionUsingIntents([In] ObjectTypeEnum AnnotationType, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent IntentOne, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentTwo = default, [In] [MarshalAs(UnmanagedType.Struct)] object? IntentThree = default, [In] [MarshalAs(UnmanagedType.Struct)] object? XAxis = default);
    /// <summary>
    /// Method that returns an annotation plane definition for the given planar entity.&nbsp;The object returned is not an annotation plane, but is the information that defines a plane and can be used to create an annotation plane when an annotation is created.
    /// </summary>
    /// <param name="Plane">Input planar entity that the annotation plane will lie on.  The input object can be a planar face or work plane</param>
    /// <param name="XAxisDirection">Input linear entity that defines the x-axis of the annotation plane.  If not provided a default orientation is determined.  A valid input object for the axis is a linear edge, work axis, 2D sketch line.</param>
    /// <returns></returns>
    [PreserveSig]
    AnnotationPlaneDefinition CreateAnnotationPlaneDefinitionUsingPlane([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Struct)] object? XAxisDirection = default);
}
