namespace Oblikovati.API;

/// <summary>
/// Provides access to the objects within an assembly and supports methods to create new occurrences.
/// </summary>
public interface ComponentOccurrences : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    ComponentOccurrence this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows string-indexed access to items in the collection. (Usually found when this ability has been added to a pre-existing collection).
    /// </summary>
    ComponentOccurrence ItemByName { get; }
    /// <summary>
    /// Return all unique leaf occurrences (optionally filtered to the specified definition) relative to this context.
    /// </summary>
    ComponentOccurrencesEnumerator AllLeafOccurrences { get; }
    /// <summary>
    /// Property that returns all occurrences that reference the input object.
    /// </summary>
    ComponentOccurrencesEnumerator AllReferencedOccurrences { get; }
    /// <summary>
    /// Method that creates a new for an existing part or subassembly. This method is the equivalent of the 'Place Component' command.
    /// </summary>
    /// <param name="FullDocumentName">Input string that specifies the full document name of the part or the sub-assembly. If only the FullFileName is specified, the master document within the file is used.</param>
    /// <param name="Position">Input object that defines the location and orientation to position the occurrence.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence Add([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position);
    /// <summary>
    /// Method that creates a new for a new part or subassembly. This method is the equivalent of the 'Create Component' command.
    /// </summary>
    /// <param name="CompDef">Input object that will be referenced when creating the new occurrence.</param>
    /// <param name="Position">Input object that defines the location and orientation to position the occurrence.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence AddByComponentDefinition([In] [MarshalAs(UnmanagedType.Interface)] ComponentDefinition CompDef, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position);
    /// <summary>
    /// Method that creates an of an iPartMember in this AssemblyComponentDefinition. The iPartMember is specified by a factory and a row in the factory.
    /// </summary>
    /// <param name="FactoryFileName">Input String that specifies the full filename of the iPart factory.</param>
    /// <param name="Position">Input Matrix that defines the position and orientation of the iPart placement within the assembly.</param>
    /// <param name="Row">Optional input Variant that specifies the row for the member within the factory. The row index is specified either by a Long (row index), a String (part identifier, i.e. ''[Height=1.000 in][Length=2.000 in][Radius=0.250 in]''), or an iPartTableRow object.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence AddiPartMember([In] [MarshalAs(UnmanagedType.BStr)] string FactoryFileName, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position, [In] [MarshalAs(UnmanagedType.Struct)] object? Row = default);
    /// <summary>
    /// Method that creates an of an iPartMember in this AssemblyComponentDefinition. The iPartMember is specified by a custom factory and a row in the factory.
    /// </summary>
    /// <param name="FactoryFileName">Input String that specifies the full filename of the iPart factory.</param>
    /// <param name="Position">Input object that defines the position and orientation of the iPart placement within the assembly.</param>
    /// <param name="FullFileName">Input String that defines the filename of the resulting member. If the filename is not specified the default filename for the row will be used. In the case of a custom factory the filename must be specified and is not optional.</param>
    /// <param name="Row">Optional input Variant that specifies the row for the member within the factory. The row index is specified either by a Long (row index), a String (part identifier, i.e. ''[Height=1.000 in][Length=2.000 in][Radius=0.250 in]''), or an iPartTableRow object.</param>
    /// <param name="CustomInput">Optional input array of Strings that specifies the input to use for the custom input. If the factory is a custom factory and this is not supplied the default values for custom values are used. The custom input strings are supplied in a column order. If the factory is not a custom factory this argument is ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence AddCustomiPartMember([In] [MarshalAs(UnmanagedType.BStr)] string FactoryFileName, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position, [In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Struct)] object? Row = default, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="FullDocumentName">FullDocumentName</param>
    /// <param name="Position">Position</param>
    [PreserveSig]
    ComponentOccurrence _AddUsingiMates([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position);
    /// <summary>
    /// Method that adds a new occurrence into the assembly. This method is the equivalent of using the Place Component command with the "Use iMate" check box checked. The method returns a failure if no matches are found.
    /// </summary>
    /// <param name="FullDocumentName">Input string that specifies the full document name of the part or the sub-assembly. If only the FullFileName is specified, the master document within the file is used.</param>
    /// <param name="PlaceAllMatching">Optional input Boolean that indicates whether to place multiple components corresponding to all iMate definition matches in the assembly. If specified to be True, multiple ComponentOccurrences could be returned. If specified to be False, a single ComponentOccurrence corresponding to the first match is returned.</param>
    /// <param name="Options">Input NameValueMap object that specifies additional options for creating the occurrence. (An empty NameValueMap object can be provided). See Remarks for valid options.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrencesEnumerator AddUsingiMates([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] bool? PlaceAllMatching = false, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Method that creates a virtual component definition and adds an occurrence based on that definition.
    /// </summary>
    /// <param name="Name">Input string that specifies the name of the virtual component.</param>
    /// <param name="Position">Input Matrix object that defines the location and orientation to position the occurrence.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence AddVirtual([In] [MarshalAs(UnmanagedType.BStr)] string Name, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position);
    /// <summary>
    /// Method that creates a new occurrence for an existing part or subassembly. This method is the equivalent of the "Place Component" command.
    /// </summary>
    /// <param name="FullDocumentName">Input string that specifies the full document name of the part or the sub-assembly. If only the FullFileName is specified, the master document within the file is used.</param>
    /// <param name="Position">Input Matrix object that defines the location and orientation to position the occurrence.</param>
    /// <param name="Options">Input NameValueMap object that specifies additional options for creating the occurrence. (An empty NameValueMap object can be provided). The valid options are:
    /// NameValue TypeValid Document Type
    /// PrivateRepresentationFileNameString Assembly
    /// DesignViewRepresentation String Part,Assembly
    /// DesignViewAssociative Boolean Part,Assembly
    /// PositionalRepresentation String Assembly
    /// ModelState String Part,Assembly
    /// Notes:
    /// PrivateRepresentationFileName: If a PrivateRepresentationFileName (an idv file name) is specified, the DesignViewRepresentation name should be one of the private design views within that idv file else an error will occur.
    /// ModelState: Typically, the ModelState to use should be provided in the form of a FullDocumentName (first argument). But if this is provided separately, you should make sure that it does not conflict with the FullDocumentName argument by providing FullFileName as the first argument rather than a FullDocumentName.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence AddWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options);
    /// <summary>
    /// Method that creates an occurrence of an iAssemblyMember in an assembly. The iAssemblyMember is specified by a factory and a row in the factory.
    /// </summary>
    /// <param name="FactoryDocumentName">String that specifies the full document name of the iAssembly factory.</param>
    /// <param name="Position">Matrix that defines the position and orientation of the iAssembly member placement within the assembly.</param>
    /// <param name="Row">Optional input Variant that specifies the row for the member within the factory. The row index is specified either by a Long (row index), a String (MemberName of a member), or an iAssemblyTableRow object. If not specified, the default row within the factory is used.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for creating the occurrence. The valid options are:
    /// Name Value Type
    /// PrivateRepresentationFileName String
    /// DesignViewRepresentation String
    /// PositionalRepresentation String
    /// UseiMate Boolean
    /// PrivateRepresentationFileName As String If a PrivateRepresentationFileName (an idv file name) is specified, the DesignViewRepresentation name should be one of the private design views within that idv file else an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    ComponentOccurrence AddiAssemblyMember([In] [MarshalAs(UnmanagedType.BStr)] string FactoryDocumentName, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Position, [In] [MarshalAs(UnmanagedType.Struct)] object? Row = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
