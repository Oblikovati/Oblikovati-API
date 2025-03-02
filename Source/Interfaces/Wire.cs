namespace Oblikovati.API;

/// <summary>
/// A Wire object represents a set of 3D curves.  They are used in several different areas within the Inventor API.  The bend and fold lines on the 3D flattened model of a sheet metal part are returned as a Wire object.  It is also used to define 3D curves that are used as input when using some of the functions to create transient B-Rep bodies.
/// </summary>
public interface Wire
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    SurfaceBody Parent { get; }
    /// <summary>
    /// Property that returns the EdgeUses collection object associated with this Wire.
    /// </summary>
    EdgeUses EdgeUses { get; }
    /// <summary>
    /// Gets the <link Inventor::Edges, Edges> referenced by this Wire.
    /// </summary>
    Edges Edges { get; }
    /// <summary>
    /// Read-only property that indicates if this wire is planar or not.
    /// </summary>
    bool IsPlanar { get; }
    /// <summary>
    /// Method that computes the offset for a planar wire.&nbsp;A SurfaceBody containing the resulting Wire object(s) is returned.&nbsp;It’s possible that the offset result of a single wire can result in multiple wires.
    /// </summary>
    /// <param name="Normal">Input UnitVector object that defines the normal of the wire.  This vector must be normal to the plane of the wire and is used to specify the positive side of the plane.  This is used to determine the side to offset the curves to.  A positive offset distance is in the direction of the cross product (wire_tangent x wire_plane_normal). A negative offset is in the opposite direction.</param>
    /// <param name="Distance">Input double in centimeters that specifies the offset distance of the new wire.  See the description for the Normal argument to see how a positive or negative value for the distance specifies the direction of the offset.</param>
    /// <param name="CornerClosureType">Input enum value that defines how to close the external corners of the offset. The valid values are listed below:
    /// kCircularCornerClosure - Circular arcs are attached tangentially to the offset edges so that gaps are replaced by rounded corners. In the picture below, the original curves are black, the offset curves are green and the circular rounded corner is red.
    /// kLinearCornerClosure - Linear extensions are attached tangentially to offset edges where there is a gap. The gap is closed where the extensions intersect, giving a sharp corner. In the picture below, the original curves are black, the offset curves are green and the linear extended corner is red.
    /// kExtendCornerClosure - Offset edges are extended smoothly where there is a gap, with the extension depending on the curve type. The gap is closed where the extensions intersect, giving a sharp corner. This method may fall back to using linear extensions or circular arcs if there is a problem.</param>
    /// <returns></returns>
    [PreserveSig]
    Wires OffsetPlanarWire([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal, [In] double Distance, [In] OffsetCornerClosureTypeEnum CornerClosureType);
}
