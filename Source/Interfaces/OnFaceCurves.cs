namespace Oblikovati.API;

/// <summary>
/// OnFaceCurves Object.
/// </summary>
public interface OnFaceCurves : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    OnFaceCurve this[int Index] { get; }
    /// <summary>
    /// Creates a new on face curve.
    /// </summary>
    /// <param name="Faces">Input NameValueMap object that specifies an array of faces to create the splines on. The faces are in sequence and a face should be connected with the faces that are before and after it in the sequence, otherwise an error will occur. The format is as below:
    /// <P>Name = “Face1”. Value = A Face object. The number in the Name is 1-based, and can be increased for more faces to be added.</param>
    /// <param name="FitPoints">Input NameValueMap object that contains an array of ObjectCollection objects that each ObjectCollection specifies the fit points for a spline curve on a face. The format is as below:
    /// <P>Name = “Face1”. Value = An ObjectCollection object that contains the Point or SketchPoint3D objects which indicate the fit points positions. The number in the Name is 1-based and can be increased for more ObjectCollection objects to be added. The name in this argument should be matched to the name in the Faces argument so the fit points are located on the corresponding Face object.
    /// <P>If the count of items in this argument is different from that in the Faces argument or the Name are not matched in the Faces and FitPoints argument, an error occurs.</param>
    /// <returns></returns>
    [PreserveSig]
    OnFaceCurve Add([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Faces, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap FitPoints);
}
