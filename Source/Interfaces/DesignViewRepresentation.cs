namespace Oblikovati.API;

/// <summary>
/// The DesignViewRepresentation object represents a design view representation in the assembly.
/// </summary>
public interface DesignViewRepresentation
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent RepresentationsManager object.
    /// </summary>
    RepresentationsManager Parent { get; }
    /// <summary>
    /// Gets and sets the name of the DesignViewRepresentation.&nbsp;The name must be unique with respect to all other DesignViewRepresentation objects in the document, or an error will occur. Setting this property returns an error if the DesignViewType is kMasterDesignVi.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the design view representation type. This can return kPrimaryDesignViewType, kPrivateDesignViewType, kPublicDesignViewType and kTransientDesignViewType.
    /// </summary>
    DesignViewTypeEnum DesignViewType { get; }
    /// <summary>
    /// Gets and sets whether this design view representation is locked.&nbsp;If a representation is locked, changes made to it will not be saved to the document.&nbsp;Setting this property will fail if the DesignViewType is kMasterDesignViewType or kPrivateDesignViewType.
    /// </summary>
    bool Locked { get; set; }
    /// <summary>
    /// Property that returns the design view representation information as a String containing XML formatted data. This is applicable for assembly documents only. For more information on the XML format see More XML Design View Info...
    /// </summary>
    string DesignViewInfo { get; }
    /// <summary>
    /// Gets and sets weather the design view representations camera is saved automatically.
    /// </summary>
    bool AutoSaveCamera { get; set; }
    /// <summary>
    /// Gets and sets the design view representations model annotation scale.
    /// </summary>
    double ModelAnnotationScale { get; set; }
    /// <summary>
    /// Gets and sets the camera associated with this design view.
    /// </summary>
    Camera Camera { get; set; }
    /// <summary>
    /// Gets and sets the design view representations model annotation scale mode.
    /// </summary>
    bool ModelAnnotationAutoScale { get; set; }
    /// <summary>
    /// Gets and sets whether this design view representation is published.
    /// </summary>
    bool Publish { get; set; }
    /// <summary>
    /// Gets and sets whether section view in this design view is suppressed or not. Set this to True will suppress the section view in this design view. The GetSectionViewInfo can be used to determine whether there is a section view or not.
    /// </summary>
    bool IsSectionViewSuppressed { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that activates the design view representation.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that creates a copy of the DesignViewRepresentation. The new created DesignViewRepresentation is returned.
    /// </summary>
    /// <param name="NewName">Optional input string that specifies the name of the design view representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <returns></returns>
    [PreserveSig]
    DesignViewRepresentation Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that deletes the DesignViewRepresentation. The method returns an error if the DesignViewType is kMasterDesignViewType.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that makes all components invisible in this representation.
    /// </summary>
    [PreserveSig]
    void HideAll();
    /// <summary>
    /// Method that makes all components visible in this representation.
    /// </summary>
    [PreserveSig]
    void ShowAll();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void RemoveColorOverrides();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NewName">NewName</param>
    [PreserveSig]
    LevelOfDetailRepresentation CopyToLevelOfDetail([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that sets the visibility of a collection of occurrences.&nbsp;If occurrences within a subassembly are specified and the owning subassembly occurrence is associative to a design view representation, the associativity will be turned off.
    /// </summary>
    /// <param name="Occurrences">Input ObjectCollection that contains the ComponentOccurrence objects to set the visibility on.  The collection can contain both top-level occurrences and those in subassemblies (ComponentOccurrenceProxy objects).</param>
    /// <param name="Visible">Input Boolean that indicates if the set of occurrences should have the visibility turned off or on.  A value of True indicates that their visibility will be turned on.</param>
    [PreserveSig]
    void SetVisibilityOfOccurrences([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Occurrences, [In] bool Visible);
    /// <summary>
    /// Resets all components to their default appearance.
    /// </summary>
    [PreserveSig]
    void RemoveAppearanceOverrides();
    /// <summary>
    /// Method that saves the camera of the active view to the design view.
    /// </summary>
    [PreserveSig]
    void SaveCurrentCamera();
    /// <summary>
    /// Method that changes the camera of the active view to the camera stored with the design view.
    /// </summary>
    [PreserveSig]
    void RestoreCamera();
    /// <summary>
    /// Sets a section view in the design view.
    /// </summary>
    /// <param name="SectionViewType">Input SectionViewTypeEnum that specifies the section view type you want to set.</param>
    /// <param name="FirstSectionPlane">Optinoal input a Plane object that specifies the first section plane for quarter or three quarter section view and the section plane for the half section view. The normal of the section plane defines the section direction.</param>
    /// <param name="SecondSectionPlane">Optinoal input a Plane object that specifies the second section plane for quarter or three quarter section view. The normal of the section plane defines the section direction. If the SectionViewType is not equal to the kQuarterSectionViewType or kThreeQuarterSectionViewType this argument will be ignored.</param>
    [PreserveSig]
    void SetSectionView([In] SectionViewTypeEnum SectionViewType, [In] [MarshalAs(UnmanagedType.Struct)] object? FirstSectionPlane = default, [In] [MarshalAs(UnmanagedType.Struct)] object? SecondSectionPlane = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SectionViewType">SectionViewType</param>
    /// <param name="FirstSectionPlane">FirstSectionPlane</param>
    /// <param name="SecondSectionPlane">SecondSectionPlane</param>
    [PreserveSig]
    void GetSectionViewInfo([Out] out SectionViewTypeEnum SectionViewType, [Out] [MarshalAs(UnmanagedType.Interface)] out Plane FirstSectionPlane, [Out] [MarshalAs(UnmanagedType.Interface)] out Plane SecondSectionPlane);
    /// <summary>
    /// Create a new ModelState based on the visibility of components as defined by the design view. The new created ModelState is returned.
    /// </summary>
    /// <param name="NewName">Optional input string that specifies the name of the model state to create.  If not specified, Inventor assigns a name to the mode state.  If specified, the name must be unique with respect to the other model states in the document</param>
    /// <returns></returns>
    [PreserveSig]
    ModelState CopyComponentVisibilityToSuppression([In] [MarshalAs(UnmanagedType.BStr)] string? NewName = "");
    /// <summary>
    /// Method that sets the visibility of all content center components.
    /// </summary>
    /// <param name="Visible">Input Boolean value that specifies whether all the content center components are visible or not.</param>
    [PreserveSig]
    void SetAllContentCenterComponentsVisibility([In] bool Visible);
}
