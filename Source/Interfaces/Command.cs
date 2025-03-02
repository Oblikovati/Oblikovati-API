namespace Oblikovati.API;

/// <summary>
/// Command Object. Encapsulation of the data on a UI command element.
/// </summary>
public interface Command
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    int Id { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    string Caption { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    string DescriptionText { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Use F1 key to display help topic.
    /// </summary>
    [PreserveSig]
    void Delete();
}
