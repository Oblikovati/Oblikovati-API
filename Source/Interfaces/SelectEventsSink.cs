namespace Oblikovati.API;

public interface SelectEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PreSelectEntity">PreSelectEntity</param>
    /// <param name="DoHighlight">DoHighlight</param>
    /// <param name="MorePreSelectEntities">MorePreSelectEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnPreSelect([Out] [MarshalAs(UnmanagedType.IDispatch)] out object PreSelectEntity, [Out] out bool DoHighlight, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection MorePreSelectEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PreSelectEntity">PreSelectEntity</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnPreSelectMouseMove([In] [MarshalAs(UnmanagedType.IDispatch)] object PreSelectEntity, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnStopPreSelect([In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="JustSelectedEntities">JustSelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnSelect([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator JustSelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="UnSelectedEntities">UnSelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnUnSelect([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator UnSelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
}
