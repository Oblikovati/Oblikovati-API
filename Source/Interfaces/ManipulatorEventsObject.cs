namespace Oblikovati.API;

public interface ManipulatorEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InteractionEvents Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Matrix Transform { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ManipulatorElementEnum SelectedElement { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ManipulatorElement">ManipulatorElement</param>
    /// <param name="DragValue">DragValue</param>
    [PreserveSig]
    void ApplyDrag([In] ManipulatorElementEnum ManipulatorElement, [In] [MarshalAs(UnmanagedType.Struct)] object DragValue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="VisibleElements">VisibleElements</param>
    /// <param name="EnabledElements">EnabledElements</param>
    [PreserveSig]
    void SetAppearance([In] ManipulatorElementEnum VisibleElements, [In] ManipulatorElementEnum EnabledElements);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MiniToolbarHeight">MiniToolbarHeight</param>
    /// <param name="MiniToolbarWidth">MiniToolbarWidth</param>
    [PreserveSig]
    Point2d SuggestedMiniToolbarPosition([In] int MiniToolbarHeight, [In] int MiniToolbarWidth);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearCurrentDragValue();
}
