namespace Oblikovati.API;

/// <summary>
/// BIMComponentProperty object.
/// </summary>
public interface BIMComponentProperty
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    BIMComponentPropertySet Parent { get; }
    /// <summary>
    /// Read-only property that gets the internal name of this component property.&nbsp;This name is consistent and can be used as a reliable index for this property.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-only property that gets the visible name of this property.&nbsp;This is the name shown to the end-user in the Component Properties list in the Export Building Components dialog.&nbsp;This name is localized and can change for different languages.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-write property that gets the value of this BIM property.
    /// </summary>
    string Value { get; set; }
}
