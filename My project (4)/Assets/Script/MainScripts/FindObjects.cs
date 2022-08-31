using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObjects : MonoBehaviour
{
   public List<SpawnerFacade> FindSpawners()
   {
      List<SpawnerFacade> spawnerFacades = new List<SpawnerFacade>();

      foreach (var i in FindObjectsOfType<SpawnerFacade>())
      {
        spawnerFacades.Add(i);
      }

      return spawnerFacades;
   }

    public PlayerSpawner FindPlayerSpawner(PlayerSpawner Predicate)
    {
        PlayerSpawner PlayerSpawners =  new PlayerSpawner();

        foreach (var i in FindObjectsOfType<PlayerSpawner>())
        {
          if (PlayerSpawners = Predicate)
          {
              PlayerSpawners = i;
          }
        }

        return PlayerSpawners;
    }
    public List<PlayerSpawner> FindPlayerSpawners()
    {
        List<PlayerSpawner> PlayerSpawners = new List<PlayerSpawner>();

        foreach (var i in FindObjectsOfType<PlayerSpawner>())
        {
            PlayerSpawners.Add(i);
        }

        return PlayerSpawners;
    }
    
}
