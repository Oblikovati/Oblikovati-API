namespace Oblikovati.API;

/// <summary>
/// Part Mark Features Object.
/// </summary>
public interface MarkFeatures : IEnumerable
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
    MarkFeature Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new mark feature.
    /// </summary>
    /// <param name="pDefinition">Input MarkDefinition object that defines the mark feature you want to create.  An MarkDefinition object can be created using the MarkFeatures.CreateMarkDefinition method.  It can also be obtained from an existing MarkFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    MarkFeature Add([In] [MarshalAs(UnmanagedType.Interface)] MarkDefinition pDefinition);
    /// <summary>
    /// Method that creates a new MarkDefinition objec.
    /// </summary>
    /// <param name="pGeoms">Input ObjectCollection object that specifies the sketch geometries to create mark feature.</param>
    /// <param name="pStyle">Input MarkStyle object that specifies mark style.</param>
    /// <returns></returns>
    [PreserveSig]
    MarkDefinition CreateMarkDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection pGeoms, [MarshalAs(UnmanagedType.Interface)] MarkStyle pStyle);
}
