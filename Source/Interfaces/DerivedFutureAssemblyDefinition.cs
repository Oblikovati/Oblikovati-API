namespace Oblikovati.API;

/// <summary>
/// The DerivedFutureAssemblyDefinition object is used to describe which parts in an assembly will be used during the creation of the DerivedAssemblyComponent.  It is also used when querying and editing an existing derived assembly.
/// </summary>
public interface DerivedFutureAssemblyDefinition
{
    /// <summary>
    /// Read-only property returning kDerivedFutureAssemblyDefinitionObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Design View Representation for the derived future assembly.&nbsp;An empty string indicates the Master design view is used.&nbsp;The IsAssociativeDesignView property indicates if an associate link to the design view is created or not.
    /// </summary>
    string ActiveDesignViewRepresentation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the name of the active Positional Representation for the derived future assembly.
    /// </summary>
    string ActivePositionalRepresentation { get; set; }
    /// <summary>
    /// Read-only property that returns the&nbsp;derived assemblies.
    /// </summary>
    DerivedFutureAssemblyOccurrences Occurrences { get; }
    /// <summary>
    /// Read-only property that gets the full filename of the derived document.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Read-write property that gets and sets if there is an associative link to the specified design view.&nbsp;When creating a new derived future assembly, setting this property to True (which is the default) will create a derivation that is associative to the design view.&nbsp;This can only be set to True when a design view other than the master design view is specified.
    /// </summary>
    bool IsAssociativeDesignView { get; set; }
}
