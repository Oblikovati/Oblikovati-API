namespace Oblikovati.API;

/// <summary>
/// The DerivedAssemblyComponents collection object provides access to all of the existing objects in a part and provides methods to create additional derived assembly components.
/// </summary>
public interface DerivedAssemblyComponents : IEnumerable
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
    /// Returns the specified object from the collection.
    /// </summary>
    DerivedAssemblyComponent this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Method that creates a new using the information supplied by the input DerivedAssemblyDefinition object. If successful, the new DerivedAssemblyComponent is returned.
    /// </summary>
    /// <param name="Definition">Input object that defines the derived component.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedAssemblyComponent Add([In] [MarshalAs(UnmanagedType.Interface)] DerivedAssemblyDefinition Definition);
    /// <summary>
    /// Method that creates a new Definition. The returned definition provides access to all of the items in the document that can be derived.
    /// </summary>
    /// <param name="FullDocumentName">String that specifies the full document name of the assembly document to create the definition for. If only the FullFileName is specified, the master document within the assembly file is opened.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedAssemblyDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentName">FullDocumentName</param>
    [PreserveSig]
    DerivedAssemblyDefinition _CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
}
