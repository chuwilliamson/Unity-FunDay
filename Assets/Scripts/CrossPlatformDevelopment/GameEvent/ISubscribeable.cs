namespace CrossPlatformDevelopment.GameEvent
{
    public interface ISubscribeable
    {
        void RegisterListener(IListener listener);
        void UnregisterListener(IListener listener);
    }
}