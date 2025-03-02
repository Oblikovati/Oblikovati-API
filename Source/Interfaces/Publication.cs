namespace Oblikovati.API;

/// <summary>
/// Publication object.
/// </summary>
public interface Publication
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    _PresentationDocument Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns PublicationComponents collection object.
    /// </summary>
    PublicationComponents PublicationComponents { get; }
    /// <summary>
    /// Read-only property that gets the publication display name.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Read-only property that returns the active storyboard.
    /// </summary>
    Storyboard ActiveStoryboard { get; }
    /// <summary>
    /// Read-only property that returns the Storyboards collection object.
    /// </summary>
    Storyboards Storyboards { get; }
    /// <summary>
    /// Read-write property that gets and sets the current frame time in active storyboard.
    /// </summary>
    double CurrentFrameTime { get; set; }
    /// <summary>
    /// Read-only property that returns the PublicationMarkedViews collection object.
    /// </summary>
    PublicationMarkedViews MarkedViews { get; }
    /// <summary>
    /// Read-only property that gets the GraphicsDataSetsCollection.
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Read-only property that gets the ClientGraphicsCollection.
    /// </summary>
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    /// <summary>
    /// Read-write property that indicates whether to defer updating of the publication when edit its contents.
    /// </summary>
    bool DeferUpdates { get; set; }
    /// <summary>
    /// Read-only property that returns the initial camera for the publication.
    /// </summary>
    Camera InitialCamera { get; }
    /// <summary>
    /// Read-only property that returns the publication internal name.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Read-write property that gets and sets whether in the preview mode or not. The preview mode can be in PublicationTweak creation and edit, or animation preview mode.
    /// </summary>
    bool InPreviewMode { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the publication design view is associative or not.
    /// </summary>
    bool DesignViewAssociative { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PublicationComponent TopSceneComponent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that creates a GeometryIntent object for the publication.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    GeometryIntent CreateGeometryIntent([In] [MarshalAs(UnmanagedType.IDispatch)] object Geometry, [In] [MarshalAs(UnmanagedType.Struct)] object? Intent = default);
    /// <summary>
    /// Method that sets the active storyboard with specified current frame time.
    /// </summary>
    [PreserveSig]
    void SetActiveStoryboard([In] [MarshalAs(UnmanagedType.Interface)] Storyboard Storyboard, [In] [MarshalAs(UnmanagedType.Struct)] object? CurrentFrameTime = default);
    /// <summary>
    /// Method that makes this publication the active one.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that deletes this publication.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that gets the cloned entity if this Publication is copied from another Publication object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    object GetClonedEntity([In] [MarshalAs(UnmanagedType.Struct)] object SourceEntity);
    /// <summary>
    /// Method that sets the override opacity of a set of PublicationComponent objects.
    /// </summary>
    [PreserveSig]
    void SetComponentsOverrideOpacity([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection __MIDL__Publication0000, [In] [MarshalAs(UnmanagedType.SafeArray)] double[] __MIDL__Publication0001);
    /// <summary>
    /// Method that sets the override visibility of a set of PublicationComponent objects.
    /// </summary>
    [PreserveSig]
    void SetComponentsOverrideVisibility([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection __MIDL__Publication0002, [In] bool __MIDL__Publication0003);
    /// <summary>
    /// Method that clears the override visibility of a set of PublicationComponent objects.
    /// </summary>
    [PreserveSig]
    void ClearComponentsOverrideVisibility([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection __MIDL__Publication0004);
}
