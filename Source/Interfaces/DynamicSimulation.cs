namespace Oblikovati.API;

/// <summary>
/// The DynamicSimulation object represents a single dynamic simulation.
/// </summary>
public interface DynamicSimulation
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
    /// Gets the parent SimulationManager object.
    /// </summary>
    SimulationManager Parent { get; }
    /// <summary>
    /// Gets and sets the current time step of the animation. Valid values are 1 to the LastComputedTimeStep.
    /// </summary>
    int CurrentTimeStep { get; set; }
    /// <summary>
    /// Gets the DSJoints object which provides access to all of the joints associated with this simulation.
    /// </summary>
    DSJoints DSJoints { get; }
    /// <summary>
    /// Gets the DSLoads object which provides access to all of the loads associated with this simulation.
    /// </summary>
    DSLoads DSLoads { get; }
    /// <summary>
    /// Gets the DSSettings object which provides access to settings associated with this simulation.
    /// </summary>
    DSSettings DSSettings { get; }
    /// <summary>
    /// Toggles the simulation between simulation and construction modes.
    /// </summary>
    bool IsInSimulationMode { get; set; }
    /// <summary>
    /// Gets and sets the number of time steps for the entire simulation.
    /// </summary>
    int NumberOfTimeSteps { get; set; }
    /// <summary>
    /// Gets and sets the speed when playing a simulation.&nbsp;A value of 1 indicates that every time step should be shown, a value of 5 indicates that every fifth time step should be shown, etc.
    /// </summary>
    int PlaybackSpeed { get; set; }
    /// <summary>
    /// Gets and sets the simulation length of the simulation in seconds.
    /// </summary>
    double SimulationLength { get; set; }
    /// <summary>
    /// Gets the last computed time step of the simulation.
    /// </summary>
    int LastComputedTimeStep { get; }
    /// <summary>
    /// Plays the simulation between the specified time steps. The time steps being played must have already been computed.
    /// </summary>
    /// <param name="StartStep">Input Long that specifies the starting time step of the playback.  If not specified then the first time step of the simulation is used.  This value must be less than the end time step or an error will occur.</param>
    /// <param name="EndStep">Input Long that specifies the ending time step of the playback.  If not specified then the last computed time step of the simulation is used.  The last computed time step can be found using the LastComputedTimeStep property.  If a value is specified that is greater than the last computed time step and error will occur.</param>
    [PreserveSig]
    void PlaySimulation([In] int? StartStep = default, [In] int? EndStep = default);
    /// <summary>
    /// Computes the simulation starting at the current time step and ending at the specified time step.
    /// </summary>
    /// <param name="EndStep">Input Long that specifies the ending time step of the compute.  If not specified then the last time step of the simulation is used.  If a value greater than the number of time steps in the simulation is specified, an error will occur.</param>
    [PreserveSig]
    void ComputeSimulation([In] int? EndStep = default);
}
