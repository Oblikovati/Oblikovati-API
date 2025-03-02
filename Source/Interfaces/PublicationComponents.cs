namespace Oblikovati.API;

/// <summary>
/// PublicationComponents collection object.
/// </summary>
public interface PublicationComponents : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PublicationComponent Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a new PublicationComponent object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PublicationComponent Add([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] bool IsAnyCAD, [In] [MarshalAs(UnmanagedType.Struct)] object? Position = default, [In] [MarshalAs(UnmanagedType.Struct)] object? FactoryTableRow = default, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomMemberDestination = default, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    bool HasRootComponent();
}
