﻿using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Counter: ISubject
    {
        private List<IObserver> observers;
        private int count;
        public Counter()
        {
            observers = new List<IObserver>();
            count = 0;
        }
        public void Increment()
        {
            count++;
            NotifyObservers();
        }
        public void Decrement()
        {
            if (count > 0)
            {
                count--;
                NotifyObservers();
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
            observer.UpdateObs();
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public List<IObserver> GetObservers()
        {
            return observers;
        }

        public void NotifyObservers()
        {
            foreach (IObserver ob in observers)
            {
                ob.UpdateObs();
            }
        }
        public int GetState()
        {
            return count;
        }
    }
}
