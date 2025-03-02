namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface ClientFeatureElementProxy
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
    /// </summary>
    ClientFeatureDefinition Parent { get; }
    /// <summary>
    /// </summary>
    object Element { get; }
    /// <summary>
    /// Read-write property that gets and sets whether this element is visible in the browser under the ClientFeature node.
    /// </summary>
    bool BrowserVisible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this element can be edited by the user.
    /// </summary>
    bool UserEditable { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this element should be pre-highlight, highlighted or selected with the client feature.
    /// </summary>
    bool HighlightWithFeature { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    ClientFeatureElement NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes this element of the client feature
    /// </summary>
    [PreserveSig]
    void Delete();
}
