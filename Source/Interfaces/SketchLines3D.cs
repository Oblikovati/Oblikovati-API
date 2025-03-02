namespace Oblikovati.API;

/// <summary>
/// The SketchLines3D object provides access to all of the objects in a sketch and provides methods to create additional sketch lines. See the article in the overviews section.
/// </summary>
public interface SketchLines3D : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchLine3D object from the collection.
    /// </summary>
    SketchLine3D Item { get; }
    /// <summary>
    /// Method that creates a new sketch line based on the two input points. The new sketch line is returned.
    /// </summary>
    /// <param name="StartPoint">Input object that defines the start point of the line. This can be either a vertex object, a workpoint, a SketchPoint, or an existing SketchPoint3D object. If an existing sketch point is input, that point becomes the line's start point.</param>
    /// <param name="EndPoint">Input object that defines the end point of the line. This can be either a vertex object, a workpoint, a SketchPoint, or an existing SketchPoint3D object. If an existing sketch point is input, that point becomes the line's end point.</param>
    /// <param name="UseAutoBend">Optional input Boolean that indicates whether a bend should be automatically applied if the StartPoint or the EndPoint is shared by another sketch line. The default is True, which means that the bend will be automatically applied.</param>
    /// <param name="BendRadius">Optional input variant that defines the radius of the auto-bend. If the UseAutoBend flag is set to true and this variant is not supplied, a default value is used for the bend radius. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchLine3D AddByTwoPoints([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] bool? UseAutoBend = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BendRadius = default);
}
