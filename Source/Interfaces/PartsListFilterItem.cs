namespace Oblikovati.API;

/// <summary>
/// PartsListFilterItem Object.
/// </summary>
public interface PartsListFilterItem
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PartsListFilterSettings Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets options for the filter item.
    /// </summary>
    NameValueMap Options { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this filter item is enabled or not. This is applicable when the filter item is from a parts list style.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Read-only property that returns the filter item type.
    /// </summary>
    PartsListFilterItemTypeEnum FilterItemType { get; }
    /// <summary>
    /// Method that delete this item.
    /// </summary>
    [PreserveSig]
    void Delete();
}
