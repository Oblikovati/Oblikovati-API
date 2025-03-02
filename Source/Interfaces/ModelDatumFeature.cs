namespace Oblikovati.API;

public interface ModelDatumFeature
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelToleranceFeature Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object DatumGeometry { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DatumText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumFeatureTypeEnum DatumType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
}
