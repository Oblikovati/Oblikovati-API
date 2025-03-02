namespace Oblikovati.API;

/// <summary>
/// RevisionClouds Object.
/// </summary>
public interface RevisionClouds : IEnumerable
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
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    RevisionCloud this[object Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new revision cloud.
    /// </summary>
    /// <param name="Definition">Input RevisionCloudDefinition object that defines the revision cloud you want to create.  An RevisionCloudDefinition object can be created using the RevisionClouds.CreateRevisionCloudDefinition method.  It can also be obtained from an existing RevisionCloud object.</param>
    /// <param name="Name">Optional  input String value that specifies the name of the new RevisionCloud object. If not specified a default name will be applied.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionCloud Add([In] [MarshalAs(UnmanagedType.Interface)] RevisionCloudDefinition Definition, [In] [MarshalAs(UnmanagedType.Struct)] object? Name = default);
    /// <summary>
    /// Method that creates a new RevisionCloudDefinition object.
    /// </summary>
    /// <param name="ControlPoints">Input ObjectCollection including Point2d objects that specify the control points to create revision cloud.</param>
    /// <param name="Layer">Optional input Layer object that specifies Layer for the revision cloud. If not provided, a default Layer will be used.</param>
    /// <param name="Inverted">Optional input Boolean value that specifies whether to invert the  revision cloud or not. If not provided, this defaults to False.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionCloudDefinition CreateRevisionCloudDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ControlPoints, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default, [In] bool? Inverted = false);
}
