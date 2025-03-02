namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis at the axis of a revolved face.
/// </summary>
public interface RevolvedFaceWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the used to define the revolved face work axis. This object must be a Face object whose geometry is a revolved surface. Valid surface types include cylinders, cones, and toroids.
    /// </summary>
    Face Face { get; }
}
