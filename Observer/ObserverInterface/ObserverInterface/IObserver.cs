namespace ObserverInterface
{
    public interface IObserver
    {
        public void OnNext(string value);
        public void OnError(Exception error);
        public void OnComleted();
    }
}