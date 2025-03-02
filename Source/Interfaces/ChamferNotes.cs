namespace Oblikovati.API;

/// <summary>
/// The ChamferNotes collection object provides access to all of the chamfer notes on the sheet.
/// </summary>
public interface ChamferNotes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ChamferNote object from the collection.
    /// </summary>
    ChamferNote this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a chamfer note positioned at the specified point on the sheet.
    /// </summary>
    /// <param name="Position">Input Point2d that specifies the position of the chamfer note on the sheet.</param>
    /// <param name="ChamferEdgeOne">Input object that specifies the first chamfer edge. This can either be a linear DrawingCurve object or a SketchLine object from a sheet sketch. Use the corresponding DrawingCurve objects for view sketch and model sketch entities. The leader of the chamfer note will point to the center of entity.</param>
    /// <param name="ChamferEdgeTwo">Input object that specifies the second chamfer edge. This can either be a linear DrawingCurve object or a SketchLine object from a sheet sketch. Use the corresponding DrawingCurve objects for view sketch and model sketch entities. This object must be connected to the first chamfer edge and at an angle other than 90 degrees, else the method will fail.</param>
    /// <param name="DimensionStyle">Optional input Variant that specifies which dimension style to use for the note. The dimension style can be specified by providing the name of an existing style or by supplying a DimensionStyle object.</param>
    /// <returns></returns>
    [PreserveSig]
    ChamferNote Add([In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] [MarshalAs(UnmanagedType.IDispatch)] object ChamferEdgeOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object ChamferEdgeTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default);
}
