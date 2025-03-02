namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work point defined by the intersection of two lines.
/// </summary>
public interface TwoLinesWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the first line of a work point that is defined by the intersection of two lines. This object can be a linear Edge, WorkAxis, or SketchLine object.
    /// </summary>
    object Line1 { get; }
    /// <summary>
    /// Property that returns the second line of a work point that is defined by the intersection of two lines. This object can be a linear Edge, WorkAxis, or SketchLine object..
    /// </summary>
    object Line2 { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Line1">Line1</param>
    /// <param name="Line2">Line2</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Line1, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Line2);
}
