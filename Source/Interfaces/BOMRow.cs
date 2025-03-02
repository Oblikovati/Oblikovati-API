namespace Oblikovati.API;

/// <summary>
/// The BOMRow object represents an item in the BOM based on the parent BOMView.
/// </summary>
public interface BOMRow
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent BOMView or the BOMRow object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns whether this row is a result of a merging multiple rows. If true, the ComponentDefinitions property returns all the associated component definitions. This property will return False for all rows in the data BOMView.
    /// </summary>
    bool Merged { get; }
    /// <summary>
    /// Property that returns whether this row was promoted (for instance, as a result of the parent subassembly being marked phantom). This property will return False for all rows in the data BOMView.
    /// </summary>
    bool Promoted { get; }
    /// <summary>
    /// Indicates whether this row is a result of rolling up multiple promoted rows of the same ComponentDefinition.
    /// </summary>
    bool RolledUp { get; }
    /// <summary>
    /// Property that returns the ComponentDefinitions associated with this row in the BOM. These could be part, sheet metal, assembly, weldment or a virtual component definitions. This enumerator will return just one component definition unless this row is a merged one, in which case all associated component definitions are returned. The first component definition in the enumerator is always the primary component definition.
    /// </summary>
    ComponentDefinitionsEnumerator ComponentDefinitions { get; }
    /// <summary>
    /// Gets and sets how the BOM item represented by this row is used/viewed relating to design.
    /// </summary>
    BOMStructureEnum BOMStructure { get; set; }
    /// <summary>
    /// Gets and sets the item number of the BOM item.
    /// </summary>
    string ItemNumber { get; set; }
    /// <summary>
    /// Property that gets the number of instances not marked as phantom or reference represented by this BOM row.
    /// </summary>
    int ItemQuantity { get; }
    /// <summary>
    /// Gets and sets the total quantity of the BOM item.&nbsp;Overrides cannot be set for parts only views.
    /// </summary>
    string TotalQuantity { get; set; }
    /// <summary>
    /// Gets and sets whether the TotalQuantity property has been overridden.&nbsp;This property can only be set to False, in which case the override on the value will be removed.
    /// </summary>
    bool TotalQuantityOverridden { get; set; }
    /// <summary>
    /// Property that gets the BOMRowsEnumerator object containing the locally-stored rows under this BOMRow. This property will return Nothing for BOMRows in a parts-only view and if there are no sub-rows for this BOMRow.
    /// </summary>
    BOMRowsEnumerator ChildRows { get; }
    /// <summary>
    /// Gets and sets whether the item identifier can be edited.
    /// </summary>
    bool ItemNumberLocked { get; set; }
    /// <summary>
    /// Read-only property that returns a PropertySets object associated with this BOMRow. This only applies to non merged component rows with Instance Properties.
    /// </summary>
    PropertySets OccurrencePropertySets { get; }
    /// <summary>
    /// Gets the ComponentOccurrences associated with this row in the BOM.
    /// </summary>
    ComponentOccurrencesEnumerator ComponentOccurrences { get; }
    /// <summary>
    /// Gets the FileDescriptor for the component referenced by this row. This only applies to non merged component rows and non local components and immediately referenced components. Therefore this would only be useful in the data view.
    /// </summary>
    FileDescriptor ReferencedFileDescriptor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
