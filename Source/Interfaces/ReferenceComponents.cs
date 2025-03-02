namespace Oblikovati.API;

/// <summary>
/// Provides access to all of the objects that are owned by a particular PartComponentDefinition and have an external file reference.
/// </summary>
public interface ReferenceComponents
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
    /// Property that returns the DerivedPartComponents collection object.
    /// </summary>
    DerivedPartComponents DerivedPartComponents { get; }
    /// <summary>
    /// Property that returns the DerivedAssemblyComponent collection object.
    /// </summary>
    DerivedAssemblyComponents DerivedAssemblyComponents { get; }
    /// <summary>
    /// Property that returns the iFeatureTemplateDescriptors collection object. This collection provides access to existing iFeatureTemplateDescriptor objects. Note: iFeatureTemplateDescriptors was previously known as iFeatureDescriptors and were accessed through the DerivativeDescriptors collection. The DerivativeDescriptors collection has been removed and is now obsolete.
    /// </summary>
    iFeatureTemplateDescriptors iFeatureTemplateDescriptors { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    iFeatureComponents iFeatureComponents { get; }
    /// <summary>
    /// Property that returns the DerivedAliasComponents collection object.
    /// </summary>
    DerivedAliasComponents DerivedAliasComponents { get; }
    /// <summary>
    /// Read-only property that returns the ImportedComponents collection object.&nbsp;This collection provides access to existing ImportedComponent objects and provides functionality to create new ImportedComponent objects.
    /// </summary>
    ImportedComponents ImportedComponents { get; }
    /// <summary>
    /// Gets the DerivedFuturePartComponents collection object.
    /// </summary>
    DerivedFuturePartComponents DerivedFuturePartComponents { get; }
    /// <summary>
    /// Gets the DerivedFutureAssemblyComponents collection object.
    /// </summary>
    DerivedFutureAssemblyComponents DerivedFutureAssemblyComponents { get; }
    /// <summary>
    /// Gets the ShrinkwrapComponents collection object.
    /// </summary>
    ShrinkwrapComponents ShrinkwrapComponents { get; }
}
