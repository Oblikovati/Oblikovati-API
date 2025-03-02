namespace Oblikovati.API;

/// <summary>
/// The CurveAndEntityWorkPointDefinition object that allows you to get and set the information that specifies a work point defined by a curve and another entity.
/// </summary>
public interface CurveAndEntityWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the curve of a curve and entity defined work point. . This object can be an Edge or any 2d or 3d sketch object.
    /// </summary>
    object CurveEntity { get; }
    /// <summary>
    /// Property that returns the Face or WorkPlane object used in defining a work at the intersection of a curve and entity.
    /// </summary>
    object Entity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CurveEntity">CurveEntity</param>
    /// <param name="Entity">Entity</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object CurveEntity, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Entity);
}
