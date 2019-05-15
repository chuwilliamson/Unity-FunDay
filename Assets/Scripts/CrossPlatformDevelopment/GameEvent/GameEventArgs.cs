using System.Collections.Generic;
using UnityEngine;

namespace CrossPlatformDevelopment.GameEvent
{
    [CreateAssetMenu]
    public class GameEventArgs : ScriptableObject, ISubscribeable
    {
        public List<IListener> listeners = new List<IListener>();

        public void RegisterListener(IListener listener)
        {
            if (listeners.Contains(listener))
            {
                Debug.LogError("listener is already in list");
                return;
            }

            listeners.Add(listener);
        }

        public void UnregisterListener(IListener listener)
        {
            if (!listeners.Contains(listener))
            {
                Debug.LogError("listener is not in list");
                return;
            }

            listeners.Remove(listener);
        }

        public void Raise()
        {
            Raise(null);
        }

        public void Raise(params Object[] args)
        {
            for (var i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised(args);
        }
    }
}