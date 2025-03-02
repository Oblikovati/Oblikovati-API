namespace Oblikovati.API;

/// <summary>
/// BIMComponentPropertySets object.
/// </summary>
public interface BIMComponentPropertySets : IEnumerable
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
    /// Read-only property that returns the total number of BIM component property sets this BIM document.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified BIMComponentPropertySet object from the collection.&nbsp;This collection is empty until the component type is defined using the ComponentType property of the BIMComponentDescription object.
    /// </summary>
    BIMComponentPropertySet Item { get; }
}
