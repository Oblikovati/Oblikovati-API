namespace Oblikovati.API;

/// <summary>
/// The FaceDraftFeatures object represents a collection of face draft features ( objects) on a part.
/// </summary>
public interface FaceDraftFeatures : IEnumerable
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
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    FaceDraftFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Faces">Faces</param>
    /// <param name="FixedEdges">FixedEdges</param>
    /// <param name="DraftAngle">DraftAngle</param>
    /// <param name="PullDirection">PullDirection</param>
    /// <param name="DirectionReversed">DirectionReversed</param>
    [PreserveSig]
    FaceDraftFeature _AddFixedEdge([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces, [In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection FixedEdges, [In] [MarshalAs(UnmanagedType.Struct)] object DraftAngle, [In] [MarshalAs(UnmanagedType.IDispatch)] object PullDirection, [In] bool? DirectionReversed = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Faces">Faces</param>
    /// <param name="DraftAngle">DraftAngle</param>
    /// <param name="FixedPlane">FixedPlane</param>
    /// <param name="DirectionReversed">DirectionReversed</param>
    [PreserveSig]
    FaceDraftFeature _AddFixedPlane([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces, [In] [MarshalAs(UnmanagedType.Struct)] object DraftAngle, [In] [MarshalAs(UnmanagedType.IDispatch)] object FixedPlane, [In] bool? DirectionReversed = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Faces">Faces</param>
    /// <param name="DraftAngle">DraftAngle</param>
    /// <param name="PullDirection">PullDirection</param>
    /// <param name="DirectionReversed">DirectionReversed</param>
    [PreserveSig]
    FaceDraftFeature _AddTaperShadow([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection Faces, [In] [MarshalAs(UnmanagedType.Struct)] object DraftAngle, [In] [MarshalAs(UnmanagedType.IDispatch)] object PullDirection, [In] bool? DirectionReversed = false);
    /// <summary>
    /// Method that creates a new FaceDraft feature.
    /// </summary>
    /// <param name="FaceDraftDefinition">Input FaceDraftDefinition object that defines the face draft feature you want to create. An FaceDraftDefinition object can be created using the FaceDraftFeatures.CreateFaceDraftDefinition method. It can also be obtained from an existing FaceDraftFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    FaceDraftFeature Add([In] [MarshalAs(UnmanagedType.Interface)] FaceDraftDefinition FaceDraftDefinition);
    /// <summary>
    /// Method that creates a new FaceDraftDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FaceDraftDefinition CreateFaceDraftDefinition();
}
