namespace Oblikovati.API;

/// <summary>
/// The iFeatureTemplateDescriptors collection object provides access to all of the objects in a document.
/// </summary>
public interface iFeatureTemplateDescriptors : IEnumerable
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
    /// Returns the specified iFeatureTemplateDescriptor object from the collection.
    /// </summary>
    iFeatureTemplateDescriptor Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
