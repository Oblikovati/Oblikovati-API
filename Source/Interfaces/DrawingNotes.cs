namespace Oblikovati.API;

/// <summary>
/// The DrawingNotes collection object provides access to all of the drawing notes on the sheet.
/// </summary>
public interface DrawingNotes : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the specified DrawingNote object from the collection.
    /// </summary>
    DrawingNote Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the collection of general notes on the sheet.
    /// </summary>
    GeneralNotes GeneralNotes { get; }
    /// <summary>
    /// Property that returns the collection of leader notes on the sheet.
    /// </summary>
    LeaderNotes LeaderNotes { get; }
    /// <summary>
    /// Property that returns the collection of chamfer notes on the sheet.
    /// </summary>
    ChamferNotes ChamferNotes { get; }
    /// <summary>
    /// Property that returns the collection of bend notes on the sheet.
    /// </summary>
    BendNotes BendNotes { get; }
    /// <summary>
    /// Property that returns the collection of punch notes on the sheet.
    /// </summary>
    PunchNotes PunchNotes { get; }
    /// <summary>
    /// Property that returns the collection of hole and thread notes on the sheet.
    /// </summary>
    HoleThreadNotes HoleThreadNotes { get; }
}
