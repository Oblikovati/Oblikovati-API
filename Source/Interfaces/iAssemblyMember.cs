namespace Oblikovati.API;

/// <summary>
/// The iAssemblyMember object provides access to a member of an iAssembly.
/// </summary>
public interface iAssemblyMember
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent AssemblyComponentDefinition of the member.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the iAssembly factory that created this iAssemblyMember.
    /// </summary>
    iAssemblyFactory ParentFactory { get; }
    /// <summary>
    /// Property that returns the descriptor of the iAssembly factory document.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns the row in the iAssembly table that this iAssemblyMember represents.
    /// </summary>
    iAssemblyTableRow Row { get; }
    /// <summary>
    /// Method that breaks the link to the parent factory and converts the iAssembly member to a regular assembly.
    /// </summary>
    [PreserveSig]
    void BreakLinkToFactory();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RowName">RowName</param>
    [PreserveSig]
    void SetRowName([In] [MarshalAs(UnmanagedType.BStr)] string RowName);
}
