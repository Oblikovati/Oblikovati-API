namespace Oblikovati.API;

/// <summary>
/// The Centermark object represents a center mark on a sheet.
/// </summary>
public interface Centermark
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
    /// Property that returns the parent Sheet object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the center mark is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that gets the centermark type.
    /// </summary>
    CentermarkTypeEnum CentermarkType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object ModelWorkFeature { get; }
    /// <summary>
    /// Property that returns whether the centermark is sick. Returns False if the centermark is sick.
    /// </summary>
    bool Attached { get; }
    /// <summary>
    /// Read-write property that gets and sets the position of the center mark extension point. This property can return Nothing in the case where the extension lines have been turned off or the end of the extension line is clipped of as the result of a broken view.
    /// </summary>
    Point2d ExtensionPointOne { get; set; }
    /// <summary>
    /// Property that returns the direction of the extension point. This can be used to understand the direction the first extension point can be moved.
    /// </summary>
    UnitVector2d ExtensionPointOneDirection { get; }
    /// <summary>
    /// Read-write property that gets and sets the position of the center mark extension point. This property can return Nothing in the case where the extension lines have been turned off or the end of the extension line is clipped of as the result of a broken view.
    /// </summary>
    Point2d ExtensionPointTwo { get; set; }
    /// <summary>
    /// Property that returns the direction of the extension point. This can be used to understand the direction the second extension point can be moved.
    /// </summary>
    UnitVector2d ExtensionPointTwoDirection { get; }
    /// <summary>
    /// Read-write property that gets and sets the position of the center mark extension point. This property can return Nothing in the case where the extension lines have been turned off or the end of the extension line is clipped of as the result of a broken view.
    /// </summary>
    Point2d ExtensionPointThree { get; set; }
    /// <summary>
    /// Property that returns the direction of the extension point. This can be used to understand the direction the third extension point can be moved.
    /// </summary>
    UnitVector2d ExtensionPointThreeDirection { get; }
    /// <summary>
    /// Read-write property that gets and sets the position of the center mark extension point. This property can return Nothing in the case where the extension lines have been turned off or the end of the extension line is clipped of as the result of a broken view.
    /// </summary>
    Point2d ExtensionPointFour { get; set; }
    /// <summary>
    /// Property that returns the direction of the extension point. This can be used to understand the direction the fourth extension point can be moved.
    /// </summary>
    UnitVector2d ExtensionPointFourDirection { get; }
    /// <summary>
    /// Property that returns the position of the center of the center mark on the sheet.
    /// </summary>
    Point2d Position { get; }
    /// <summary>
    /// Property that returns the a collection of associated Centerline objects.
    /// </summary>
    ObjectsEnumerator Centerlines { get; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the style associated with this center mark.
    /// </summary>
    CentermarkStyle Style { get; set; }
    /// <summary>
    /// Property that returns the entity the center mark is associated with.
    /// </summary>
    object AttachedEntity { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the extension lines associated with this center mark are visible or not.
    /// </summary>
    bool ExtensionLinesVisible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the Centermark.
    /// </summary>
    [PreserveSig]
    void Delete();
}
