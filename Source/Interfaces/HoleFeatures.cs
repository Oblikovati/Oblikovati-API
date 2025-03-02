namespace Oblikovati.API;

/// <summary>
/// The HoleFeatures object provides access to all of the objects in a component definition and provides methods to create additional HoleFeature objects.
/// </summary>
public interface HoleFeatures : IEnumerable
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
    /// Returns the specified HoleFeature object from the collection. This is the default property of the HoleFeatures collection object.
    /// </summary>
    HoleFeature Item { get; }
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
    /// <param name="DiameterInModel">DiameterInModel</param>
    /// <param name="FullTapDepth">FullTapDepth</param>
    /// <param name="ThreadType">ThreadType</param>
    /// <param name="ThreadDepth">ThreadDepth</param>
    /// <param name="MajorDiameterMin">MajorDiameterMin</param>
    /// <param name="MajorDiameterMax">MajorDiameterMax</param>
    /// <param name="MinorDiameterMin">MinorDiameterMin</param>
    /// <param name="MinorDiameterMax">MinorDiameterMax</param>
    /// <param name="PitchDiameterMin">PitchDiameterMin</param>
    /// <param name="PitchDiameterMax">PitchDiameterMax</param>
    /// <param name="TapDrillDiameter">TapDrillDiameter</param>
    [PreserveSig]
    HoleTapInfo _CreateTapInfo([In] bool Metric, [In] bool Internal, [In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string NominalSizeDescription, [In] [MarshalAs(UnmanagedType.BStr)] string PitchDesignation, [In] [MarshalAs(UnmanagedType.BStr)] string Class, [In] ModelDiameterFromThreadEnum DiameterInModel, [In] bool FullTapDepth, [In] [MarshalAs(UnmanagedType.BStr)] string? ThreadType = "", [In] [MarshalAs(UnmanagedType.Struct)] object? ThreadDepth = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MajorDiameterMin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MajorDiameterMax = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MinorDiameterMin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MinorDiameterMax = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PitchDiameterMin = default, [In] [MarshalAs(UnmanagedType.Struct)] object? PitchDiameterMax = default, [In] [MarshalAs(UnmanagedType.Struct)] object? TapDrillDiameter = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="Depth">Depth</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddDrilledByDistanceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="Depth">Depth</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="CSinkDiameter">CSinkDiameter</param>
    /// <param name="CSinkAngle">CSinkAngle</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddCSinkByDistanceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkAngle, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="Depth">Depth</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="CBoreDiameter">CBoreDiameter</param>
    /// <param name="CBoreDepth">CBoreDepth</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddCBoreByDistanceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDepth, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="Depth">Depth</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="SpotFaceDiameter">SpotFaceDiameter</param>
    /// <param name="SpotFaceDepth">SpotFaceDepth</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddSpotFaceByDistanceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDepth, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddDrilledByToFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="CSinkDiameter">CSinkDiameter</param>
    /// <param name="CSinkAngle">CSinkAngle</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddCSinkByToFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkAngle, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="CBoreDiameter">CBoreDiameter</param>
    /// <param name="CBoreDepth">CBoreDepth</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddCBoreByToFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDepth, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PlacementDefinition">PlacementDefinition</param>
    /// <param name="DiameterOrTapInfo">DiameterOrTapInfo</param>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="SpotFaceDiameter">SpotFaceDiameter</param>
    /// <param name="SpotFaceDepth">SpotFaceDepth</param>
    /// <param name="FlatBottom">FlatBottom</param>
    /// <param name="BottomTipAngle">BottomTipAngle</param>
    [PreserveSig]
    HoleFeature AddSpotFaceByToFaceExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDepth, [In] bool? FlatBottom = true, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that creates a new drilled HoleFeature using 'through all' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo or a TaperedThreadInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddDrilledByThroughAllExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] PartFeatureExtentDirectionEnum ExtentDirection);
    /// <summary>
    /// Method that creates a new counter sink HoleFeature using 'through all' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo or a TaperedThreadInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="CSinkDiameter">Input Variant that defines the diameter of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CSinkAngle">Input Variant that defines the angle of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddCSinkByThroughAllExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkAngle);
    /// <summary>
    /// Method that creates a new counterbore HoleFeature using 'through all' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="CBoreDiameter">Input Variant that defines the diameter of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CBoreDepth">Input Variant that defines the depth of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddCBoreByThroughAllExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDepth);
    /// <summary>
    /// Method that creates a new spotface HoleFeature using 'through all' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Input Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Input Variant that defines either the diameter of the hole or the tap information (using a HoleTapInfo or a TaperedThreadInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude towards. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="SpotFaceDiameter">Input Variant that defines the diameter of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="SpotFaceDepth">Input Variant that defines the depth of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddSpotFaceByThroughAllExtent([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDepth);
    /// <summary>
    /// Method that creates a new HoleTapInfo object that can be used in creating threads for Hole features. See the Thread.xls file that is delivered with  Oblikovati for examples of valid input for these arguments.
    /// </summary>
    /// <param name="RightHanded">Input Boolean that indicates if the thread is right or left-handed thread. A value of True indicates a right-handed thread.</param>
    /// <param name="ThreadType">Input String that specifies the sheet in the Thread.xls that this thread information should be validated within. Each sheet within the Excel document is typically used for different thread types. The string is the name of the sheet. For example "ANSI Unified Screw Threads" or "ANSI Metric M Profile" are valid for English versions of Autodesk Inventor.</param>
    /// <param name="ThreadDesignation">Input String that contains the thread designation. This is input as the full thread designation that will be used in a drawing for the thread callout. The nominal size and pitch information are extracted from the designation. For example valid inch thread designations are '10-24 UNC' and '7/16-20 UNF'. Examples of valid metric designations are 'M16x1.5' and 'M55x1.5'.</param>
    /// <param name="Class">Input String that defines the thread class. For example a valid class for an inch internal thread is 2B. A valid class for a metric external thread is 6g.</param>
    /// <param name="FullTapDepth">Input Boolean that indicates if the thread extends the full length of the hole or not. A value of True indicates the thread goes the full extent of the hole.</param>
    /// <param name="ThreadDepth">Optional input Variant that defines the thread depth. This is only applicable when the FullDepth argument is False, otherwise this argument is ignored. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleTapInfo CreateTapInfo([In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation, [In] [MarshalAs(UnmanagedType.BStr)] string Class, [In] bool FullTapDepth, [In] [MarshalAs(UnmanagedType.Struct)] object? ThreadDepth = default);
    /// <summary>
    /// Method that creates a new TaperedThreadInfo object that can be used in creating HoleFeature objects. See the Thread.xls file that is delivered with Oblikovati for examples of valid input for these arguments. The spreadsheet columns match one for one with these arguments.
    /// </summary>
    /// <param name="RightHanded">Input Boolean that indicates if the thread is right or left-handed thread. A value of True indicates a right-handed thread.</param>
    /// <param name="ThreadType">Input String that specifies the thread type. The thread type is the name of the sheet in the Thread.xls file that is used by the Thread command to define valid thread definitions.</param>
    /// <param name="ThreadDesignation">Input String that contains the thread designation. This is input as the full thread designation that will be used in a drawing for the thread callout. The nominal size information is extracted from the designation.</param>
    /// <returns></returns>
    [PreserveSig]
    TaperedThreadInfo CreateTaperedTapInfo([In] bool RightHanded, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string ThreadDesignation);
    /// <summary>
    /// Method that creates a new SketchHolePlacementDefinition object that can be used for defining the placement of Hole features using sketch points.
    /// </summary>
    /// <param name="HoleCenterPoints">ObjectCollection object that contains the SketchPoint objects that will be used to define the centers of the holes. All of the SketchPoint objects used as input must be within the same sketch.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchHolePlacementDefinition CreateSketchPlacementDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection HoleCenterPoints);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane">Plane</param>
    /// <param name="ReferenceEntityOne">ReferenceEntityOne</param>
    /// <param name="DistanceOne">DistanceOne</param>
    /// <param name="ReferenceEntityTwo">ReferenceEntityTwo</param>
    /// <param name="DistanceTwo">DistanceTwo</param>
    /// <param name="BiasPoint">BiasPoint</param>
    [PreserveSig]
    LinearHolePlacementDefinition CreateLinearPlacementDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.IDispatch)] object ReferenceEntityOne, [In] [MarshalAs(UnmanagedType.Struct)] object DistanceOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object ReferenceEntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object DistanceTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point BiasPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane">Plane</param>
    /// <param name="ConcentricReference">ConcentricReference</param>
    [PreserveSig]
    ConcentricHolePlacementDefinition CreateConcentricPlacementDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.IDispatch)] object ConcentricReference);
    /// <summary>
    /// Method that creates a new PointHolePlacementDefinition object that can be used for defining the placement of Hole features coincident with a work point and positioned with respect to an axis, edge or work plane.
    /// </summary>
    /// <param name="Point">Object that specifies the point to set as the hole center. The only valid input is a WorkPoint.</param>
    /// <param name="Direction">Object that specifies the direction of the hole axis. This can be a planar Face object or a WorkPlane object with which the axis of the hole is perpendicular, or an Edge or WorkAxis object with which the axis of the hole is parallel.</param>
    /// <returns></returns>
    [PreserveSig]
    PointHolePlacementDefinition CreatePointPlacementDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Point, [In] [MarshalAs(UnmanagedType.IDispatch)] object Direction);
    /// <summary>
    /// Creates a new ClearanceInfo object.
    /// </summary>
    /// <param name="FastenerStandard">Input String value that specifies the fastener standard. The standard is the name of the sheet in the Clearance.xls file that is used to define the clearance info.</param>
    /// <param name="FastenerType">Input String value that specifies the fastener type.</param>
    /// <param name="FastenerSize">Input String value that specifies the fastener size.</param>
    /// <param name="FastenerFitType">Optinal input FastenerFitTypeEnum value that specifies the fastener fit type. If not provided the default kNormalFitType will be used.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleClearanceInfo CreateClearanceInfo([In] [MarshalAs(UnmanagedType.BStr)] string FastenerStandard, [In] [MarshalAs(UnmanagedType.BStr)] string FastenerType, [In] [MarshalAs(UnmanagedType.BStr)] string FastenerSize, [In] [MarshalAs(UnmanagedType.Struct)] object? FastenerFitType = default);
    /// <summary>
    /// Method that creates a new drilled HoleFeature using distance extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter.</param>
    /// <param name="Depth">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddDrilledByDistanceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that creates a new countersink HoleFeature using distance extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter.</param>
    /// <param name="Depth">Input Variant that defines the depth of the hole. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="CSinkDiameter">Input Variant that defines the diameter of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CSinkAngle">Input Variant that defines the angle of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddCSinkByDistanceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkAngle, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that creates a new counterbore HoleFeature using distance extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter.</param>
    /// <param name="Depth">Input Variant that defines the depth of the hole. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="CBoreDiameter">Input Variant that defines the diameter of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CBoreDepth">Input Variant that defines the depth of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddCBoreByDistanceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDepth, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Creates a new SpotFace HoleFeature using distance extents.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter.</param>
    /// <param name="Depth">Input Variant that defines the depth of the hole. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ExtentDirection">Input constant that indicates which side of the sketch plane to extrude toward. Valid input is kPositive or kNegative. kPositive defines the offset direction to be in the same direction as the normal of the sketch plane.</param>
    /// <param name="SpotFaceDiameter">Input Variant that defines the diameter of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="SpotFaceDepth">Input Variant that defines the depth of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddSpotFaceByDistanceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.Struct)] object Depth, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDepth, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that creates a new drilled HoleFeature using 'to face' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ToFace">Input Object that defines the 'to face.' This can be either a or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the hole.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddDrilledByToFaceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that creates a new countersink HoleFeature using 'to face' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ToFace">Input Object that defines the 'to face.' This can be either a or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the hole.</param>
    /// <param name="CSinkDiameter">Input Variant that defines the diameter of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CSinkAngle">Input Variant that defines the angle of the countersink. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddCSinkByToFaceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CSinkAngle, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Method that creates a new counterbore HoleFeature using 'to face' extents. The new HoleFeature is returned.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ToFace">Input Object that defines the 'to face.' This can be either a or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the hole.</param>
    /// <param name="CBoreDiameter">Input Variant that defines the diameter of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="CBoreDepth">Input Variant that defines the depth of the counterbore. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddCBoreByToFaceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object CBoreDepth, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
    /// <summary>
    /// Creates a new SpotFace HoleFeature using to face extents.
    /// </summary>
    /// <param name="PlacementDefinition">Object that defines the centerpoint(s) of the hole feature. This object can be one of the following four objects that derive from the HolePlacementDefinition object: SketchHolePlacementDefinition, LinearHolePlacementDefinition, ConcentricHolePlacementDefinition, PointHolePlacementDefinition. These objects can be created using methods provided on this HoleFeatures object. This argument also supports an ObjectCollection of SketchPoints for compatibility with the older version of this method.</param>
    /// <param name="DiameterOrTapInfo">Defines either the diameter of the hole or the tap information (using a HoleTapInfo object). In the case of a tapped hole, the tap information defines the diameter of the hole. When the diameter is supplied, this can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="ToFace">Input Object that defines the 'to face.' This can be either a or WorkPlane object.</param>
    /// <param name="ExtendToFace">Input Boolean that defines whether the 'to face' should be extended to contain the extents of the hole.</param>
    /// <param name="SpotFaceDiameter">Input Variant that defines the diameter of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="SpotFaceDepth">Input Variant that defines the depth of the spotface. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="DrillPointType">Optional input DrillPointTypeEnum that specifies the drill point of the hole.  If specifies an angled drill point then the BottomTipAngle argument needs to be provided to specify the angle.  The default value is kFlatDrillPointType.</param>
    /// <param name="BottomTipAngle">Optional input Variant that defines the angle of the tip at the bottom of a hole. This argument is only used when the DrillPointType argument is kAngledDrillPointType, kAngledVDrillPointType or kAngledYDrillPointType. If this argument is not supplied a default value of 118 degrees is assigned.
    /// This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleFeature AddSpotFaceByToFaceExtent2([In] [MarshalAs(UnmanagedType.IDispatch)] object PlacementDefinition, [In] [MarshalAs(UnmanagedType.Struct)] object DiameterOrTapInfo, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDiameter, [In] [MarshalAs(UnmanagedType.Struct)] object SpotFaceDepth, [In] [MarshalAs(UnmanagedType.Struct)] object? DrillPointType = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BottomTipAngle = default);
}
