using System.Collections;
using System.Collections.Generic;

public class Singleton{
    private static Singleton _instance = null;

    private Singleton()
    {
    }

    public static Singleton _instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
