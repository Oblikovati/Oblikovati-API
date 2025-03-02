namespace Oblikovati.API;

/// <summary>
/// The ProfileEntity object represents a curve within a profile path.
/// </summary>
public interface ProfileEntity
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
    /// Property that returns the parent ProfilePath of the entity.
    /// </summary>
    ProfilePath Parent { get; }
    /// <summary>
    /// Property that returns the geometry of the entity. The geometry is returned such that the entities are connected in a head-to-tail fashion.
    /// </summary>
    object Curve { get; }
    /// <summary>
    /// Property that returns the type of the curve referenced by the profile entity. This property allows you to determine what type of object will be returned by the Curve property.
    /// </summary>
    Curve2dTypeEnum CurveType { get; }
    /// <summary>
    /// Property that returns the sketch entity this profile entity was derived from.
    /// </summary>
    SketchEntity SketchEntity { get; }
    /// <summary>
    /// Property that gets the that defines the start of the profile entity. This property is not valid in the case where the curve is a periodic curve, i.e. circle, ellipse, etc.
    /// </summary>
    SketchPoint StartSketchPoint { get; }
    /// <summary>
    /// Property that returns the that defines the end of the profile entity. This property is not valid in the case where the curve is a periodic curve, i.e. circle, ellipse, etc.
    /// </summary>
    SketchPoint EndSketchPoint { get; }
    /// <summary>
    /// Property that returns a Boolean indicating if the parametric flow of the profile entity is in the same direction as the sketch entity it was derived from.
    /// </summary>
    bool OpposedToSketchEntity { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
