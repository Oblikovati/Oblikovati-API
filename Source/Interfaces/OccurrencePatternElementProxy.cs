namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface OccurrencePatternElementProxy
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
    /// Property that returns the parent occurrence pattern of the object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the name of the element.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets/Sets whether the element is independent of the pattern or not.
    /// </summary>
    bool Independent { get; set; }
    /// <summary>
    /// Gets/Sets whether the element is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns the set of occurrences that were created for this particular instance.
    /// </summary>
    ComponentOccurrencesEnumerator Occurrences { get; }
    /// <summary>
    /// Property that returns the set of components that were created for this particular instance. There are cases where this collection can contain a count of zero. The obvious cases are when this element has been set to be independent or suppressed. There is another case when this element is the result of a feature based occurrence pattern and the instance it is associated with within the feature pattern has been suppressed.
    /// </summary>
    ObjectsEnumerator Components { get; }
    /// <summary>
    /// Property that returns the index of this element within the OccurrencePatternElements collection it is a member of.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    OccurrencePatternElement NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
