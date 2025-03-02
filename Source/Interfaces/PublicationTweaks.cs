namespace Oblikovati.API;

/// <summary>
/// PublicationTweaks collection object.
/// </summary>
public interface PublicationTweaks : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PublicationTweak this[int Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets Origin Geometry Intent.
    /// </summary>
    GeometryIntent TriadOrigin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets Alignment Geometry.
    /// </summary>
    object TriadAlignment { get; set; }
    /// <summary>
    /// Read-Only property that get triad matrix.
    /// </summary>
    Matrix TriadMatrix { get; }
    /// <summary>
    /// Read-write property that gets and sets whether there is selected component.
    /// </summary>
    bool HasSelectedComponent { get; set; }
    /// <summary>
    /// Read-write property that gets and sets to select origin.
    /// </summary>
    bool SelectTriadOrigin { get; set; }
    /// <summary>
    /// Read-write property that gets and sets to select alignment.
    /// </summary>
    bool SelectTriadAlignment { get; set; }
    /// <summary>
    /// Read-write property that gets and sets Local/World.
    /// </summary>
    bool Local { get; set; }
    /// <summary>
    /// Read-write property that gets and sets to select trail anchor.
    /// </summary>
    bool SelectTrailAnchor { get; set; }
    /// <summary>
    /// Read-write property that gets and sets to select trail segment.
    /// </summary>
    bool SelectTrailSegment { get; set; }
    /// <summary>
    /// Read-only property that gets trail anchor points.
    /// </summary>
    ObjectCollection TrailAnchors { get; }
    /// <summary>
    /// Read-only property that gets trail segments to delete.
    /// </summary>
    ObjectCollection TrailSegments { get; }
    /// <summary>
    /// Read-write property that gets and sets whether to add or delete the full trail when edit.
    /// </summary>
    bool FullTrailOperationMode { get; set; }
    /// <summary>
    /// Read-write property that gets and sets to select tweak path.
    /// </summary>
    bool SelectTweakPath { get; set; }
    /// <summary>
    /// Read-write property that gets and sets tweak for preview.
    /// </summary>
    PublicationTweak TweakForPreview { get; set; }
    /// <summary>
    /// Method that adds a new PublicationTweak object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PublicationTweak Add([In] [MarshalAs(UnmanagedType.Interface)] PublicationTweakDefinition Definition);
    /// <summary>
    /// Method that creates a PublicationTweakDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    PublicationTweakDefinition CreateTweakDefinition([In] TweakTypeEnum TweakType, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection PublicationComponents, [In] [MarshalAs(UnmanagedType.Struct)] object? DirectionOrAxis = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Distance = default, [In] [MarshalAs(UnmanagedType.Struct)] object? RotationAngle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Transform = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayTrails = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StartTime = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EndTime = default);
    /// <summary>
    /// Method that starts to monitor the selection in an interaction events for triad origin.
    /// </summary>
    [PreserveSig]
    void StartToMonitorTriadOriginSelection();
    /// <summary>
    /// Method that ends to monitor the selection in an interaction events for triad origin.
    /// </summary>
    [PreserveSig]
    void EndToMonitorTriadOriginSelection();
    /// <summary>
    /// Method to clear the trail info.
    /// </summary>
    [PreserveSig]
    void ClearTrailInfo();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Definition">Definition</param>
    /// <param name="IsBrepUnattached">IsBrepUnattached</param>
    [PreserveSig]
    PublicationTweak Add2([In] [MarshalAs(UnmanagedType.Interface)] PublicationTweakDefinition Definition, [In] bool IsBrepUnattached);
}
