namespace Oblikovati.API;

/// <summary>
/// The VisibleOccurrenceFinder object is a utility object created using the AssemblyComponentDefinition.CreateVisibleOccurrenceFinder method.  It is used to find occurrences in the assembly based on their visibility.  It is equivalent to the “Select Internal Components”, “Select External Components”, and “Select All in Camera” commands in Inventor.
/// </summary>
public interface VisibleOccurrenceFinder
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
    /// Read-write property Boolean that defines if all components that are found within an assembly will be consolidated so that their paraent assembly is returned instead of each one of the child components.
    /// </summary>
    bool CompactResult { get; set; }
    /// <summary>
    /// Read-only property that returns the occurrences that meet the current criteria defined by the other properties on the VisibleOccurrenceFinder object.
    /// </summary>
    ComponentOccurrencesEnumerator FoundOccurrences { get; }
    /// <summary>
    /// Read-write property Double that defines the percentage of the component that can be visible or hidden.
    /// </summary>
    double PercentageVisible { get; set; }
    /// <summary>
    /// Read-write property that defines if visible or hidden objects should be found.
    /// </summary>
    bool Visible { get; set; }
}
