namespace Oblikovati.API;

/// <summary>
/// RigidBodyJoint Object.
/// </summary>
public interface RigidBodyJoint
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
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    RigidBodyJoints Parent { get; }
    /// <summary>
    /// Property that returns a collection containing the original assembly constraints that were used to derived this particular joint.
    /// </summary>
    AssemblyConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Read-only property that returns a collection containing the original assembly joints that were used to derived this particular joint.
    /// </summary>
    AssemblyJointsEnumerator Joints { get; }
    /// <summary>
    /// Property that returns the type of joint.
    /// </summary>
    RigidBodyJointTypeEnum JointType { get; }
    /// <summary>
    /// Property that returns the first of the two groups this joint is between.
    /// </summary>
    RigidBodyGroup GroupOne { get; }
    /// <summary>
    /// Property that returns the second of the two groups this joint is between.
    /// </summary>
    RigidBodyGroup GroupTwo { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="GeometryOne">GeometryOne</param>
    /// <param name="GeometryTwo">GeometryTwo</param>
    /// <param name="AdditionalInfo">AdditionalInfo</param>
    [PreserveSig]
    void GetJointData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object GeometryOne, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object GeometryTwo, [Out] [MarshalAs(UnmanagedType.Interface)] out NameValueMap AdditionalInfo);
}
