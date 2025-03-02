namespace Oblikovati.API;

/// <summary>
/// The ChoiceAssetValue object represents an asset value that consists of several pre-defined choices.  Typically these are represented in the UI as a combo box, but they are also often used to indicate the two states of a check box.
/// </summary>
public interface ChoiceAssetValue
{
    /// <summary>
    /// Read-only property returning kAssetValueObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the parent Asset object.
    /// </summary>
    Asset Parent { get; }
    /// <summary>
    /// Gets the name of this value as seen in the Material or Appearance Browser. This can change based on the current Inventor language.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets the boolean flag that indicates if this asset value is read-only. If True any attempted edits will fail.
    /// </summary>
    bool IsReadOnly { get; }
    /// <summary>
    /// Gets the key name of the value. This name will remain constant for all languages and is the name used as input to the Item property or the Asset object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the data type that the Value property for this AssetValue object will return.
    /// </summary>
    AssetValueTypeEnum ValueType { get; }
    /// <summary>
    /// Gets and sets the currently selected choice from the set of choices. The value is a string that matches the name of a valid choice. These names can be obtained by GetChoices method.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Names">Names</param>
    /// <param name="Choices">Choices</param>
    [PreserveSig]
    void GetChoices([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Names, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] Choices);
}
