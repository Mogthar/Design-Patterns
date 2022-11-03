using System.Collections;
using System.Collections.Generic;

public class Observer{
    public Observer(){};

    public Notify(Message message){
        switch(message){
            case EVENT_1:
              // do something
              break;

            case EVENT_2:
              // do something
              break;

            case NULL:
              // raise an error
              break;

            default:
              Console.WriteLine("Was notified but have nothing to do");
              break;
        }
    }
}


public class Subject{
    private List<Observer> _observerList;

    public Subject(){
        _observerList = new List<Observer>();
    }

    public void AddObserver(Observer observer){
        _observerList.Add(observer);
    }

    public void RemoveObserver(Observer observer){
        // might first need to check if observer is in the list
        _observerList.Remove(observer)
    }

    public void NotifyObservers(Message message){
        foreach(Observer myObserver in _observerList){
            myObserver.Notify(message);
        }
    }

}

public enum Message{
    EVENT_1,
    EVENT_2,
    NULL
}
