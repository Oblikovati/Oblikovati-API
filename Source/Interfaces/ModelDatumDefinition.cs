namespace Oblikovati.API;

/// <summary>
/// ModelDatumDefinition Object.
/// </summary>
public interface ModelDatumDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelDatum Parent { get; }
    /// <summary>
    /// Gets or sets the datum target points.
    /// </summary>
    ObjectCollection DatumTargetPoints { get; set; }
    /// <summary>
    /// Gets or sets the datum target annotation plane definitions.
    /// </summary>
    ObjectCollection DatumTargetPlanes { get; set; }
    /// <summary>
    /// Gets or sets the datum target text positions.
    /// </summary>
    ObjectCollection DatumTargetTextPositions { get; set; }
    /// <summary>
    /// Gets and sets the model datum targets’ indices.
    /// </summary>
    int[] DatumTargetIndices { get; set; }
    /// <summary>
    /// Gets and sets the datum target type.
    /// </summary>
    ModelDatumTargetTypeEnum DatumTargetType { get; set; }
    /// <summary>
    /// Gets and sets the datum text.
    /// </summary>
    string DatumText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object DatumGeometry { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumFeatureTypeEnum DatumFeatureType { get; set; }
    /// <summary>
    /// Gets and sets the datum target area diameter values.
    /// </summary>
    double[] DatumTargetAreaDiameters { get; set; }
    /// <summary>
    /// Gets and sets the datum target area width values.
    /// </summary>
    double[] DatumTargetAreaWidths { get; set; }
    /// <summary>
    /// Gets and sets the datum target area height values.
    /// </summary>
    double[] DatumTargetAreaHeights { get; set; }
    /// <summary>
    /// Creates a copy of this ModelDatumDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumDefinition Copy();
    /// <summary>
    /// Applies the area size to all datum targets.
    /// </summary>
    /// <param name="DiameterOrWidth">Input Double value that specifies the datum target area diameter or width. The value indicate the datum target area diameter when the DatumTargetType is kModelDatumTargetTypeCircle, and the datum target area width when the DatumTargetType is kModelDatumTargetTypeRectangle.</param>
    /// <param name="Height">Optional input Double value that specifies the datum target area height. This property it is applicable when the DatumTargetType is kModelDatumTargetTypeRectangle.</param>
    [PreserveSig]
    void ApplySizeToAllDatumTargets([In] double DiameterOrWidth, [In] [MarshalAs(UnmanagedType.Struct)] object? Height = default);
}
