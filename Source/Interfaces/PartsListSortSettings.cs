namespace Oblikovati.API;

/// <summary>
/// PartsListSortSetting Object.
/// </summary>
public interface PartsListSortSettings
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the primary column to use for the sorting. If the title of a non-existing column is provided, an error occurs.
    /// </summary>
    string PrimaryColumnTitle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to sort from the lowest value to the highest or vice versa. The default value is True indicating that the sorting will be from the lowest value to the highest.
    /// </summary>
    bool PrimaryColumnAscending { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the secondary column to use for the sorting. If the title of a non-existing column is provided, an error occurs.
    /// </summary>
    string SecondaryColumnTitle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to sort from the lowest value to the highest or vice versa. The default value is True indicating that the sorting will be from the lowest value to the highest.
    /// </summary>
    bool SecondaryColumnAscending { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the tertiary column to use for the sorting. If the title of a non-existing column is provided, an error occurs.
    /// </summary>
    string TertiaryColumnTitle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to sort from the lowest value to the highest or vice versa. The default value is True indicating that the sorting will be from the lowest value to the highest.
    /// </summary>
    bool TertiaryColumnAscending { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether sorts by numerical order or not.
    /// </summary>
    bool SortNumerically { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to sort parts list automatically when update.
    /// </summary>
    bool AutoSortOnUpdate { get; set; }
}
