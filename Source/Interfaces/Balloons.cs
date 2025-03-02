namespace Oblikovati.API;

/// <summary>
/// The Balloons collection object provides access to all of the objects on a sheet. This collection is available via the Balloons property of the Sheet object.
/// </summary>
public interface Balloons : IEnumerable
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
    /// Returns the specified object from the collection.
    /// </summary>
    Balloon this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Balloon. The newly created Balloon is returned. The corresponding BOMView in the model is automatically enabled if not already enabled.
    /// </summary>
    /// <param name="LeaderPoints">Input ObjectCollection containing a series of Point2d objects representing the leader originating at the note. The last item in the collection (even if it is the only item) must be a GeometryIntent object indicating a geometry to attach the leader to. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method. The ObjectCollection must contain at least one item (a GeometryIntent), else the method will fail. Note that the component that the balloon will attach to is inferred from the GeometryIntent object.</param>
    /// <param name="VirtualComponent">Optional input object that defines the virtual or custom component that this balloon will be attached to. This can either be a ComponentOccurrence / ComponentOccurrenceProxy object representing a virtual component, a BOMRow that represents a virtual component or a custom/virtual DrawingBOMRow.</param>
    /// <param name="Level">Optional input PartsListLevelEnum that sets the view type for the parts list. If supplied, this input is only used in the case where the balloon references an assembly document. If this value was previously set as a result of creating a parts list or a balloon in the drawing based on the same model, this argument is ignored. Use the DrawingDocument.DrawingBOMs.IsDrawingBOMDefined method to check whether or not to supply this argument. Valid enums are: kStructured, that creates a 'first level only' parts list in which a simple integer value is assigned to direct children, kStructuredAllLevels that creates an 'all level' parts list with full expanded numbering, and kPartsOnly, that creates a parts list that sequentially numbers all parts in the top level assembly, even if they are contained in subassemblies.</param>
    /// <param name="NumberingScheme">Optional input NameValueMap object that specifies the numbering scheme to use for the parts list. This argument is ignored if the numbering schemes have already been set for this model as a result of creating a parts list or a balloon based on the same model. Use the DrawingDocument.DrawingBOMs.IsDrawingBOMDefined method to check whether or not to supply this argument. Also, this argument is ignored if the numbering schemes have been defined in the model BOM views. The NameValueMap can contain the following entries based on the input 'Level' argument:
    /// For kStructured: 'MinimumDigits' As Long
    /// For kStructuredAllLevels: 'Delimiter' As String
    /// For kPartsOnly: 'NumberingScheme' As NumberingSchemeEnum and 'MinimumDigits' As Long
    /// Valid values for NumberingSchemeEnum are kNumericNumbering, kLowercaseAlphaNumbering and kUppercaseAlphaNumbering. This input should be supplied only if the input argument Level is specified to be kPartsOnly. If this argument is not supplied for a 'parts only' parts list, a default value of kNumericNumbering is assumed.</param>
    /// <param name="BalloonStyle">Optional input BalloonStyle object that specifies the balloon style to use for the balloon. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the balloon. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Balloon Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection LeaderPoints, [In] [MarshalAs(UnmanagedType.Struct)] object? VirtualComponent = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Level = default, [In] [MarshalAs(UnmanagedType.Struct)] object? NumberingScheme = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BalloonStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
