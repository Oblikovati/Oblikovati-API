namespace Oblikovati.API;

/// <summary>
/// The DerivedFutureAssemblyComponents collection object provides access to all of the existing DerivedFutureAssemblyComponent objects in a part and provides methods to create additional derived components.
/// </summary>
public interface DerivedFutureAssemblyComponents : IEnumerable
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
    /// Method that returns the specified DerivedFutureAssemblyComponent object from the collection.
    /// </summary>
    DerivedFutureAssemblyComponent Item { get; }
    /// <summary>
    /// Read-only property returning kDerivedFutureAssemblyComponentsObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Method that creates a new DerivedFutureAssemblyComponent using the information supplied by the input DerivedFutureAssemblyDefinition object.&nbsp;If successful, the new DerivedFutureAssemblyComponent is returned.
    /// </summary>
    /// <param name="Definition">Input DerivedFutureAssemblyDefinition object that defines the derived component.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedFutureAssemblyComponent Add([In] [MarshalAs(UnmanagedType.Interface)] DerivedFutureAssemblyDefinition Definition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentName">FullDocumentName</param>
    [PreserveSig]
    DerivedFutureAssemblyDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
}
