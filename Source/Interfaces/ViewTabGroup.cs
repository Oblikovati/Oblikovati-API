namespace Oblikovati.API;

/// <summary>
/// ViewTabGroup object.
/// </summary>
public interface ViewTabGroup
{
    /// <summary>
    /// Read-only property that returns the root Application object.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the number of view tabs in this view tab group.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the ViewFrame this view tab Group is located in.
    /// </summary>
    ViewFrame ViewFrame { get; }
    /// <summary>
    /// Read-only property that returns the specified ViewTab object from the collection.
    /// </summary>
    ViewTab Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that closes this ViewTabGroup.
    /// </summary>
    [PreserveSig]
    void Close();
    /// <summary>
    /// Method that moves the current ViewTabGroup to another ViewTabGroup. The ViewTabGroup the current ViewTabGroup moves into will be returned.
    /// </summary>
    /// <param name="TargetViewTab">Input ViewTab object that specifies the target ViewTab.</param>
    /// <param name="DockingState">Input DockingStateEnum value that specifies the docking state of the current ViewTabGroup. Valid values for this argument are: kDockLeft and kDockRight.</param>
    /// <returns></returns>
    [PreserveSig]
    ViewTabGroup MoveToGroup([In] [MarshalAs(UnmanagedType.Interface)] ViewTab TargetViewTab, [In] DockingStateEnum DockingState);
    /// <summary>
    /// Method that moves current ViewTabGroup to a new ViewFrame.
    /// </summary>
    /// <param name="ViewFrameWidth">Optioanl input Long value that specifies the width of the new ViewFrame.</param>
    /// <param name="ViewFrameHeight">Optioanl input Long value that specifies the height of the new ViewFrame.</param>
    /// <param name="ViewFrameLeft">Optioanl input Long value that specifies the left of the new ViewFrame.</param>
    /// <param name="ViewFrameTop">Optioanl input Long value that specifies the top of the new ViewFrame.</param>
    /// <returns></returns>
    [PreserveSig]
    ViewFrame MoveToNewViewFrame([In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameWidth = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameHeight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameLeft = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFrameTop = default);
}
