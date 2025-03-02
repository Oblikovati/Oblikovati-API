namespace Oblikovati.API;

public interface UserInputEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    [PreserveSig]
    void OnStartCommand([In] CommandIDEnum CommandID);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandName">CommandName</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnActivateCommand([In] [MarshalAs(UnmanagedType.BStr)] string CommandName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandName">CommandName</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnTerminateCommand([In] [MarshalAs(UnmanagedType.BStr)] string CommandName, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    [PreserveSig]
    void OnStopCommand([In] CommandIDEnum CommandID);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    /// <param name="CommandBar">CommandBar</param>
    [PreserveSig]
    void OnContextMenuOld([In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo, [In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DragState">DragState</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDrag([In] DragStateEnum DragState, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    /// <param name="CommandBar">CommandBar</param>
    [PreserveSig]
    void OnContextMenu([In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo, [In] [MarshalAs(UnmanagedType.Interface)] CommandBar CommandBar);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedEntities">SelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDoubleClick([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator SelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedEntities">SelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="View">View</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDeleteKeyUp([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator SelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] View View, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo, [Out] out HandlingCodeEnum HandlingCode);
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
    void OnPreSelect([In] [Out] [MarshalAs(UnmanagedType.IDispatch)] ref object PreSelectEntity, [Out] out bool DoHighlight, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref ObjectCollection MorePreSelectEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
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
    /// <param name="MoreSelectedEntities">MoreSelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnSelect([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator JustSelectedEntities, [In] [Out] [MarshalAs(UnmanagedType.Interface)] ref ObjectCollection MoreSelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
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
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedEntities">SelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="RadialMenu">RadialMenu</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    [PreserveSig]
    void OnRadialMarkingMenu([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator SelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] RadialMarkingMenu RadialMenu, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedEntities">SelectedEntities</param>
    /// <param name="SelectionDevice">SelectionDevice</param>
    /// <param name="LinearMenu">LinearMenu</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    [PreserveSig]
    void OnLinearMarkingMenu([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator SelectedEntities, [In] SelectionDeviceEnum SelectionDevice, [In] [MarshalAs(UnmanagedType.Interface)] CommandControls LinearMenu, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SelectedEntities">SelectedEntities</param>
    /// <param name="DisplayedCommands">DisplayedCommands</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    [PreserveSig]
    void OnContextualMiniToolbar([In] [MarshalAs(UnmanagedType.Interface)] ObjectsEnumerator SelectedEntities, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap DisplayedCommands, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap AdditionalInfo);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMarkTutorialCommand([In] [MarshalAs(UnmanagedType.BStr)] string CommandID, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
