namespace Oblikovati.API;

/// <summary>
/// The FlatPunchResult object represents a single punch instance in the flat. A punch instance can result from a punch tool feature placed either in the folded model or in the flat pattern. A punch tool feature may define multiple punches, and every one of the resulting punch instances is represented by a FlatPunchResult object.
/// </summary>
public interface FlatPunchResult
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
    /// Property that returns the parent FlatPattern object.
    /// </summary>
    FlatPattern Parent { get; }
    /// <summary>
    /// Property that returns a string that uniquely identifies a punch instance within the flat pattern.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the faces in the flat pattern that belong to the punch result. This property returns Nothing if punch representation is not formed feature representation.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Property that returns the edges in the flat pattern that belong to the punch result. The property will return Nothing if the punch tool feature that resulted in this punch result does not have a sketch-based alternate representation defined for it.
    /// </summary>
    Edges SketchRepresentationEdges { get; }
    /// <summary>
    /// Property that returns the Id associated with the punch result. This is the Id assigned during creation of the punch feature and is the same for all instances of a punch feature.
    /// </summary>
    string PunchId { get; }
    /// <summary>
    /// Property that whether the direction of the punch is up or down.
    /// </summary>
    bool IsDirectionUp { get; }
    /// <summary>
    /// Property that returns a Point indicating the position of the punch instance in the flat pattern. This property may return Nothing if this information is not available.
    /// </summary>
    Point Position { get; }
    /// <summary>
    /// Property that returns an angle value indicating the punch orientation. This property may return an error if this information is not available.
    /// </summary>
    double Angle { get; }
    /// <summary>
    /// Gets whether there is a depth value associated with this punch result.
    /// </summary>
    bool HasDepth { get; }
    /// <summary>
    /// Property that returns the depth of the punch.
    /// </summary>
    double Depth { get; }
    /// <summary>
    /// Property that returns a Point indicating the position of the punch instance in the folded model.
    /// </summary>
    Point FoldedPosition { get; }
    /// <summary>
    /// Property that returns an angle value indicating the punch orientation in the folded model.
    /// </summary>
    double FoldedAngle { get; }
    /// <summary>
    /// Property that returns whether the punch feature that resulted in this punch result is currently suppressed.
    /// </summary>
    bool IsPunchSuppressed { get; }
    /// <summary>
    /// Property that returns whether the punch feature that resulted in this punch result is currently after the stop node.
    /// </summary>
    bool IsPunchAfterStopNode { get; }
}
