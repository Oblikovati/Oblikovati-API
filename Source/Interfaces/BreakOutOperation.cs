namespace Oblikovati.API;

/// <summary>
/// A BreakOutOperation object represents a break out applied to a drawing view. Editing or deleting this BreakOutOperation object will modify all affected views.
/// </summary>
public interface BreakOutOperation
{
    /// <summary>
    /// Property that returns all the DrawingView objects affected by this break out operation. Multiple drawing views can be affected by a break out operation if children views inherit break outs.
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
    /// Property returns how the depth of the break out is defined. To change to another type use the DepthSource property.
    /// </summary>
    BreakOutDepthTypeEnum DepthType { get; }
    /// <summary>
    /// Property that returns the parent drawing view from which this BreakOutOperation was retrieved.
    /// </summary>
    DrawingView Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the sketch profile used for the break out.
    /// </summary>
    Profile Profile { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to section all parts in the break out area.
    /// </summary>
    bool SectionAllParts { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether or not to display the components within the section cut.
    /// </summary>
    bool DisplayComponentsWithinTheSectionCut { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that deletes the break out operation from the drawing view. The break out is deleted from all other affected drawing views as well.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DepthSource">DepthSource</param>
    /// <param name="DepthValue">DepthValue</param>
    [PreserveSig]
    void GetDepth([Out] [MarshalAs(UnmanagedType.IDispatch)] out object DepthSource, [Out] out double DepthValue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that sets the depth of the break out.
    /// </summary>
    /// <param name="DepthSource">Graphic object that defines the depth of the break out. This argument is optional in the case where the depth is defined by a point (DepthType property returns kFromPointBreakOutType) and you only want to modify the depth value.
    /// Several different types of objects can be used as input depending on how the depth of the break is to be defined. Here are the various valid inputs. 1. A GeometryIntent object that represents a point. This specifies the starting point of the break out area. In this case, the DepthValue argument must be specified to indicate the depth of the break out area from the specified point. 2. A DrawingSketch object which is associated with a dependant projected view. 3. A DrawingCurve object that is used to specify a 'hole'. A hole in this case is any geometry from a HoleFeature object or any cylinder or cone in the model. The axis of the hole, cylinder, or cone must be parallel to the sheet plane. The axis defines the depth of the hole. 4. A PartComponentDefinition object to indicate that the entire part is to be cut. This is only applicable when the drawing view contains a part. The PartComponentDefinition supplied must be the component definition of the part in the view. 5. A ComponentOccurrence (or a ComponentOccurrenceProxy) object in the context of the parent drawing view. The depth is defined by the depth of the associated part. This is only applicable when the drawing view contains an assembly. 6. An ObjectCollection containing multiple ComponentOccurrence (or ComponentOccurrenceProxy) objects. The depth is defined by the depths of the associated parts. This is only applicable when the drawing view contains an assembly.</param>
    /// <param name="DepthValue">This argument is only applicable when the DepthType is already kFromPointBreakOutType or you're setting the depth type to be measured from a point. If it is already kFromPointBreakOutType and you want to use the existing from point you can just provide a new depth value. If you want set or change the depth point then the DepthSource argument must also be used to define the new from point. In all other cases the value of this argument is ignored. The value is always input as centimeters.</param>
    [PreserveSig]
    void SetDepth([In] [MarshalAs(UnmanagedType.Struct)] object? DepthSource = default, [In] double? DepthValue = default);
}
