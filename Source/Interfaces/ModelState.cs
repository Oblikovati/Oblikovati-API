namespace Oblikovati.API;

/// <summary>
/// ModelState Object.
/// </summary>
public interface ModelState
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
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Read-only property that returns the model state member Document that associates with this model state.
    /// </summary>
    _Document Document { get; }
    /// <summary>
    /// Read-only property that returns the model state factory Document. If the model state factory document is not open, query this property will cause it open.
    /// </summary>
    _Document FactoryDocument { get; }
    /// <summary>
    /// Read-only property that returns the enum indicating the model state type. This can be kMasterModelState, kSubstituteModelState, or kCustomModelState.
    /// </summary>
    ModelStateTypeEnum ModelStateType { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the ModelState. When setting the name, the name must be unique with respect to all other ModelState objects in the document, or an error will occur. Setting this property returns an error if this is a built-in.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-only property that returns the DocumentDescriptor of the document associated with the substitute occurrence. This property returns Nothing if the ModelState property returns anything but kSubstituteModelState.
    /// </summary>
    DocumentDescriptor SubstituteDocumentDescriptor { get; }
    /// <summary>
    /// Read-only property that returns the ComponentOccurrence object associated with this model state. This property returns Nothing if the ModelState property returns anything but kSubstituteModelState.
    /// </summary>
    ComponentOccurrence SubstituteOccurrence { get; }
    /// <summary>
    /// Read-only property that returns the ModelState which this ModelState's BOM is delegated to.
    /// </summary>
    ModelState BOMDelegate { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _Document MemberDocument { get; }
    /// <summary>
    /// Method that creates a copy of the ModelState.&nbsp;The new created ModelState is returned.
    /// </summary>
    /// <param name="NewName">Optional input String that specify the name of the new ModelState. If not specified a default name will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    ModelState Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that creates a new design view representation based on the suppression of components as defined by this model state. The newly created DesignViewRepresentation is returned.
    /// </summary>
    /// <param name="NewName">Optional input string that specifies the name of the design view representation to create.  If not specified, Inventor assigns a name to the design view representation.  If specified, the name must be unique with respect to the other design view representations in the document</param>
    /// <returns></returns>
    [PreserveSig]
    DesignViewRepresentation CopyComponentSuppressionToVisibility([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that deletes the ModelState. The method returns an error if this is a built-in ModelState.
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
    /// <summary>
    /// Method that activates the model state.
    /// </summary>
    [PreserveSig]
    void Activate();
}
