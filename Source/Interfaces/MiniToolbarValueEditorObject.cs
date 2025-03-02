namespace Oblikovati.API;

public interface MiniToolbarValueEditorObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbar Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AutoHide { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbarControlTypeEnum ControlType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllowToleranceEdit { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Expression { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsExpressionValid { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double MaximumValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double MinimumValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelValueTypeEnum ModelValueType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object MostRecentValues { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Precision { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Tolerance Tolerance { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ValueUnitsTypeEnum UnitsType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Value { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Width { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CanValueBeEqualToMaximumValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CanValueBeEqualToMinimumValue { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllowMeasure { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllowShowDimensions { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    UnitsTypeEnum DefaultUnits { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void SetFocus();
}
