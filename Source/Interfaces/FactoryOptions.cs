namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface FactoryOptions
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
    /// Gets and sets whether the part number displayed in the iPart factory table is indexed.
    /// </summary>
    bool IsPartNumberIndexed { get; set; }
    /// <summary>
    /// Gets and sets the number of digits to use for the member name index.
    /// </summary>
    int MemberNameIndexDigits { get; set; }
    /// <summary>
    /// Gets and sets the starting value of the member name index.
    /// </summary>
    int MemberNameIndexInitialValue { get; set; }
    /// <summary>
    /// Gets and sets the separator for the member name index.
    /// </summary>
    string MemberNameIndexSeparator { get; set; }
    /// <summary>
    /// Gets and sets the step value for the member name index.
    /// </summary>
    int MemberNameIndexStepValue { get; set; }
    /// <summary>
    /// Gets and sets the custom text value for the member name.
    /// </summary>
    string MemberNameValue { get; set; }
    /// <summary>
    /// Gets and sets the type of value to use for the member name.
    /// </summary>
    FactoryOptionsMemberNameTypeEnum MemberNameType { get; set; }
    /// <summary>
    /// Gets and sets the number of digits to use for the part number index.
    /// </summary>
    int PartNumberIndexDigits { get; set; }
    /// <summary>
    /// Gets and sets the starting value of the part number index.
    /// </summary>
    int PartNumberIndexInitialValue { get; set; }
    /// <summary>
    /// Gets and sets the separator for the part number index.
    /// </summary>
    string PartNumberIndexSeparator { get; set; }
    /// <summary>
    /// Gets and sets the step value for the part number index.
    /// </summary>
    int PartNumberIndexStepValue { get; set; }
    /// <summary>
    /// Gets and sets the custom text value for the part number.
    /// </summary>
    string PartNumberValue { get; set; }
    /// <summary>
    /// Gets and sets the type of value to use for the part number.
    /// </summary>
    FactoryOptionsPartNumberTypeEnum PartNumberType { get; set; }
    /// <summary>
    /// Method that applies the factory options to all members of the factory including existing ones. By default, any factory options specified using the FactoryOptions object will only apply to newly created members. If the options need to be applied to existing members also, this method needs to be called.
    /// </summary>
    [PreserveSig]
    void ApplyToAllMembers();
}
