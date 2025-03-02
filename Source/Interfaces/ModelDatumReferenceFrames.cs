namespace Oblikovati.API;

/// <summary>
/// ModelDatumReferenceFrames Object.
/// </summary>
public interface ModelDatumReferenceFrames : IEnumerable
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
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    ModelDatumReferenceFrame this[object Index] { get; }
    /// <summary>
    /// Adds a new ModelDatumReferenceFrame object.
    /// </summary>
    /// <param name="Definition">Input ModelDatumReferenceFrameDefinition object that specifies the inputs to create a new ModelDatumReferenceFrame.</param>
    /// <param name="ClientId">Optional input String value that uniquely identifies the client. This is the CLSID of the AddIn in a string form, e.g. "{C9A6C580-3817-11D0-BE4E-080036E87B02}".</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumReferenceFrame Add([In] [MarshalAs(UnmanagedType.Interface)] ModelDatumReferenceFrameDefinition Definition, [In] [MarshalAs(UnmanagedType.Struct)] object? ClientId = default);
    /// <summary>
    /// Creates a model datum reference frame definition.
    /// </summary>
    /// <param name="CoordinateSystem">Input Matrix that specifies the model datum reference frame coordinate system.</param>
    /// <param name="PrimaryDatum">Input ModelToleranceFeature object that specifies the primary datum.</param>
    /// <param name="SecondaryDatum">Optional  input ModelToleranceFeature object that specifies the secondary datum.</param>
    /// <param name="TertiaryDatum">Optional  input ModelToleranceFeature object that specifies the tertiary datum.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumReferenceFrameDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] Matrix CoordinateSystem, [In] [MarshalAs(UnmanagedType.Interface)] ModelToleranceFeature PrimaryDatum, [In] [MarshalAs(UnmanagedType.Struct)] object? SecondaryDatum = default, [In] [MarshalAs(UnmanagedType.Struct)] object? TertiaryDatum = default);
}
