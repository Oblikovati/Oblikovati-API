namespace Oblikovati.API;

/// <summary>
/// The PathEntity object represents a curve within a path.
/// </summary>
public interface PathEntity
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
    /// Property that returns the parent Path of the entity.
    /// </summary>
    Path Parent { get; }
    /// <summary>
    /// Property that returns the geometry of the entity. The geometry is returned such that the entities are connected in a head-to-tail fashion.
    /// </summary>
    object Curve { get; }
    /// <summary>
    /// Property that returns the type of the curve referenced by the path entity. This property allows you to determine what type of object will be returned by the Curve property.
    /// </summary>
    CurveTypeEnum CurveType { get; }
    /// <summary>
    /// Property that gets the sketch entity (2D or 3D) this entity was derived from.
    /// </summary>
    object SketchEntity { get; }
    /// <summary>
    /// Property that returns a Boolean indicating if the parametric flow of the path entity is in the same direction as the sketch entity it was derived from.
    /// </summary>
    bool OpposedToSketchEntity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
