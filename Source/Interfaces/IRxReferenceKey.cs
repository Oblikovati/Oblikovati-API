namespace Oblikovati.API;

public interface IRxReferenceKey
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Guid ObjectType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IntPtr Key { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int TransientKey { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Guid RevisionId { get; }
}
