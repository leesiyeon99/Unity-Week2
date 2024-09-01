using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Util
{
    public interface IObserver
    {
        public void OnNotify();
    }

    public class Subject
    {
        private List<IObserver> observers = new();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void UnsubscribeAll(IObserver observer)
        {
            observers.RemoveAll(x => true);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.OnNotify();
            }
        }
    }
}
