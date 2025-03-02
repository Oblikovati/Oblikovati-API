namespace Oblikovati.API;

/// <summary>
/// PublicationMarkedView object.
/// </summary>
public interface PublicationMarkedView
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    Publication Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns whether the PublicationMarkedView is associative with a Storyboard object.
    /// </summary>
    bool Associative { get; }
    /// <summary>
    /// Read-only property that returns the Id of the PublicationMarkedView.
    /// </summary>
    string Id { get; }
    /// <summary>
    /// Read-write property that gets and sets the publication marked view display name.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Read-write property that get and sets the frame time.
    /// </summary>
    double Time { get; set; }
    /// <summary>
    /// Read-only property that returns whether the publication marked view requires update or not.
    /// </summary>
    bool RequireUpdate { get; }
    /// <summary>
    /// Read-only property that returns the associative Storyboard object.
    /// </summary>
    Storyboard AssociativeStoryboard { get; }
    /// <summary>
    /// Read-write property that gets and sets camera for current publication marked view.
    /// </summary>
    Camera Camera { get; set; }
    /// <summary>
    /// Read-only property that returns the PublicationTweaks collection.
    /// </summary>
    PublicationTweaks Tweaks { get; }
    /// <summary>
    /// Read-only property that returns the PublicationTrails collection.
    /// </summary>
    PublicationTrails Trails { get; }
    /// <summary>
    /// Method that creates a copy of this PublicationMarkedView object, the newly copied PublicationMarkedView is returned.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PublicationMarkedView Copy([In] [MarshalAs(UnmanagedType.Struct)] object? DisplayName = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StoryboardObjects">StoryboardObjects</param>
    /// <param name="MarkedViewObjects">MarkedViewObjects</param>
    [PreserveSig]
    void BreakAssociativity();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StoryboardObjects">StoryboardObjects</param>
    /// <param name="MarkedViewObjects">MarkedViewObjects</param>
    [PreserveSig]
    void BreakAssociativity([In] [MarshalAs(UnmanagedType.Struct)] object StoryboardObjects, [Out] [MarshalAs(UnmanagedType.Struct)] out object MarkedViewObjects);
    /// <summary>
    /// Method that deletes the publication marked view.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that enters the publication marked view edit mode.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that exits the publication marked view edit mode.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
    /// <summary>
    /// Method that sets which data in publication marked view should be updated.
    /// </summary>
    [PreserveSig]
    void SetUpdateDataType([In] MarkedViewDataTypeEnum MarkedViewDataType);
    /// <summary>
    /// Method that updates the publication marked view.
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Method that sets override visibility.
    /// </summary>
    [PreserveSig]
    void SetVisibility([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PublicationComponents, bool Visible);
    /// <summary>
    /// Method that gets visibility of the specified publication component.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool GetVisibility([In] [MarshalAs(UnmanagedType.Interface)] PublicationComponent PublicationComponent);
    /// <summary>
    /// Method that transforms specified publication components.
    /// </summary>
    [PreserveSig]
    void TransformComponents([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PublicationComponents, [In] [MarshalAs(UnmanagedType.Interface)] Matrix Transform);
    /// <summary>
    /// Method that gets the transformation for specified publication component.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Matrix GetComponentTransformation([In] [MarshalAs(UnmanagedType.Interface)] PublicationComponent PublicationComponent);
    /// <summary>
    /// Method that sets override opacity.
    /// </summary>
    [PreserveSig]
    void SetOpacity([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PublicationComponents, [In] double Opacity);
    /// <summary>
    /// Method that gets opacity of specified publication component.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    double GetOpacity([In] [MarshalAs(UnmanagedType.Interface)] PublicationComponent PublicationComponent);
    /// <summary>
    /// Method that rollbacks the marked view to a publication tweak.
    /// </summary>
    [PreserveSig]
    void Rollback([In] [MarshalAs(UnmanagedType.Interface)] PublicationTweak Tweak, [In] [MarshalAs(UnmanagedType.Struct)] object? Before = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PublicationComponents">PublicationComponents</param>
    /// <param name="pAsset">pAsset</param>
    [PreserveSig]
    void SetAppearance([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PublicationComponents, [In] [MarshalAs(UnmanagedType.Interface)] Asset pAsset);
}
