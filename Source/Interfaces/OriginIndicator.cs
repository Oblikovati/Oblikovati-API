namespace Oblikovati.API;

/// <summary>
/// The OriginIndicator object represents an origin indicator for ordinate dimensions and hole tables placed on a drawing view.
/// </summary>
public interface OriginIndicator
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
    /// <P; tab-stops: 40.5pt">Property that specifies whether the origin indicator is attached to an origin point.
    /// </summary>
    bool Attached { get; }
    /// <summary>
    /// Gets and sets whether the origin indicator should be hidden.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets and sets the origin point to which the origin indicator is attached. Valid intent values are points that specify geometry to which the origin indicator can be attached.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Gets and sets the leader style associated with the origin indicator. The line format properties are the only properties of the leader style that are applicable to the origin indicator; other leader style properties have no effect on the origin indicator.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Gets and sets the layer associated with the origin indicator.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the relative X coordinate of the origin indicator, this property will return a double value in centimeter units. When setting a value, the units of the specified value will be assumed to be centimeters.
    /// </summary>
    double RelativeX { get; set; }
    /// <summary>
    /// Gets and sets the relative Y coordinate of the origin indicator, this property will return a double value in centimeter units. When setting a value, the units of the specified value will be assumed to be centimeters.
    /// </summary>
    double RelativeY { get; set; }
    /// <summary>
    /// Read-only property that returns whether the origin indicator is used by any dimensions or tables.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Method that deletes this origin indicator. This fails if this origin indicator is referenced by ordinate dimensions or hole tables.
    /// </summary>
    /// <param name="ForceToDelete">Optional  input Boolean value that specifies  whether to force to delete the origin indicator or not. If set this to False and the OriginIndicator.InUse returns True then the delete will fail. If set this to True and the OriginIndicator.InUse returns True then the delete will also delete the referencing dimensions and tables.</param>
    [PreserveSig]
    void Delete([In] [MarshalAs(UnmanagedType.Struct)] object? ForceToDelete = default);
}
