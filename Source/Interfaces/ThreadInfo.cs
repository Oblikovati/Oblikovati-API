namespace Oblikovati.API;

/// <summary>
/// This is a common base object from which the rest of the concrete objects that hold thread information are derived. It contains the generally applicable properties of threads.
/// </summary>
public interface ThreadInfo
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
    /// Gets and sets the thread type.
    /// </summary>
    string ThreadType { get; set; }
    /// <summary>
    /// Property that returns the string that identifies the thread type. This string is not localized and should not be changed by the user. The thread type is the name of the sheet in the Thread.xls file.
    /// </summary>
    string ThreadTypeIdentifier { get; }
    /// <summary>
    /// Gets and sets whether this thread is metric or not.
    /// </summary>
    bool Metric { get; set; }
    /// <summary>
    /// Gets and sets whether this is an internal thread or external (False).
    /// </summary>
    bool Internal { get; set; }
    /// <summary>
    /// Gets and sets whether this is a right handed thread or left handed (False).
    /// </summary>
    bool RightHanded { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _NominalSizeDescription { get; set; }
    /// <summary>
    /// Property that returns a string that contains the thread designation. This is the full thread designation that is used in a drawing for the thread callout.
    /// </summary>
    string ThreadDesignation { get; }
    /// <summary>
    /// Indicates the custom thread designation from the Custom Thread Designation column of the thread data spreadsheet.
    /// </summary>
    string CustomThreadDesignation { get; }
    /// <summary>
    /// Property that returns an enumerator of Point objects indicating the base points for the thread. Typically, there is only one item in the collection. The exception is a hole feature based on multiple sketch points, in which case there are as many Point objects returned as there are sketch points. The point accounts for any offsets applied to the thread. The property returns a point only when the ThreadInfo object is obtained from a feature and returns Nothing in the forward create scenario.
    /// </summary>
    ObjectsEnumerator ThreadBasePoints { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    UnitVector _ThreadDirection { get; }
    /// <summary>
    /// Property that returns the direction of the thread. The property returns a vector only when the ThreadInfo object is obtained from a feature and returns Nothing in the forward create scenario.
    /// </summary>
    Vector ThreadDirection { get; }
    /// <summary>
    /// Gets whether this thread is the full length of the cylinder or cone.
    /// </summary>
    bool FullThreadDepth { get; set; }
}
