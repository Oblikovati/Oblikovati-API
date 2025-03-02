namespace Oblikovati.API;

/// <summary>
/// The CombineFeatures collection object provides access to existing combine features and supports the ability to create new combine features.
/// </summary>
public interface CombineFeatures : IEnumerable
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
    /// Method that returns the specified CombineFeature object from the collection.
    /// </summary>
    CombineFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new combine feature. If the combine feature is created successfully, a CombineFeature object corresponding to the newly created combine feature is returned.
    /// </summary>
    /// <param name="BaseBody">Input SurfaceBody object that represents the blank body. This must be a solid body.</param>
    /// <param name="ToolBodies">Input ObjectCollection containing one or more SurfaceBody objects that represent the tool bodies. All tool bodies must be solid.</param>
    /// <param name="Operation">Input constant that indicates the Boolean operation type for combine. Valid input values are kJoinOperation, kCutOperation and kIntersectOperation.</param>
    /// <param name="KeepToolBodies">Optional input Boolean that specifies whether or not to retain the tool bodies. If not specified, the argument defaults to False and the tool bodies are consumed (i.e. not retained).</param>
    /// <returns></returns>
    [PreserveSig]
    CombineFeature Add([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody BaseBody, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ToolBodies, [In] PartFeatureOperationEnum Operation, [In] bool? KeepToolBodies = false);
}
