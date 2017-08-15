using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private List<ISoldier> army;
    public void StartUp()
    {
        army = new List<ISoldier>();

        string inputLine;

        while ((inputLine = Console.ReadLine()) != "End")
        {
            var soldierTokens = inputLine.Split();

            var id = soldierTokens[1];
            var firstName = soldierTokens[2];
            var lastName = soldierTokens[3];
            var salary = double.Parse(soldierTokens[4]);

            switch (soldierTokens[0])
            {
                case "Private":
                    var privat = new Private(id, firstName, lastName, salary);
                    army.Add(privat);
                    break;

                case "LeutenantGeneral":
                    var soldiers = GetPrivatesData(soldierTokens.Skip(5).ToList());
                    var leutenant = new LeutenantGeneral(id, firstName, lastName, salary, soldiers);
                    army.Add(leutenant);
                    break;

                case "Engineer":
                    if (soldierTokens[5] != "Airforces" && soldierTokens[5] != "Marines")
                    {
                        break;
                    }
                    var repairs = ExctractPartsList(soldierTokens.Skip(6).ToList());
                    var engineer = new Engineer(id, firstName, lastName, salary, soldierTokens[5], repairs);
                    army.Add(engineer);
                    break;

                case "Commando":
                    var corp = soldierTokens[5];
                    if (corp != "Airforces" && corp != "Marines")
                    {
                        break;
                    }
                    var missions = GetMissionsData(soldierTokens.Skip(6).ToList());
                    var commando = new Commando(id, firstName, lastName, salary, corp, missions);
                    army.Add(commando);
                    break;
            }
        }

        foreach (var soldier in army)
        {
            Console.WriteLine(soldier);
        }

    }

    private List<IMissions> GetMissionsData(List<string> missionList)
    {
        var missions = new List<IMissions>();

        for (int i = 1; i < missionList.Count; i += 2)
        {
            if (missionList[i] == "inProgress")
            {
                missions.Add(new Mission(missionList[i - 1], missionList[i]));
            }
        }
        return missions;
    }

    private List<IRepair> ExctractPartsList(List<string> repairs)
    {
        var repairsList = new List<IRepair>();

        for (int i = 1; i < repairs.Count ; i+=2)
        {
            repairsList.Add(new Repair(repairs[i - 1], int.Parse(repairs[i])));
        }
        return repairsList;
    }

    private List<ISoldier> GetPrivatesData(List<string> soldiers)
    {
        var soldiersList = new List<ISoldier>();

        foreach (var soldier in soldiers)
        {
            soldiersList.Add(army.First(s => s.Id == soldier));
        }

        return soldiersList;
    }
}
