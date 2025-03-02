namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work point defined by the intersection of a line and face.
/// </summary>
public interface LineAndFaceWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Specifies the line of a work point that is defined by the intersection of a line and face.
    /// </summary>
    object Line { get; }
    /// <summary>
    /// Specifies the face of a work point that is defined by the intersection of a line and face.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Line">Line</param>
    /// <param name="Face">Face</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Line, [Out] [MarshalAs(UnmanagedType.Interface)] out Face Face);
}
