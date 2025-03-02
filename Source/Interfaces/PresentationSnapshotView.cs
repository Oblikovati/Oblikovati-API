namespace Oblikovati.API;

/// <summary>
/// PresentationSnapshotView object.
/// </summary>
public interface PresentationSnapshotView
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationScene Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the presentation snapshot view name.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Read-only property that returns the saved camera for current presentation snapshot view.
    /// </summary>
    Camera SavedCamera { get; }
    /// <summary>
    /// Read-write&nbsp;property that gets and sets whether the PresentationSnapshotView is associative with a PresentationStoryboard object. This is only writable when you set it to False to break the associativity between the storyboard and snapshot view. This shoud be set to False to break the associativity between the snapshot view and sotryboard for editing the snapshot view, otherwise the edit will fail.
    /// </summary>
    bool StoryboardAssociative { get; set; }
    /// <summary>
    /// Read-only property that returns the PresentationTrails collection object.
    /// </summary>
    PresentationTrails Trails { get; }
    /// <summary>
    /// Method that enters the presentation snapshot view edit mode. Currently the edit(or even for some query functions) out of edit mode for snapshot view is not allowed.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that exits the presentation snapshot view edit mode.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
    /// <summary>
    /// Method that sets override appearance. This is applicable to the leaf component.
    /// </summary>
    /// <param name="PresentationComponents">Input ObjectCollection object that includes the PresentationComponent objects.</param>
    /// <param name="Appearance">Input Asset object that specifies the appearance to set for the PresentationComponent objects.</param>
    [PreserveSig]
    void SetAppearance([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PresentationComponents, [In] [MarshalAs(UnmanagedType.Interface)] Asset Appearance);
    /// <summary>
    /// Method that sets override opacity to PresentationComponent objects.
    /// </summary>
    /// <param name="PresentationComponents">Input ObjectCollection object that includes the PresentationComponent objects.</param>
    /// <param name="Opacity">Input Double value that specifies the opacity. Valid value is from 0 to 1.</param>
    [PreserveSig]
    void SetOpacity([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PresentationComponents, [In] double Opacity);
    /// <summary>
    /// Method that sets override visibility to PresentationComponent objects.
    /// </summary>
    /// <param name="PresentationComponents">Input ObjectCollection object that includes the PresentationComponent objects.</param>
    /// <param name="Visible">Input Boolean value that specifies the visibility.</param>
    [PreserveSig]
    void SetVisibility([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PresentationComponents, [In] bool Visible);
}
