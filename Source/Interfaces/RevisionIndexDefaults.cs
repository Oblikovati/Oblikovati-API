namespace Oblikovati.API;

/// <summary>
/// RevisionIndexDefaults Object.
/// </summary>
public interface RevisionIndexDefaults
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the index start value.
    /// </summary>
    string IndexStartValue { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to automatically set the index value.
    /// </summary>
    bool AutoIndex { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to update property on revision number edit or not.
    /// </summary>
    bool UpdatePropertyOnRevisionNumberEdit { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the revision index is numeric or not.
    /// </summary>
    bool UseNumericIndex { get; set; }
}
