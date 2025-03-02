namespace Oblikovati.API;

/// <summary>
/// The MapPointCurve object is used to define a set of mapping points between sections in a loft feature.
/// </summary>
public interface MapPointCurve
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that specifies the number of MapPoints in the set.
    /// </summary>
    int PointCount { get; }
    /// <summary>
    /// Method that sets the position of the map point. The entity implicitly defines which section the point is for. The position of the map points is defined using a 3D coordinate point. If a map point already exists for the section the input entity is a member of, the current map point will be replaced.
    /// </summary>
    /// <param name="Entity">Input entity that is a component of a section. Valid input is a SketchEntity, SketchEntity3D, Edge, WorkPoint or Vertex.</param>
    /// <param name="Value">Input Double that defines the position of the map point along the input entity as a percentage of the length of the entity. The input value should be between 0 and 1.</param>
    [PreserveSig]
    void SetPosition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] double Value);
    /// <summary>
    /// Method that sets the position of the map point using a 3D coordinate. The index corresponds with the section of the same index. If a map point already exists for the section the input entity is a member of, the current map point will be replaced.
    /// </summary>
    /// <param name="SectionIndex">Input Long that identifies which section the map point is being defined for. The index corresponds with the section of the same index.</param>
    /// <param name="Position">Input that defines the coordinate position of the map point. The input point will be projected to the nearest point along the specified section.</param>
    [PreserveSig]
    void SetPositionUsingPoint([In] int SectionIndex, [In] [MarshalAs(UnmanagedType.Interface)] Point Position);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    /// <param name="Entity">Entity</param>
    /// <param name="Result">Result</param>
    [PreserveSig]
    void GetPosition([In] int Index, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Entity, [Out] out double Result);
    /// <summary>
    /// Method that returns the position of the specified map point in 3D space.
    /// </summary>
    /// <param name="Index">Input Long that defines which map point to get the position for. The first map point has an index of 1 and corresponds with the section of the same index.</param>
    /// <returns></returns>
    [PreserveSig]
    Point GetPositionPoint([In] int Index);
    /// <summary>
    /// Method that deletes this set of mapping points for a loft.
    /// </summary>
    [PreserveSig]
    void Delete();
}
