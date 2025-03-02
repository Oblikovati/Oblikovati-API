namespace Oblikovati.API;

/// <summary>
/// The DerivedParameterTable object represents the connection to an Inventor document.
/// </summary>
public interface DerivedParameterTable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object of this DerivedParameterTable. This property will return different types of objects depending on the document type the DerivedParameterTable is contained in. If the DerivedParameterTable is in a part document then the parent is a PartComponentDefinition object. If the DerivedParameterTable is in an assembly document then the parent is an AssemblyComponentDefinition.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the DerivedParameters collection object.
    /// </summary>
    DerivedParameters DerivedParameters { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Property that returns the referenced Inventor document.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Gets and sets the collection of parameters that have been linked from the referenced document.
    /// </summary>
    ObjectCollection LinkedParameters { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Method that deletes the DerivedParameterTable object. This method will fail if the HasReferenceComponent property returns true.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
