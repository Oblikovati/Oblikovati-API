namespace Oblikovati.API;

/// <summary>
/// The OccurrencePatterns collection object provides access to the existing assembly patterns ( objects) and supports methods to create new patterns.
/// </summary>
public interface OccurrencePatterns : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified OccurrencePattern object from the collection.
    /// </summary>
    OccurrencePattern this[object Index] { get; }
    /// <summary>
    /// Method that creates a new circular occurrence pattern of input component(s).
    /// </summary>
    /// <param name="ParentComponents">Input ObjectCollection that contains the components to pattern. The valid objects that can be specified in the collection are ComponentOccurrence and OccurrencePattern objects.</param>
    /// <param name="AxisEntity">Input proxy object that defines the axis of the pattern. This can be a proxy to a linear edge or work axis in a part or subassembly, or it can be a work axis from the top-level assembly.</param>
    /// <param name="AxisEntityNaturalDirection">Input Boolean that specifies if the rotation direction of the pattern uses the natural direction of the axis entity. If True it uses the natural direction which defines the rotation direction using the right hand rule where the thumb is pointed in the direction of the axis. If False the direction is reversed.</param>
    /// <param name="AngleOffset">Input Variant that defines the angle offset between pattern instances. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="Count">Input Variant that defines the number of instances. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a string is input it must result in a unitless number.</param>
    /// <returns></returns>
    [PreserveSig]
    CircularOccurrencePattern AddCircularPattern([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentComponents, [In] [MarshalAs(UnmanagedType.IDispatch)] object AxisEntity, [In] bool AxisEntityNaturalDirection, [In] [MarshalAs(UnmanagedType.Struct)] object AngleOffset, [In] [MarshalAs(UnmanagedType.Struct)] object Count);
    /// <summary>
    /// Method that creates a new occurrence pattern of the input component(s) using a pattern feature to define the positions of the elements within the pattern.
    /// </summary>
    /// <param name="ParentComponents">Input ObjectCollection that contains the components to pattern. The valid objects that can be specified in the collection are ComponentOccurrence and OccurrencePattern objects.</param>
    /// <param name="FeaturePattern">Input PatternFeatureProxy object that defines which pattern feature to use for this occurrence pattern.</param>
    /// <returns></returns>
    [PreserveSig]
    FeatureBasedOccurrencePattern AddFeatureBasedPattern([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentComponents, [In] [MarshalAs(UnmanagedType.Interface)] PartFeature FeaturePattern);
    /// <summary>
    /// Method that creates a new rectangular occurrence pattern of input component(s).
    /// </summary>
    /// <param name="ParentComponents">Input ObjectCollection that contains the components to pattern. The valid objects that can be specified in the collection are ComponentOccurrence and OccurrencePattern objects.</param>
    /// <param name="ColumnEntity">Input proxy object that defines the column (x) direction of the pattern. This must be a proxy to a linear edge or a work axis.</param>
    /// <param name="ColumnEntityNaturalDirection">Input Boolean that specifies if the column direction is in the natural direction of the column entity or opposed. True if it is in the same direction as the natural direction of the column entity.</param>
    /// <param name="ColumnOffset">Input Variant that defines the distance between the columns. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ColumnCount">Input Variant that defines the number of columns. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a string is input it must result in a unitless number.</param>
    /// <param name="RowEntity">Optional input Variant that defines the row (y) direction of the pattern. This must be a proxy to a linear edge or a work axis. If this argument is left out then the pattern will have a single row and all subsequent arguments will be ignored.</param>
    /// <param name="RowEntityNaturalDirection">Optional input Boolean that specifies if the row direction is in the natural direction of the row entity or opposed. True if it is in the same direction as the natural direction of the row entity. This argument must be supplied if the RowEntity argument is provided; otherwise it is ignored.</param>
    /// <param name="RowOffset">Optional input Variant that defines the distance between the rows. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document. This argument must be supplied if the RowEntity argument is provided; otherwise it is ignored.</param>
    /// <param name="RowCount">Optional input Variant that defines the number of rows. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a string is input it must result in a unitless number. This argument must be supplied if the RowEntity argument is provided; otherwise it is ignored.Sub PatternComponent()
    /// ' Set a reference to the active assembly document
    /// Dim oDoc As AssemblyDocument
    /// Set oDoc = ThisApplication.ActiveDocument
    /// ' Set a reference to the AssemblyComponentDefinition
    /// Dim oDef As AssemblyComponentDefinition
    /// Set oDef = oDoc.ComponentDefinition
    /// ' Get the x\-axis of the assembly
    /// Dim oXAxis As WorkAxis
    /// Set oXAxis = oDef.WorkAxes.Item(1)
    /// ' Get the y\-axis of the assembly
    /// Dim oYAxis As WorkAxis
    /// Set oYAxis = oDef.WorkAxes.Item(2)
    /// Dim oParentOccs As ObjectCollection
    /// Set oParentOccs = ThisApplication.TransientObjects.CreateObjectCollection
    /// oParentOccs.Add oDef.Occurrences.Item(1)
    /// ' Create a rectangular pattern of components\:
    /// ' 4 columns in the x\-direction with an offset of 5 in
    /// ' 3 rows in the y\-direction with an offset of 4 in
    /// Dim oRectOccPattern As RectangularOccurrencePattern
    /// Set oRectOccPattern = oDef.OccurrencePatterns.AddRectangularPattern( _
    /// oParentOccs, oXAxis, True, "5 in", 4, oYAxis, True, "4 in", 3)
    /// End Sub</param>
    /// <returns></returns>
    [PreserveSig]
    RectangularOccurrencePattern AddRectangularPattern([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentComponents, [In] [MarshalAs(UnmanagedType.IDispatch)] object ColumnEntity, [In] bool ColumnEntityNaturalDirection, [In] [MarshalAs(UnmanagedType.Struct)] object ColumnOffset, [In] [MarshalAs(UnmanagedType.Struct)] object ColumnCount, [In] [MarshalAs(UnmanagedType.Struct)] object? RowEntity = default, [In] bool? RowEntityNaturalDirection = true, [In] [MarshalAs(UnmanagedType.Struct)] object? RowOffset = default, [In] [MarshalAs(UnmanagedType.Struct)] object? RowCount = default);
}
