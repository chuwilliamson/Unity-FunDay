using UnityEngine;

namespace CrossPlatformDevelopment.GameEvent
{
    public class GameEventArgsListener : MonoBehaviour, IListener
    {
        public GameEventArgs Event;

        [TextArea(3, 5)] public string Notes;

        public GameEventArgsResponse Response;
        public Object Sender;

        public virtual void OnEventRaised(Object[] args)
        {
            //UnityEngine.Assertions.Assert.IsTrue(Sender != null);

            if (Sender == null || Sender == args[0])
                Response.Invoke(args);
        }

        public void Subscribe()
        {
            Event.RegisterListener(this);
        }

        public void Unsubscribe()
        {
            Event.UnregisterListener(this);
        }

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }
    }
}