using System.Collections.Generic;

public interface ICommando : ISpecialisedSoldier
{
    List<IMissions> Missions { get; }

    void CompleteMission();
}