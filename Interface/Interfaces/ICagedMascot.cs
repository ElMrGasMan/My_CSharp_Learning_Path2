namespace Inheritance.Interfaces
{
    /// <summary>
    /// Interface made ONLY for mascots that MUST be caged. 
    /// Eg: Dogs can be caged, but not necessarily so, as such they don't implement the interface. 
    /// </summary>
    internal interface ICagedMascot
    {
        double SpaceSquareMet();
        string MaterialCage();
    }
}
