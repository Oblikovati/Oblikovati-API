namespace Oblikovati.API;

/// <summary>
/// The FlatBendResult object represents a single bend instance in the flat. A bend instance can result from a feature placed either in the folded model or in the flat pattern. A bend feature may define multiple bends, and every one of the resulting bend instances is represented by a FlatBendResult object.
/// </summary>
public interface FlatBendResult
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
    /// Property that returns a string that uniquely identifies a bend instance within the flat pattern.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the edge in the flat pattern that belongs to the bend result.
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Property that returns whether the direction of the bend is up or down.
    /// </summary>
    bool IsDirectionUp { get; }
    /// <summary>
    /// Property that returns the angle of the bend.
    /// </summary>
    double Angle { get; }
    /// <summary>
    /// Property that returns the inner radius of the bend.
    /// </summary>
    double InnerRadius { get; }
    /// <summary>
    /// Property that returns whether this bend result is on the bottom face of the flat pattern. Every bend has two coresponding bend results on the flat pattern one on the top face and one on the bottom face.
    /// </summary>
    bool IsOnBottomFace { get; }
    /// <summary>
    /// Read-only property that returns the K-Factor value associated with this bend.
    /// </summary>
    double kFactor { get; }
    /// <summary>
    /// Property that returns the Bend object associated with this bend result.
    /// </summary>
    Bend Bend { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BenderOrder">BenderOrder</param>
    /// <param name="BendOrderSourceType">BendOrderSourceType</param>
    [PreserveSig]
    void GetBendOrder([Out] out int BenderOrder, [Out] out BendOrderSourceTypeEnum BendOrderSourceType);
    /// <summary>
    /// Method that sets the bend order for this bend result. This will define a bend order override for this bend result.
    /// </summary>
    /// <param name="BenderOrder">Input Long that defines the order of this bend.</param>
    /// <param name="AllowDuplicate">Input Boolean that indicates if duplicate bend order values are allowed. If True and the specified bend order value already exists on another bend result, the same bend order will be assigned to this bend result and both bend results will be defined to have an duplicate override bend order. If False and the value specified already exists then the bend values on the other bend results will modified to make room for this value.</param>
    [PreserveSig]
    void SetBendOrder([In] int BenderOrder, [In] bool AllowDuplicate);
}
