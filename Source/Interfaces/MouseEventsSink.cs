namespace Oblikovati.API;

public interface MouseEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnMouseUp([In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnMouseDown([In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnMouseClick([In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnMouseDoubleClick([In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="ModelPosition">ModelPosition</param>
    /// <param name="ViewPosition">ViewPosition</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnMouseMove([In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] Point ModelPosition, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ViewPosition, [In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Button">Button</param>
    /// <param name="ShiftKeys">ShiftKeys</param>
    /// <param name="View">View</param>
    [PreserveSig]
    void OnMouseLeave([In] MouseButtonEnum Button, [In] ShiftStateEnum ShiftKeys, [In] [MarshalAs(UnmanagedType.Interface)] View View);
}
