namespace Oblikovati.API;

/// <summary>
/// HoleClearanceInfo object.
/// </summary>
public interface HoleClearanceInfo
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
    /// Read-write property that gets and sets the fastener standard.
    /// </summary>
    string FastenerStandard { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the fastener type.
    /// </summary>
    string FastenerType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the fastener size.
    /// </summary>
    string FastenerSize { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the fastener fit type.
    /// </summary>
    FastenerFitType FastenerFitType { get; set; }
    /// <summary>
    /// Read-only property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Method that set HoleClearanceInfo data.
    /// </summary>
    /// <param name="FastenerStandard">Input String value that specifies the fastener standard. The standard is the name of the sheet in the Clearance.xls file that is used to define the clearance info.</param>
    /// <param name="FastenerType">Input String value that specifies the fastener type.</param>
    /// <param name="FastenerSize">Input String value that specifies the fastener size.</param>
    /// <param name="FastenerFitType">Optinal input FastenerFitTypeEnum value that specifies the fastener fit type. If not provided the default kNormalFitType will be used.</param>
    [PreserveSig]
    void SetClearanceInfo([In] [MarshalAs(UnmanagedType.BStr)] string FastenerStandard, [In] [MarshalAs(UnmanagedType.BStr)] string FastenerType, [In] [MarshalAs(UnmanagedType.BStr)] string FastenerSize, [In] [MarshalAs(UnmanagedType.Struct)] object? FastenerFitType = default);
}
