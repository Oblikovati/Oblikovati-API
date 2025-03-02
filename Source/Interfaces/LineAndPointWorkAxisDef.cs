namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis that is along a line and passes through a point.
/// </summary>
public interface LineAndPointWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Property that returns the line used to define a work axis that is along a line and passes through a point. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.
    /// </summary>
    object Line { get; }
    /// <summary>
    /// Property that returns the point used to define a work axis that is along a line and passes through a point.. This object can be a vertex, WorkPoint, SketchPoint, or SketchPoint3D object.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Line">Line</param>
    /// <param name="Point">Point</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Line, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point);
}
