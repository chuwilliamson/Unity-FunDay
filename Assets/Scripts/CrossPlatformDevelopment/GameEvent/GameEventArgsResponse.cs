using System;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace CrossPlatformDevelopment.GameEvent
{
    [Serializable]
    public class GameEventArgsResponse : UnityEvent<Object[]>
    {
    }
}