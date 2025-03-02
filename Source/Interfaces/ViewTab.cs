namespace Oblikovati.API;

/// <summary>
/// ViewTab Object.
/// </summary>
public interface ViewTab
{
    /// <summary>
    /// Read-only property that returns the root Application object.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the View or WebView this view tab is associated with.
    /// </summary>
    object View { get; }
    /// <summary>
    /// Read-only property that returns the ViewFrame this view tab is located in.
    /// </summary>
    ViewFrame ViewFrame { get; }
    /// <summary>
    /// Read-only property that returns the ViewTabGroup this view tab is located in. This returns Nothing if the ViewTab is not grouped.
    /// </summary>
    ViewTabGroup ViewTabGroup { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that closes this ViewTab.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Method that moves the current view tab to a ViewTabGroup. The ViewTabGroup the current ViewTab moves into will be returned.
    /// </summary>
    /// <param name="CreateNewGroup">Input Boolean value that specifies whether to move  the current ViewTab to a newly created ViewTabGroup or an existing ViewTabGroup. If set this as True then a new ViewTabGroup containing this ViewTab will be created. If this is set to False current ViewTab will be moved to an existing ViewTabGroup that contains the TargetViewTab.</param>
    /// <param name="TargetViewTab">Input ViewTab object that specifies the target ViewTab.</param>
    /// <param name="DockingState">Input DockingStateEnum value that specifies the docking state of the current ViewTab. If the CreateNewGroup is set to True then the current ViewTab will be docked to the location against the TargetViewTab’s group, valid values for this argument are: kDockBottom, kDockTop, kDockLeft and kDockRight. If the CreateNewGroup is set to False, then the current ViewTab will be moved to the left or right side of the TargetViewTab, so valid values for this argument are: kDockLeft and kDockRight.</param>
    /// <param name="AdditionalViewTabs">Optional  input ObjectCollection object containing ViewTab objects as additional view tabs to move to the group with current ViewTab.</param>
    /// <returns></returns>
    [PreserveSig]
    ViewTabGroup MoveToGroup([In] bool CreateNewGroup, [In] [MarshalAs(UnmanagedType.Interface)] ViewTab TargetViewTab, [In] DockingStateEnum DockingState, [In] [MarshalAs(UnmanagedType.Struct)] object? AdditionalViewTabs = default);
    /// <summary>
    /// Method that moves current ViewTab to a new ViewFrame.
    /// </summary>
    /// <param name="ViewFrameWidth">Optioanl input Long value that specifies the width of the new ViewFrame.</param>
    /// <param name="ViewFrameHeight">Optioanl input Long value that specifies the height of the new ViewFrame.</param>
    /// <param name="ViewFrameLeft">Optioanl input Long value that specifies the left of the new ViewFrame.</param>
    /// <param name="ViewFrameTop">Optioanl input Long value that specifies the top of the new ViewFrame.</param>
    /// <param name="AdditionalViewTabs">Optional  input ObjectCollection object containing ViewTab objects as additional view tabs to move to the ViewFrame with current ViewTab.</param>
    /// <returns></returns>
    [PreserveSig]
    ViewFrame MoveToNewViewFrame([In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameWidth = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameHeight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameLeft = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameTop = default, [In] [MarshalAs(UnmanagedType.Struct)] object? AdditionalViewTabs = default);
}
