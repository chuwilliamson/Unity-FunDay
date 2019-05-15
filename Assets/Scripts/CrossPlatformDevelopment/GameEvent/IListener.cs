using UnityEngine;

namespace CrossPlatformDevelopment.GameEvent
{
    public interface IListener
    {
        void OnEventRaised(Object[] args);
        void Subscribe();
        void Unsubscribe();
    }
}