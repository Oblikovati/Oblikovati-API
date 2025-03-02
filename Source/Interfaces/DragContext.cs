namespace Oblikovati.API;

/// <summary>
/// The DragContext object provides methods that allow a user to move an object similar to the standard Inventor Assembly Drag.
/// </summary>
public interface DragContext
{
    /// <summary>
    /// Method called to drag a part to the given position. The Point parameter is the current position of the mouse in model space. This is the same as ModelPosition in OnDrag.
    /// </summary>
    [PreserveSig]
    void Drag([In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition);
    /// <summary>
    /// Method called at the beginning of the drag to initialize drag environment. This method must be called before any Drag or TryMove call.
    /// </summary>
    [PreserveSig]
    void StartDrag([In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition);
    /// <summary>
    /// Method called when the drag is finished. Use this call to commit the drag changes.
    /// </summary>
    [PreserveSig]
    void EndDrag();
    /// <summary>
    /// Method that tries to&nbsp;position the object at the exact location given. Returns false if object could not be placed at the exact transform given.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    bool TryMove([In] [MarshalAs(UnmanagedType.Interface)] Matrix NewPosition);
    /// <summary>
    /// Method called when the user wants to cancel the drag operation.
    /// </summary>
    [PreserveSig]
    void CancelDrag();
}
