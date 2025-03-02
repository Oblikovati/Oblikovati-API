namespace Oblikovati.API;

/// <summary>
/// BIMComponentPropertySet object.
/// </summary>
public interface BIMComponentPropertySet : IEnumerable
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
    /// Read-only property that returns the parent BIMComponent object of this object.
    /// </summary>
    BIMComponent Parent { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified BIMComponentProperty object from the collection.
    /// </summary>
    BIMComponentProperty Item { get; }
    /// <summary>
    /// Read-only property that gets the internal name of this property set.&nbsp;This name is consistent and can be used as a reliable index for this property set.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-only property that gets the visible name of this property set.&nbsp;This is the name shown to the end-user in the Component Properties list in the Export Building Components dialog.&nbsp;This name is localized and can change for different languages.
    /// </summary>
    string Name { get; }
}
