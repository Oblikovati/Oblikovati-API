namespace Oblikovati.API;

/// <summary>
/// ModelDatumIdentifierDefinition Object.
/// </summary>
public interface ModelDatumIdentifierDefinition
{
    /// <summary>
    /// Read-write property that gets and sets the annotation plane for the datum identifier symbol.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane definition for the datum identifier symbol.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the type of the arrowhead. This is a style override.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the text of the symbol.
    /// </summary>
    string DatumText { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the geometric entity the note is attached to.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelDatumIdentifier Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the text position of the symbol in the part or assembly. The point is projected onto the orientation plane.
    /// </summary>
    Point TextPosition { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a copy of this ModelDatumIdentifierDefinition object. The new ModelDatumIdentifierDefinition object is independent of any datum identifier symbols. It can edited and used as input to edit an existing datum identifier or to create a datum id???K??????.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumIdentifierDefinition Copy();
}
