namespace Oblikovati.API;

/// <summary>
/// The PresentationExplodedView object represents an exploded view within a presentation document.
/// </summary>
public interface PresentationExplodedView
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the name of the exploded view.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Returns the trails associated with the exploded view, optionally filtered to the input ComponentOccurrence (or ComponentOccurrenceProxy).
    /// </summary>
    TrailsEnumerator Trails { get; }
    /// <summary>
    /// Read-write property that gets and sets the current appearance used for the occurrence.&nbsp;The appearance asset being used when setting&nbsp;this property must be from the current document’s AppearanceAssets collection, otherwise an error will occur. Setting this property with an asset will also result in setting the AppearanceSourceType to kOverrideAppearance.&nbsp;Setting this property to Nothing removes the override so that the weld bead will display using the appearance associated with the weld material.
    /// </summary>
    Asset Appearance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the source of the appearance for the occurrence.&nbsp;Setting this property to kComponentOccurrenceAppearance will clear any overrides so the occurrence will display the same as in the original assembly.
    /// </summary>
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PresentationTasks Tasks { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Camera SavedCamera { get; }
    /// <summary>
    /// Method that activates the exploded view.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that deletes the exploded view.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that returns the transform of a particular occurrence within the exploded view.
    /// </summary>
    /// <param name="Occurrence">Occurrence to get the transform matrix of.</param>
    /// <returns></returns>
    [PreserveSig]
    Matrix GetTransform([In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence);
    /// <summary>
    /// Method that returns the visibility of a particular occurrence or the entire document within the exploded view.
    /// </summary>
    /// <param name="Occurrence">Occurrence to determine visibility of.</param>
    /// <returns></returns>
    [PreserveSig]
    bool GetVisibility([In] [MarshalAs(UnmanagedType.IDispatch)] object Occurrence);
    /// <summary>
    /// </summary>
    /// <param name="Occurrence">Object to set the visibility state of.</param>
    /// <param name="Visible">Boolean that specifies whether the input object is visible in the drawing view.</param>
    [PreserveSig]
    void SetVisibility([In] [MarshalAs(UnmanagedType.IDispatch)] object Occurrence, [In] bool Visible);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrence">Occurrence</param>
    [PreserveSig]
    RenderStyle GetRenderStyle([In] [MarshalAs(UnmanagedType.IDispatch)] object Occurrence);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="RenderStyle">RenderStyle</param>
    [PreserveSig]
    void SetRenderStyle([In] [MarshalAs(UnmanagedType.IDispatch)] object Occurrence, [In] [MarshalAs(UnmanagedType.Interface)] RenderStyle RenderStyle);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Intervals">Intervals</param>
    /// <param name="Repetitions">Repetitions</param>
    [PreserveSig]
    void GetAnimationParams([Out] out int Intervals, [Out] out int Repetitions);
}
