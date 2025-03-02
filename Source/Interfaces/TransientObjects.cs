namespace Oblikovati.API;

/// <summary>
/// Object through which all general transient objects are constructed.
/// </summary>
public interface TransientObjects
{
    /// <summary>
    /// Constructs a new TranslationContext object, used in TranslatorAddin workflows.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TranslationContext CreateTranslationContext();
    /// <summary>
    /// Method that constructs a new DataMedium object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DataMedium CreateDataMedium();
    /// <summary>
    /// Constructs a new NameValueMap object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    NameValueMap CreateNameValueMap();
    /// <summary>
    /// Constructs a new ObjectCollection object. If an ObjectsEnumerator is passed in, the collection starts off containing the enumerated objects.
    /// </summary>
    /// <param name="ObjectsEnumerator">Input Variant that contains the enumerated objects to place in the collection.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollection CreateObjectCollection([In] [MarshalAs(UnmanagedType.Struct)] object? ObjectsEnumerator = default);
    /// <summary>
    /// Constructs a new ObjectCollectionByVariant object. If an ObjectsEnumeratorByVariant is passed in, the collection starts off containing the enumerated objects.
    /// </summary>
    /// <param name="ObjectsEnumeratorByVariant">Input Variant that contains the enumerated objects to place in the collection.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectCollectionByVariant CreateObjectCollectionByVariant([In] [MarshalAs(UnmanagedType.Struct)] object? ObjectsEnumeratorByVariant = default);
    /// <summary>
    /// Method creates a new EdgeCollection object. Optionally, the resulting EdgeCollection can be initialized with the contents of an enumerator containing edges that is passed in. Typically, an empty EdgeCollection will be created and populated using the Add method of the EdgeCollection object.
    /// </summary>
    /// <param name="ObjectsEnumerator">Input enumerator object that contains edges. For example, the Edges object returned by the Edges property of a face can be used.</param>
    /// <returns></returns>
    [PreserveSig]
    EdgeCollection CreateEdgeCollection([In] [MarshalAs(UnmanagedType.Struct)] object? ObjectsEnumerator = default);
    /// <summary>
    /// Constructs a new FaceCollection object. If an ObjectsEnumerator is passed in, the collection starts off containing the enumerated objects.
    /// </summary>
    /// <param name="ObjectsEnumerator">Optional objects enumerator.</param>
    /// <returns></returns>
    [PreserveSig]
    FaceCollection CreateFaceCollection([In] [MarshalAs(UnmanagedType.Struct)] object? ObjectsEnumerator = default);
    /// <summary>
    /// Method to construct a new Color object.
    /// </summary>
    /// <param name="Red">Input Byte that specifies the red component of the color. This value must be between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">Input Byte that specifies the blue component of the color. This value must be between 0 and 255.</param>
    /// <param name="Opacity">Optional input Double that specifies the opacity of the color. The opacity is defined using a value between 0 and 1. A value of 0 indicates complete translucency while a value of 1 is completely opaque. If not specified this argument defaults to 1.</param>
    /// <returns></returns>
    [PreserveSig]
    Color CreateColor([In] byte Red, [In] byte Green, [In] byte Blue, [In] double? Opacity = default);
    /// <summary>
    /// Constructs a unique signature for a string.
    /// </summary>
    /// <param name="StringToSign">Input String value to get the signature GUID.</param>
    /// <returns></returns>
    [PreserveSig]
    string CreateSignatureString([In] [MarshalAs(UnmanagedType.BStr)] string StringToSign);
    /// <summary>
    /// Method that creates a new FileMetadata object. The newly created FileMetadata is returned.
    /// </summary>
    /// <param name="FullFileName">Optional input string object that specifies a full file name (with the extension and the path).</param>
    /// <returns></returns>
    [PreserveSig]
    FileMetadata CreateFileMetadata([In] [MarshalAs(UnmanagedType.Struct)] object? FullFileName = default);
    /// <summary>
    /// Constructs a new Camera object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Camera CreateCamera();
}
