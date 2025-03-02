namespace Oblikovati.API;

public interface SelectEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InteractionEvents Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MouseMoveEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectsEnumerator SelectedEntities { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SingleSelectEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool WindowSelectEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IgnoreProfileInnerLoops { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ComponentOccurrence RestrictSelectionToOccurrence { set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool PreSelectBurnThrough { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ExpressSelectionEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _PreSelectionTypeEnum _PreSelectionType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Filter">Filter</param>
    [PreserveSig]
    void AddSelectionFilter([In] SelectionFilterEnum Filter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearSelectionFilter();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ResetSelections();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ItemObject">ItemObject</param>
    [PreserveSig]
    void AddToSelectedEntities([In] [MarshalAs(UnmanagedType.IDispatch)] object ItemObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ItemObject">ItemObject</param>
    [PreserveSig]
    void RemoveFromSelectedEntities([In] [MarshalAs(UnmanagedType.IDispatch)] object ItemObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Filter">Filter</param>
    [PreserveSig]
    void AddWindowSelectionFilter([In] SelectionFilterEnum Filter);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearWindowSelectionFilter();
}
