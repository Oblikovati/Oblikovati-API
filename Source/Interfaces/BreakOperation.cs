namespace Oblikovati.API;

/// <summary>
/// A BreakOperation object represents a break applied to a drawing view. Editing or deleting this BreakOperation object will modify all affected views.
/// </summary>
public interface BreakOperation
{
    /// <summary>
    /// Property that returns all the DrawingView objects affected by this break operation. Multiple drawing views can be affected by a break operation if children views inherit breaks or if the break is propagated up to the parent view.
    /// </summary>
    ObjectsEnumerator AllAffectedViews { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets the break style.
    /// </summary>
    BreakStyleEnum BreakStyle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the appearance of the break lines.
    /// </summary>
    int DisplayLevel { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the end point of the break in sheet space.
    /// </summary>
    Point2d EndPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the gap (in centimeters) between the break lines.
    /// </summary>
    double Gap { get; set; }
    /// <summary>
    /// Property that returns whether this break operation is the source for inherited break operations. The property returns True if there are no related break operations. If the property returns False, use the SourceBreakOperation property to find the source break.
    /// </summary>
    bool IsSourceBreakOperation { get; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the midpoint of the break in sheet space.
    /// </summary>
    Point2d MidPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the number of break symbols to use for a structural style break.
    /// </summary>
    int NumberOfSymbols { get; set; }
    /// <summary>
    /// Property that returns whether the orientation of the break is horizontal or vertical. Possible return values are kHorizontalBreakOrientation and kVerticalBreakOrientation.
    /// </summary>
    BreakOrientationEnum Orientation { get; }
    /// <summary>
    /// Property that returns the parent drawing view from which this BreakOperation was retrieved.
    /// </summary>
    DrawingView Parent { get; }
    /// <summary>
    /// Property that returns the source BreakOperation object. For instance, if a projected view inherits the break from the parent base view, this property on the BreakOperation retrieved from the projected view will return the corresponding BreakOperation from the base view. If this BreakOperation itself is the source, the property returns nothing.
    /// </summary>
    BreakOperation SourceBreakOperation { get; }
    /// <summary>
    /// Read-write property that gets and sets the start point of the break in sheet space.
    /// </summary>
    Point2d StartPoint { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that deletes the break operation from the drawing view. The break is deleted from all other affected drawing views as well.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
