namespace Oblikovati.API;

/// <summary>
/// The DerivedFuturePartComponents collection object provides access to all of the existing DerivedFuturePartComponent objects in a part and provides methods to create additional derived components.
/// </summary>
public interface DerivedFuturePartComponents : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified DerivedFuturePartComponent object from the collection.
    /// </summary>
    DerivedFuturePartComponent this[int Index] { get; }
    /// <summary>
    /// Read-only property returning kDerivedFuturePartComponentsObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Method that creates a new DerivedFuturePartComponent using the information supplied by the input DerivedFuturePartDefinition object.&nbsp;If successful, the new DerivedFuturePartComponent is returned.
    /// </summary>
    /// <param name="Definition">Input DerivedFuturePartDefinition object that defines the derived component.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedFuturePartComponent Add([In] [MarshalAs(UnmanagedType.Interface)] DerivedFuturePartDefinition Definition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentName">FullDocumentName</param>
    [PreserveSig]
    DerivedFuturePartDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
}
