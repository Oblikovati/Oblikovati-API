namespace Oblikovati.API;

/// <summary>
/// The BreakOutOperations collection object contains information about all the break out operations applied to a drawing view as well as methods to add break outs to the view.
/// </summary>
public interface BreakOutOperations : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified break out operation object from the collection.
    /// </summary>
    BreakOutOperation Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a break out to a drawing view. The newly created BreakOutOperation object is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object that specifies the sketch profile for the break out. This profile must be closed so it should be created using the AddForSolid method of the Profiles object.</param>
    /// <param name="DepthSource">Input object that specifies the source for the break out depth. Valid input objects are:
    /// A GeometryIntent object that represents a point. This specifies the starting point of the break out area. In this case, the DepthValue argument must be specified to indicate the depth of the break out area from the specified point.
    /// A DrawingSketch object which is associated with a dependant projected view.
    /// A DrawingCurve object that is used to specify a 'hole'. A hole in this case is any geometry from a HoleFeature object or any cylinder or cone in the model. The axis of the hole, cylinder, or cone must be parallel to the sheet plane. The axis defines the depth of the hole.
    /// A PartComponentDefinition object to indicate that the entire part is to be cut. This is only applicable when the drawing view contains a part. The PartComponentDefinition supplied must be the component definition of the part in the view.
    /// A ComponentOccurrence (or a ComponentOccurrenceProxy) object in the context of the parent drawing view. The depth is defined by the depth of the associated part. This is only applicable when the drawing view contains an assembly.
    /// An ObjectCollection containing multiple ComponentOccurrence (or ComponentOccurrenceProxy) objects. The depth is defined by the depths of the associated parts. This is only applicable when the drawing view contains an assembly.</param>
    /// <param name="DepthValue">Optional input Double that specifies the depth value for the break out if the input DepthSource is a point. This argument is ignored if the input source is not a point.</param>
    /// <param name="SectionAllParts">Optional input Boolean that specifies whether to section all parts in the break out area. The default value is False indicating that all parts will not be sectioned.</param>
    /// <returns></returns>
    [PreserveSig]
    BreakOutOperation Add([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object DepthSource, [In] double? DepthValue = default, [In] bool? SectionAllParts = false);
}
