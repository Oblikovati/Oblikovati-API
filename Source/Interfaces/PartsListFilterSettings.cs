namespace Oblikovati.API;

/// <summary>
/// PartsListFilterSettings Object.
/// </summary>
public interface PartsListFilterSettings : IEnumerable
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
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PartsListFilterItem Item { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the filter settings is enabled or not.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    PartsListFilterItem _Item { get; }
    /// <summary>
    /// Method that returns the specified PartsListFilterItem object from the collection.
    /// </summary>
    /// <param name="PartsListFilterItemType">Input PartsListFilterItemTypeEnum value that specifies the PartsListFilterItem to add. If the same type item already exists, this returns an error.</param>
    /// <param name="Options">Optional input NameValueMap that specifies the options to set. Below are valid values: OptionsApplied to
    /// Name = “StandardContentOnly”. Value = Boolean value that specifies whether to show only the standard content or not.kStandardContentFilterItem
    /// Name = “PurchasedItemsOnly”. Value = Boolean value that specifies whether to show the purchased items only.kPurchasedItemsFilterItem
    /// Name = “ItemNumberRange”. Value = String value that specifies the item number range(e.g.:1,3,7-10 ). kItemNumberRangeFilterItem
    /// Name = “AssemblyViewRepresentation”. Value = DesignViewRepresentation object that specifies the assembly design view representation. AssemblyViewRepresentation
    /// Name = “LimitQTYToVisibleComponentsOnly”. Value = Boolean value that specifies whether limit QTY to visible components only.AssemblyViewRepresentation</param>
    /// <returns></returns>
    [PreserveSig]
    PartsListFilterItem Add([In] PartsListFilterItemTypeEnum PartsListFilterItemType, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
