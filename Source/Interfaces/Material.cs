namespace Oblikovati.API;

/// <summary>
/// The Material object provides access to all of the properties that define a specific material.
/// </summary>
public interface Material
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that gets and sets the density of the material. The density is mass per unit volume. The units density is defined in are g/cm^3 (grams/cubic centimeter).
    /// </summary>
    double Density { get; set; }
    /// <summary>
    /// Property that gets and sets Young's modulus or the modulus of elasticity for the material. Young's modulus the ratio of stress: ? (force/area) to strain, ? (? change in length / original length ); ? = E?. The units Young's modulus is defined in are the same as for pressure (force/area), gigaPascals (GPa).
    /// </summary>
    double YoungsModulus { get; set; }
    /// <summary>
    /// Property that gets and sets Poisson's Ratio for the material. Poisson's Ratio is a measure of how much a material will laterally contract or expand as a sample of it is stretched or compressed, respectively.
    /// </summary>
    double PoissonsRatio { get; set; }
    /// <summary>
    /// Property that gets and sets the yield strength of the material. The yield strength is the stress at which the material begins to permanently deform. The units yield strength is defined in are megaPascals (Mpa).
    /// </summary>
    double YieldStrength { get; set; }
    /// <summary>
    /// Property that gets and sets the ultimate tensile strength of the material. The ultimate tensile strength is the stress at which the material fails. The units tensile strength is defined in are megaPascals (Mpa).
    /// </summary>
    double UltimateTensileStrength { get; set; }
    /// <summary>
    /// Property that gets and sets thermal conductivity of the material. The thermal conductivity is the amount of heat energy transferred through a material per unit length and per one degree of temperature. The units thermal conductivity is defined in are W/[m*K] (Watts / meter ? ? Kelvin).
    /// </summary>
    double ThermalConductivity { get; set; }
    /// <summary>
    /// Property that gets and sets the linear expansion of the material. The linear expansion is the measure of how much a material expands as it is heated. The units linear expansion is defined in are 10^5m/m/C (change in length / original length / Celsius).
    /// </summary>
    double LinearExpansion { get; set; }
    /// <summary>
    /// Property that gets and sets the specific heat of the material. The specific heat is a measure of how much heat energy a material can store (absorb) per unit of mass per unit of temperature. The units specific heat is defined in are J / [kg*K] (Joules / kilogram - K).
    /// </summary>
    double SpecificHeat { get; set; }
    /// <summary>
    /// Property that gets and sets the render style associated with the material.
    /// </summary>
    RenderStyle RenderStyle { get; set; }
    /// <summary>
    /// Property that indicates the name of this object or instance.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that indicates the location status ( ) of this material style.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that returns the unique name of the material.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// If a property of both a Local and Global style is changed, its UpToDate property returns False until UpdateFromGlobal is called. UpdateFromGlobal undoes any changes made locally on this style, so then the UpToDate property will return True.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Property that indicates if this material style is in use in the document.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Gets/Sets the external material id associated with the material.
    /// </summary>
    string ExternalMaterialId { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _IsIsotropicMaterial { get; }
    /// <summary>
    /// Method that copies the material and assigns the specified name to the new material. The new material is returned by the method.
    /// </summary>
    /// <param name="NewName">Input String that specifies the name for the new material. This name must be unique with respect to all other materials in the document. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    Material Copy([In] [MarshalAs(UnmanagedType.BStr)] string NewName);
    /// <summary>
    /// Method that deletes the Material.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style. This method fails if this style is already local. Use the Local property to determine whether the style is local.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Material ConvertToLocal();
    /// <summary>
    /// Method that saves this material to the global repository.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this material from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
}
