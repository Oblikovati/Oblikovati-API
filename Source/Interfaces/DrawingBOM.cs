namespace Oblikovati.API;

/// <summary>
/// The DrawingBOM object represents a locally stored BOM. This is the equivalent of the table displayed when the 'Attach Balloon From List' command in the context menu of a balloon is invoked.
/// </summary>
public interface DrawingBOM
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that gets the DrawingBOMColumns collection object.
    /// </summary>
    DrawingBOMColumns DrawingBOMColumns { get; }
    /// <summary>
    /// Property that gets the DrawingBOMRows collection object.
    /// </summary>
    DrawingBOMRows DrawingBOMRows { get; }
    /// <summary>
    /// Property that returns the type of numbering for the BOM.
    /// </summary>
    PartsListLevelEnum Level { get; }
    /// <summary>
    /// Property that returns the parent DrawingDocument object.
    /// </summary>
    _DrawingDocument Parent { get; }
    /// <summary>
    /// Property that gets the model document referenced by this DrawingBOM.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
