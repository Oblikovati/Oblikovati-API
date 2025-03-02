namespace Oblikovati.API;

/// <summary>
/// SketchHatchRegions Object.
/// </summary>
public interface SketchHatchRegions : IEnumerable
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
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    SketchHatchRegion this[int Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new SketchHatchRegion.&nbsp;The new created SketchHatchRegion is returned.
    /// </summary>
    /// <param name="Profile">Input Profile object that being hatched.</param>
    /// <param name="DrawingHatchPattern">Optional input DrawingHatchPattern that specifies the hatch pattern. If this is left empty, the default pattern will be used for the sketch hatch region. If not provided the “ANSI 31” will be used. The “Solid” pattern can be used to set the color fill region.</param>
    /// <param name="Angle">Optional input Double that defines the rotation angle of the hatch pattern in radians.</param>
    /// <param name="Scale">Optional input Double that indicates the scale factor when applying the pattern.</param>
    /// <param name="Shift">Optional input Double that specifies the distance to offset the hatch original hatch pattern position.</param>
    /// <param name="LineWeight">Optional input Double that specifies the line weight in centimeters. A value of 0 indicates By Layer.</param>
    /// <param name="DoublePattern">Optional input Boolean that specifies if a duplicate hatch pattern should be created that is perpendicular to the hatch pattern assigned to the sketch hatch region.</param>
    /// <param name="Color">Optional input Color object that specifies the color for hatch pattern.  A value of Nothing indicates that the layer color should be used.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchHatchRegion Add([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Struct)] object? DrawingHatchPattern = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Angle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Shift = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LineWeight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DoublePattern = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Color = default);
}
