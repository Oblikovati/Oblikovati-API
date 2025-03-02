namespace Oblikovati.API;

/// <summary>
/// The ThreadFeatures object provides access to all of the objects in a component definition and provides methods to create additional ThreadFeature objects.
/// </summary>
public interface ThreadFeatures : IEnumerable
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
    /// Returns the specified ThreadFeature object from the collection. This is the default property of the ThreadFeatures collection object.
    /// </summary>
    ThreadFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Metric">Metric</param>
    /// <param name="Internal">Internal</param>
    /// <param name="RightHanded">RightHanded</param>
    /// <param name="NominalSizeDescription">NominalSizeDescription</param>
    /// <param name="PitchDesignation">PitchDesignation</param>
    /// <param name="Class">Class</param>
    /// <param name="ThreadType">ThreadType</param>
    /// <param name="MajorDiameterMin">MajorDiameterMin</param>
    /// <param name="MajorDiameterMax">MajorDiameterMax</param>
    /// <param name="MinorDiameterMin">MinorDiameterMin</param>
    /// <param name="MinorDiameterMax">MinorDiameterMax</param>
    /// <param name="PitchDiameterMin">PitchDiameterMin</param>
    /// <param name="PitchDiameterMax">PitchDiameterMax</param>
    [PreserveSig]
    StandardThreadInfo _CreateStandardThreadInfo([In] bool Metric, [In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string NominalSizeDescription, [In] [MarshalAs(UnmanagedType.BStr)] string PitchDesignation, [In] [MarshalAs(UnmanagedType.BStr)] string Class, [In] [MarshalAs(UnmanagedType.BStr)] string? ThreadType = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MajorDiameterMin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MajorDiameterMax = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MinorDiameterMin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MinorDiameterMax = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PitchDiameterMin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PitchDiameterMax = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Metric">Metric</param>
    /// <param name="Internal">Internal</param>
    /// <param name="RightHanded">RightHanded</param>
    /// <param name="NominalSizeDescription">NominalSizeDescription</param>
    /// <param name="ThreadsPerInch">ThreadsPerInch</param>
    /// <param name="Pitch">Pitch</param>
    /// <param name="ThreadType">ThreadType</param>
    /// <param name="OutsidePipeDiameter">OutsidePipeDiameter</param>
    /// <param name="ExternalPitchDiameter">ExternalPitchDiameter</param>
    /// <param name="EngagementLength">EngagementLength</param>
    /// <param name="EngagementDiameter">EngagementDiameter</param>
    /// <param name="EffectiveLength">EffectiveLength</param>
    /// <param name="EffectiveDiameter">EffectiveDiameter</param>
    /// <param name="WrenchMakeupLength">WrenchMakeupLength</param>
    /// <param name="WrenchMakeupDiameter">WrenchMakeupDiameter</param>
    /// <param name="VanishThread">VanishThread</param>
    /// <param name="OverallExternalLength">OverallExternalLength</param>
    /// <param name="NominalExternalLength">NominalExternalLength</param>
    /// <param name="NominalExternalDiameter">NominalExternalDiameter</param>
    /// <param name="ThreadHeight">ThreadHeight</param>
    /// <param name="BasicMinorDiameter">BasicMinorDiameter</param>
    [PreserveSig]
    TaperedThreadInfo _CreateTaperedThreadInfo([In] bool Metric, [In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string NominalSizeDescription, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadsPerInch, [In] double Pitch, [In] [MarshalAs(UnmanagedType.BStr)] string? ThreadType = "", [In] [MarshalAs(UnmanagedType.Struct)] object? OutsidePipeDiameter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ExternalPitchDiameter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EngagementLength = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EngagementDiameter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EffectiveLength = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EffectiveDiameter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? WrenchMakeupLength = default, [In] [MarshalAs(UnmanagedType.Struct)] object? WrenchMakeupDiameter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? VanishThread = default, [In] [MarshalAs(UnmanagedType.Struct)] object? OverallExternalLength = default, [In] [MarshalAs(UnmanagedType.Struct)] object? NominalExternalLength = default, [In] [MarshalAs(UnmanagedType.Struct)] object? NominalExternalDiameter = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ThreadHeight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BasicMinorDiameter = default);
    /// <summary>
    /// Method that creates a new ThreadFeature. The new ThreadFeature object is returned.
    /// </summary>
    /// <param name="Face">Input Face object that defines which face the thread feature is to be applied to. The face must be either a cylinder or cone.</param>
    /// <param name="StartEdge">Input Edge object that defines the start of the thread. The edge must be an edge of the input face.</param>
    /// <param name="ThreadInfo">Input ThreadInfo object that defines the thread attributes. This must be a StandardThreadInfo in the case where the input face is a cylinder and a TaperedThreadInfo in the case where the input face is a cone.</param>
    /// <param name="DirectionReversed">Optional input Boolean that specifies which direction from the start along the cone or cylinder the thread goes in.</param>
    /// <param name="FullDepth">Optional input Boolean that specifies if the thread go the full length of the cylinder or cone. A value of True indicates it goes the full the length. If False, the ThreadDepth argument needs to be supplies.</param>
    /// <param name="ThreadDepth">Input Variant that defines the depth of the thread. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ThreadOffset">Optional input Variant that defines the offset of the start of the thread from the start edge. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    ThreadFeature Add([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] Edge StartEdge, [In] [MarshalAs(UnmanagedType.Interface)] ThreadInfo ThreadInfo, [In] bool? DirectionReversed = false, [In] bool? FullDepth = true, [In] [MarshalAs(UnmanagedType.Struct)] object? ThreadDepth = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ThreadOffset = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Internal">Internal</param>
    /// <param name="RightHanded">RightHanded</param>
    /// <param name="ThreadType">ThreadType</param>
    /// <param name="ThreadDesignation">ThreadDesignation</param>
    /// <param name="Class">Class</param>
    [PreserveSig]
    ThreadInfo CreateThreadInfo([In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation, [In] [MarshalAs(UnmanagedType.BStr)] string? Class = "");
    /// <summary>
    /// Method that creates a new HoleTapInfo object that can be used in creating threads for Hole features. See the Thread.xls \file that is delivered with  Oblikovati for examples of valid input for these arguments. Internal \Input Boolean that indicates if the thread is an internal or external thread. A value of True indicates an Internal thread. RightHanded : Input Boolean that indicates if the thread is right or left-handed thread. A value of True indicates a right-handed thread. ThreadType : Input String that specifies the sheet in the Thread.xls that this thread information should be validated within. Each sheet within the Excel document is typically used for different thread types. The string is the name of the sheet. For example "ANSI Unified Screw Threads" or "ANSI Metric M Profile" are valid for English versions of  Oblikovati. ThreadDesignation : Input String that contains the thread designation. This is input as the full thread designation that will be used in a drawing for the thread callout. The nominal size and pitch information are extracted from the designation. For example valid inch thread designations are '10-24 UNC' and '7/16-20 UNF'. Examples of valid metric designations are 'M16x1.5' and 'M55x1.5'. Class : Input String that defines the thread class. For \example a valid class for an inch internal thread is 2B. A valid class for a metric external thread is 6g.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    StandardThreadInfo CreateStandardThreadInfo([In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation, [In] [MarshalAs(UnmanagedType.BStr)] string Class);
    /// <summary>
    /// Method that creates a new TaperedThreadInfo object that can be used in creating Hole and ThreadFeature objects. See the Thread.xls file that is delivered with  Oblikovati for examples of valid input for these arguments. The spreadsheet columns match one for one with these arguments.
    /// </summary>
    /// <param name="Internal">Input Boolean that indicates if the thread is an internal or external thread. A value of True indicates an Internal thread.</param>
    /// <param name="RightHanded">Input Boolean that indicates if the thread is right or left-handed thread. A value of True indicates a right-handed thread.</param>
    /// <param name="ThreadType">Input String that specifies the sheet in the Thread.xls that this thread information should be validated within. Each sheet within the Excel document is typically used for different thread types. The string is the name of the sheet. For example "NPT" or "JIS Taper" are valid for English versions of Autodesk Inventor.</param>
    /// <param name="ThreadDesignation">Input String that contains the thread designation. This is input as the full thread designation that will be used in a drawing for the thread callout. The nominal size information is extracted from the designation.</param>
    /// <returns></returns>
    [PreserveSig]
    TaperedThreadInfo CreateTaperedThreadInfo([In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation);
}
