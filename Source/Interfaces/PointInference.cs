namespace Oblikovati.API;

/// <summary>
/// The PointInference object provides access to information that defines how the current point is being inferred.
/// </summary>
public interface PointInference
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
    /// Property that returns the type of inference.
    /// </summary>
    PointInferenceEnum InferenceType { get; }
    /// <summary>
    /// Property that returns the object(s) that were used in defining the inference. The enumerator contains a single GeometryIntent object when a drawing document is active.
    /// </summary>
    ObjectsEnumerator Entity { get; }
}
