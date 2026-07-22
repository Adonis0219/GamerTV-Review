using NUnit.Framework;
using Observer;
using System.Collections.Generic;
using UnityEngine;

namespace Observer2
{
    public class Subject : MonoBehaviour, ISubj
    {
        List<IObs> observers = new List<IObs>();

        public void AddObs(IObs obs)
        {
            observers.Add(obs);
        }

        public void RemoveObs(IObs obs)
        {
            observers.Remove(obs);
        }

        public void NotifyObs()
        {
            for (int i = 0; i < observers.Count; i++)
                observers[i].UpdateObs();
        }
    }
}

