namespace Oblikovati.API;

/// <summary>
/// DSLoadDefinition Object.
/// </summary>
public interface DSLoadDefinition
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
    /// Gets the parent DSLoad object this definition object is associated with.&nbsp;If this definition is not associated with a load then this property returns Nothing.
    /// </summary>
    DSLoad Parent { get; }
    /// <summary>
    /// Gets and sets Entity that defines the direction of the load.&nbsp;Valid geometry includes planar and cylindrical faces, and linear edges.
    /// </summary>
    object DirectionEntity { get; set; }
    /// <summary>
    /// Gets and sets the color of the force or torque glyph as seen during the playback of the simulation.&nbsp;The IsDisplayed property controls whether the glyph is displayed or not.
    /// </summary>
    Color GlyphColor { get; set; }
    /// <summary>
    /// Gets and sets the scale of the load glyph. This property is writable when the DSLoadDefinition object has been created using the DSLoads.CreateLoadDefinition or DSLoadDefinition.Copy methods.
    /// </summary>
    double GlyphScale { get; set; }
    /// <summary>
    /// Gets and sets the how the direction of the force or torque is defined.&nbsp;If True, the direction of the force or torque is defined relative to the coordinate system of the component containing the force or torque.&nbsp;If False, the direction of the force or torque.
    /// </summary>
    bool IsAssociativeLoadDirection { get; set; }
    /// <summary>
    /// Gets and sets if the magnitude and direction of this load is defined by vector components or a specified magnitude and direction entity.
    /// </summary>
    bool IsDefinedByVectorComponents { get; set; }
    /// <summary>
    /// Gets and sets whether the direction of the load, when defined by an entity, is in the natural direction defined by the entity or reversed.
    /// </summary>
    bool IsDirectionEntityNaturalDirection { get; set; }
    /// <summary>
    /// Gets and sets if the arrow for the force or torque is displayed during the playback of the simulation.
    /// </summary>
    bool IsDisplayed { get; set; }
    /// <summary>
    /// Gets the location of the load. The location is defined by specifying geometry and the location coordinate is inferred from the selected geometry.&nbsp;This provides that inferred coordinate regardless of the entity that was used to specify the location.
    /// </summary>
    Point Location { get; }
    /// <summary>
    /// Gets and sets Entity that defines the location of the load.
    /// </summary>
    object LocationEntity { get; set; }
    /// <summary>
    /// Gets the DSValue object that defines the magnitude of the load. The value of the magnitude can be accessed through the returned DSValue object.
    /// This property returns Nothing in the case where the IsDefinedByVectorComponents is True. To change the definition of the load to be defined by a magnitude and direction use the SetByMagnitudeAndDirection method.
    /// Setting the magnitude using the SetValueUsingArray method of the DSValue object is currently limited to motion, magnitude, and x,y,z coordinates.
    /// </summary>
    DSValue Magnitude { get; }
    /// <summary>
    /// Gets a Vector indicating the vector of the load.&nbsp;This can be used to get the load vector regardless of whether it has been defined using geometry or the x, y, z, components.
    /// </summary>
    Vector Vector { get; }
    /// <summary>
    /// Gets the DSValue object that defines the X component of the vector. This property returns Nothing in the case where the IsDefinedByVectorComponents is False.&nbsp;To change the definition of the load to be defined by a vector use the SetByVector method.
    /// </summary>
    DSValue VectorXComponent { get; }
    /// <summary>
    /// Gets the DSValue object that defines the Y component of the vector. This property returns Nothing in the case where the IsDefinedByVectorComponents is False.&nbsp;To change the definition of the load to be defined by a vector use the SetByVector method.
    /// </summary>
    DSValue VectorYComponent { get; }
    /// <summary>
    /// Gets the DSValue object that defines the Z component of the vector. This property returns Nothing in the case where the IsDefinedByVectorComponents is False.&nbsp;To change the definition of the load to be defined by a vector use the SetByVector method.
    /// </summary>
    DSValue VectorZComponent { get; }
    /// <summary>
    /// Gets and sets whether the load is suppressed.
    /// </summary>
    bool IsSuppressed { get; set; }
    /// <summary>
    /// Creates a copy of this DSLoadDefinition object. The new DSLoadDefinition object is independent of any load. It can edited and used as input to edit an existing load or to create a new load.&nbsp;Creating a copy of a definition, editing it, and then assigning it back to the load can be a more efficient way of editing multiple inputs because it results in a single recompute.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DSLoadDefinition Copy();
    /// <summary>
    /// Specifies the direction and magnitude of this load to be defined by a magnitude value and a direction defined by an entity.
    /// </summary>
    /// <param name="Magnitude">Input Variant value that specifies the magnitude of the load.  This can be either a Double indicating the load in database units, a String containing a valid expression that results in either force or torque units, or a DSGraph object.</param>
    /// <param name="DirectionEntity">Input entity that defines the direction of the load.  Valid geometry includes planar and cylindrical faces, and linear edges.</param>
    /// <param name="NaturalEntityDirection">Input Boolean value that specifies if the direction is the same as the natural direction of the direction entity or reversed.</param>
    [PreserveSig]
    void SetByMagnitudeAndDirection([In] [MarshalAs(UnmanagedType.Struct)] object Magnitude, [In] [MarshalAs(UnmanagedType.IDispatch)] object DirectionEntity, [In] bool NaturalEntityDirection);
    /// <summary>
    /// Specifies the direction and magnitude of this load to be defined by the x, y, z components of a vector.
    /// </summary>
    /// <param name="XComponent">Input Variant value that specifies the X component value of the vector.  This can be either a Double indicating the load in database units, a String containing a valid expression that results in either force or torque units, or a DSValueGraph object.</param>
    /// <param name="YComponent">Input Variant value that specifies the Y component value of the vector.  This can be either a Double indicating the load in database units, a String containing a valid expression that results in either force or torque units, or a DSValueGraph object.</param>
    /// <param name="ZComponent">Input Variant value that specifies the Z component value of the vector.  This can be either a Double indicating the load in database units, a String containing a valid expression that results in either force or torque units, or a DSValueGraph object.</param>
    [PreserveSig]
    void SetByVector([In] [MarshalAs(UnmanagedType.Struct)] object XComponent, [In] [MarshalAs(UnmanagedType.Struct)] object YComponent, [In] [MarshalAs(UnmanagedType.Struct)] object ZComponent);
}
