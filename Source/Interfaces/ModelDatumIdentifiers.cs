namespace Oblikovati.API;

/// <summary>
/// ModelDatumIdentifiers Object.
/// </summary>
public interface ModelDatumIdentifiers : IEnumerable
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
    ModelDatumIdentifier this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns a string value that indicates an unused datum text.
    /// </summary>
    string NextAvailableDatumText { get; }
    /// <summary>
    /// Read-only property that returns an array of characters with comma as delimiter which will be excluded from the datum text list.
    /// </summary>
    string ExcludedDatumTextCharacters { get; }
    /// <summary>
    /// Method that creates a datum identifier symbol.
    /// </summary>
    /// <param name="Definition">Input ModelDatumIdentifierDefinition object that defines the datum identifer to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumIdentifier Add([In] [MarshalAs(UnmanagedType.Interface)] ModelDatumIdentifierDefinition Definition);
    /// <summary>
    /// Method that creates a datum identifier definition.
    /// </summary>
    /// <param name="Intent">Input GeometryIntent object that defines the geometry to attach the symbol to.</param>
    /// <param name="AnnotationPlaneDefinition">Input AnnotationPlaneDefinition object that defines the annotation plane the annotation will be created on.  An existing annotation plane can be specified by using the AnnotationPlaneDefinition object associated with the existing annotation plane.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumIdentifierDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] [MarshalAs(UnmanagedType.Interface)] AnnotationPlaneDefinition AnnotationPlaneDefinition, [In] [MarshalAs(UnmanagedType.Interface)] Point TextPosition);
}
