namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface ProfilePathProxy : IEnumerable
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
    /// Property that returns the parent Profile.
    /// </summary>
    Profile Parent { get; }
    /// <summary>
    /// Property that returns the number of items in this collection. This property is only valid if the profile path denotes a set of connected curves. On the other hand, if the profile path denotes a text box, which will be indicated by the value of the TextPath property being True, then this property does not apply.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ProfileEntity object from the collection. This property is only valid if the profile path denotes a set of connected curves. On the other hand, if the profile path denotes a text box, which will be indicated by the value of the TextPath property being True, then this property does not apply.
    /// </summary>
    ProfileEntity this[int Index] { get; }
    /// <summary>
    /// Property that returns a Boolean indicating if the path is closed or not. Returns True in the case of a closed path. This property is only valid if the profile path denotes a set of connected curves. On the other hand, if the profile path denotes a text box, which will be indicated by the value of the TextPath property being True, then this property does not apply.
    /// </summary>
    bool Closed { get; }
    /// <summary>
    /// Gets or sets a Boolean indicating whether the path adds or removes material from the entire area.
    /// </summary>
    bool AddsMaterial { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that gets the text box this profile path was derived from. This property is only valid if the profile path denotes a text box which will be indicated by the value of the TextPath property being True. On the other hand, if the profile path denotes a set of connected curves, then this property does not apply and will return Nothing.
    /// </summary>
    TextBox TextBox { get; }
    /// <summary>
    /// Property that returns a Boolean indicating if the profile path denotes a text box. Returns True in the case that the path denotes a text box. If the profile path denotes a set of connected curves, then this property will return False.
    /// </summary>
    bool TextBoxPath { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    ProfilePath NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes this ProfilePath object. This method can be used to delete profile paths that represent a set of connected curves as well as profile paths that represent text boxes.
    /// </summary>
    [PreserveSig]
    void Delete();
}
