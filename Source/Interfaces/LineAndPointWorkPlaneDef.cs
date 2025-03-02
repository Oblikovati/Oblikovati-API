namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane defined normal to a line and through a point.
/// </summary>
public interface LineAndPointWorkPlaneDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    WorkPlane Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets or sets the line of a line and point defined work plane.
    /// </summary>
    object Line { get; }
    /// <summary>
    /// Gets or sets the point of a line and point defined work plane.
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
