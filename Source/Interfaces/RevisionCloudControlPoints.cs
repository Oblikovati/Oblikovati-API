namespace Oblikovati.API;

/// <summary>
/// RevisionCloudControlPoints Object.
/// </summary>
public interface RevisionCloudControlPoints : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    RevisionCloudControlPoint Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new RevisionCloudControlPoint.
    /// </summary>
    /// <param name="Position">Input Point2d object that specifies the position for a new revision cloud control point.</param>
    /// <param name="TargetIndex">Optional  input Long value that specifies the target index of the RevisionCloudControlPoint to add a new one next to. If not provided, default value 0 will be used which indicates the new control point will be added as the last one.</param>
    /// <param name="After">Optional input Boolean value that specifies whether the new added control point will be placed after the target index of the RevisionCloudControlPoint. If not provided this defaults to True.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionCloudControlPoint Add([In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] [MarshalAs(UnmanagedType.Struct)] object? TargetIndex = default, [In] bool? After = true);
}
