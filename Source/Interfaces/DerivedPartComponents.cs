namespace Oblikovati.API;

/// <summary>
/// The DerivedPartComponents collection object provides access to all of the existing objects in a part and provides methods to create additional derived components.
/// </summary>
public interface DerivedPartComponents : IEnumerable
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
    /// Returns the specified DerivedPartComponent object from the collection.
    /// </summary>
    DerivedPartComponent Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Method that creates a new DerivedPartDefinition using the information supplied by the input DerivedPartDefinition object. If successful, the new DerivedPartComponent is returned.
    /// </summary>
    /// <param name="Definition">Input object that defines the derived component.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedPartComponent Add([In] [MarshalAs(UnmanagedType.Interface)] DerivedPartDefinition Definition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentName">FullDocumentName</param>
    [PreserveSig]
    DerivedPartUniformScaleDef CreateDefinition([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName);
    /// <summary>
    /// Method that creates a new DerivedPartUniformScaleDef object.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the name of the file to create the definition for.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedPartUniformScaleDef CreateUniformScaleDef([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that creates a new DerivedPartTransformDef object.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the name of the file to create the definition for.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedPartTransformDef CreateTransformDef([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that creates a new DerivedPartCoordinateSystemDef object.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the name of the file to create the definition for.</param>
    /// <returns></returns>
    [PreserveSig]
    DerivedPartCoordinateSystemDef CreateCoordinateSystemDef([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    DerivedPartUniformScaleDef _CreateUniformScaleDef([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    DerivedPartTransformDef _CreateTransformDef([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullFileName">FullFileName</param>
    [PreserveSig]
    DerivedPartCoordinateSystemDef _CreateCoordinateSystemDef([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
}
