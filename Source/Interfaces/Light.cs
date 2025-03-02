namespace Oblikovati.API;

/// <summary>
/// The Light object provides access to all of the properties that define a specific light source.
/// </summary>
public interface Light
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent of the object.
    /// </summary>
    LightingStyle Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returning kLightObject indicating the type of object.
    /// </summary>
    LightTypeEnum LightType { get; set; }
    /// <summary>
    /// Returning the light definition type.
    /// </summary>
    LightDefinitionTypeEnum LightDefinitionType { get; set; }
    /// <summary>
    /// Gets and sets the color of the light source.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and sets the intensity value.
    /// </summary>
    double Intensity { get; set; }
    /// <summary>
    /// Gets and sets whether this light is switched on.
    /// </summary>
    bool On { get; set; }
    /// <summary>
    /// Gets and sets the position of the light in model space.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Gets and sets the direction of the light.
    /// </summary>
    Vector Direction { get; set; }
    /// <summary>
    /// Gets and sets the SpotLightFalloff value.
    /// </summary>
    double SpotLightFalloff { get; set; }
    /// <summary>
    /// Gets and sets the SpotLightInnerAngle value.
    /// </summary>
    double SpotLightInnerAngle { get; set; }
    /// <summary>
    /// Gets and sets the SpotLightCutoffAngle value.
    /// </summary>
    double SpotLightCutoffAngle { get; set; }
    /// <summary>
    /// Gets and sets the QuadraticAttenuation value.
    /// </summary>
    double ConstantAttenuation { get; set; }
    /// <summary>
    /// Gets and sets the LinearAttenuation value.
    /// </summary>
    double LinearAttenuation { get; set; }
    /// <summary>
    /// Gets and sets the QuadraticAttenuation value.
    /// </summary>
    double QuadraticAttenuation { get; set; }
}
