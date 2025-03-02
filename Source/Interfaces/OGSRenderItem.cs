namespace Oblikovati.API;

/// <summary>
/// OGS Render Item Object.
/// </summary>
public interface OGSRenderItem
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Propod that gets the ambient color.
    /// </summary>
    Color AmbientColor { get; }
    /// <summary>
    /// Propod that gets the diffuse color.
    /// </summary>
    Color DiffuseColor { get; }
    /// <summary>
    /// Propod that gets the specular color.
    /// </summary>
    Color SpecularColor { get; }
    /// <summary>
    /// Propod that gets the emissive color.
    /// </summary>
    Color EmissiveColor { get; }
    /// <summary>
    /// Method that gets the Transmission color.
    /// </summary>
    Color TransmissionColor { get; }
    /// <summary>
    /// Gets the opacity.
    /// </summary>
    double Opacity { get; }
    /// <summary>
    /// Gets the AmbientFactor.
    /// </summary>
    double AmbientFactor { get; }
    /// <summary>
    /// Gets the DiffuseFactor.
    /// </summary>
    double DiffuseFactor { get; }
    /// <summary>
    /// Gets the Shininess.
    /// </summary>
    double Shininess { get; }
    /// <summary>
    /// Gets the Gloss.
    /// </summary>
    double Gloss { get; }
    /// <summary>
    /// Gets the OGS Geometry Type.
    /// </summary>
    OGSGeometryTypeEnum OGSGeometryType { get; }
    /// <summary>
    /// Gets the OGS Primitive Type.
    /// </summary>
    OGSPrimitiveTypeEnum OGSPrimitiveType { get; }
    /// <summary>
    /// Gets Texture full File Name.
    /// </summary>
    string TextureFilename { get; }
    /// <summary>
    /// Gets the RenderItemsEnumerator.
    /// </summary>
    OGSRenderItemsEnumerator SubRenderItems { get; }
    /// <summary>
    /// Gets the transformation of the diffuse texture.
    /// </summary>
    Matrix TextureTransformation { get; }
    /// <summary>
    /// Gets the transformation of this render item.
    /// </summary>
    Matrix Transformation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="sType">sType</param>
    /// <param name="materialX">materialX</param>
    /// <param name="itemName">itemName</param>
    [PreserveSig]
    void GetMaterialString([In] OGSMaterialStringTypeEnum sType, [Out] [MarshalAs(UnmanagedType.BStr)] out string materialX, [Out] [MarshalAs(UnmanagedType.BStr)] out string itemName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void GetVerticesData([Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates);
}
