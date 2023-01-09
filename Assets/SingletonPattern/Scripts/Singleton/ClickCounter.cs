/*
Possible questions regarding the Singleton class:

Q - Where is the private constructor from the UML diagram?
A - The purpose of the private constructor is to prevent further instances from being
created after the code starts executing. In Unity, however, a newly loaded scene may already
contain a running singleton instance, rendering the constructor useless. To resolve this, an
instance check inside the Awake method is used to exclude duplicate instances whenever they
are created.

Q - Where is the static instance property from the UML diagram?
A - Usually, the static instance property is used for lazy instantiating a singleton. In
Unity, however, due to its scene-oriented architecture, unless the user wants to instantiate
a singleton specifically during a scene, this is unnecessary. Instead, it is simpler to make
every property of the singleton static instead.
*/
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    // Each ClickCounter instance will share the same _instance value.
    private static ClickCounter _instance;
    
    /*
    Warning: This is where the single-responsibility principle is violated, as now this
    class will be responsible both for enforcing its uniqueness and registering the number
    of clicks.
    */
    private int _clicks;

    // Warning: This is where potential dependencies on the singleton can be introduced.
    public static int GetClicks()
    {
        return _instance._clicks;
    }

    private void Awake()
    {
        void InstanceCheck()
        {
            // If no instances were previously registered...
            if (_instance == null)
            {
                // ...register this instance.
                _instance = this;
            }
            else if (_instance != this)
            {
                // Destroys the GameObject containing this script.
                Destroy(gameObject);
            }
        }

        InstanceCheck();
        /*
        Prevents the GameObject this script is attached to from being destroyed on load to
        avoid resetting its variables values. While it would also be possible to simply make
        _clicks a public static variable, this would be a bad practice, as debugging it
        would get significantly more difficult without using properties instead.
        */
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            void Increment()
            {
                _clicks++;                
            }

            Increment();
        }
    }
}
