namespace Oblikovati.API;

/// <summary>
/// Collection Object containing boss definitions of the rib.
/// </summary>
public interface BossSets : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns an item from the collection.  You can provide either the index of the item in the collection, where the first item is index 1, or you can provide the name of the object.
    /// </summary>
    BossSet this[int Index] { get; }
    /// <summary>
    /// Method that creates a new Boss set. The newly created BossSet object is returned.
    /// </summary>
    /// <param name="Centers">Input ObjectCollection containing SketchPoint objects that define boss centers.</param>
    /// <param name="Type">Input BossTypeEnum that defines the boss type.  This can either be kHeadBossType or kThreadBossType.</param>
    /// <param name="Diameter">Input Variant that defines the boss diameter. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Offset">Input Variant that defines the offset value. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <param name="Taper">Input Variant that defines the taper angle for the boss. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input, the units can be specified as part of the string or it will default to the current angle units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    BossSet Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Centers, [In] BossTypeEnum Type, [In] [MarshalAs(UnmanagedType.Struct)] object Diameter, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] [MarshalAs(UnmanagedType.Struct)] object Taper);
}
