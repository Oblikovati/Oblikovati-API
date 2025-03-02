namespace Oblikovati.API;

/// <summary>
/// MarkDefinition Object.
/// </summary>
public interface MarkDefinition : IEnumerable
{
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    MarkFeature Parent { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returns the number of mark geometry sets currently defined in the definition.
    /// </summary>
    int MarkGeometrySetCount { get; }
    /// <summary>
    /// Read-write property that gets and sets the extent direction. Set this to kSymmetricExtentDirection is invalid when the method is set to kWrapToFaceMethodType.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
    /// <summary>
    /// Method that creates a copy of this MarkDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MarkDefinition Copy();
    /// <summary>
    /// Method that creates a new mark geometry set.
    /// </summary>
    /// <param name="Geometries">Input ObjectCollection object that specifies the sketch geometries to create mark feature.</param>
    /// <param name="pStyle">Input MarkStyle object that specifies mark style.</param>
    /// <returns></returns>
    [PreserveSig]
    MarkGeometrySet AddGeometrySet([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Geometries, [MarshalAs(UnmanagedType.Interface)] MarkStyle pStyle);
    /// <summary>
    /// Method that returns the specified MarkGeometrySet object from the collection.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the MarkGeometrySet to return.</param>
    /// <returns></returns>
    [PreserveSig]
    MarkGeometrySet MarkGeometrySetItem([In] int Index);
    /// <summary>
    /// Method that sets the mark method type.
    /// </summary>
    /// <param name="Method">Input MarkMethodTypeEnum value that indicates which method is applied. When any MarkGeometrySet in this definition sets Mark Through style then the valid method is kProjectionMethodType.</param>
    /// <param name="Faces">Optional input the FaceCollection object. This is required if the method is set to kWrapToFaceMethodType.</param>
    /// <param name="chain">Optional input Boolean value that specifies whether or not to perform chaining of tangent continuous faces. This is ignored if the method is not set to kWrapToFaceMethodType.</param>
    [PreserveSig]
    void SetMethod([In] MarkMethodTypeEnum Method, [In] [MarshalAs(UnmanagedType.Struct)] object? Faces = default, [In] [MarshalAs(UnmanagedType.Struct)] object? chain = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Method">Method</param>
    /// <param name="pFaces">pFaces</param>
    /// <param name="chain">chain</param>
    [PreserveSig]
    void GetMethod();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Method">Method</param>
    /// <param name="pFaces">pFaces</param>
    /// <param name="chain">chain</param>
    [PreserveSig]
    void GetMethod([Out] out MarkMethodTypeEnum Method, [Out] [MarshalAs(UnmanagedType.Struct)] out object pFaces, [Out] [MarshalAs(UnmanagedType.Struct)] out object chain);
}
