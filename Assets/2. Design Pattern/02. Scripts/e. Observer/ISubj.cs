namespace Observer2
{
    public interface ISubj
    {
        void AddObs(IObs obs);  // +=
        void RemoveObs(IObs obs);   // -=
        void NotifyObs();   // Invoke();
    }
}