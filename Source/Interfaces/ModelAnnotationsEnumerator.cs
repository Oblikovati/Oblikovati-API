namespace Oblikovati.API;

/// <summary>
/// The ModelAnnotationsEnumerator collection object provides access to a set of annotations.
/// </summary>
public interface ModelAnnotationsEnumerator : IEnumerable
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified ModelAnnotation object from the collection.
    /// </summary>
    ModelAnnotation Item { get; }
    /// <summary>
    /// Read-only property returning kModelAnnotationsEnumeratorObject indicating this objects type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
