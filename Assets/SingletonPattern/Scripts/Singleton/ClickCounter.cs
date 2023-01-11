/*
Possible questions regarding the Singleton class:

Q - Where is the private constructor from the UML diagram?
A - The purpose of the private constructor is to prevent further instances from being
created after the code starts executing. In Unity, however, a newly loaded scene may already
contain a running singleton instance, rendering the constructor useless. To resolve this, an
instance check inside the Awake method is used to exclude duplicate instances whenever they
are created.

Q - Is is not simpler to make all singleton methods public static instead of using a static
GetInstance property? In this way, other scripts will be able to communicate with this
singleton with less typing (e.g: ClickCounter.GetClicks(), as opposed to 
ClickCounter.GetInstance().GetClicks()).
A - There are two main reasons why the singleton instance is worth referring to in other
scripts.
1. Abstraction: it makes sense to access the data of a singleton by accessing its only
existing instance first. Besides, seeing the instance reference will remind the user that the
class being accessed is a singleton.
2. Lazy instantiation: While in Unity, due to its scene-oriented architecture, lazy
instantiating a singleton is often unnecessary (unless the user wants to instantiate a
singleton specifically during a scene), this tactic is widely used outside of this game
engine, which means that using this design will improve the readability of the code for
outsiders.
*/
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    // Each ClickCounter instance will share the same _instance value.
    private static ClickCounter _instance;
    
    public static ClickCounter GetInstance()
    {
        return _instance;
    }

    /*
    Warning: This is where the single-responsibility principle is violated, as now this
    class will be responsible both for enforcing its uniqueness and registering the number
    of clicks.
    */
    private int _clicks;

    // Warning: This is where potential dependencies on the singleton can be introduced.
    public int GetClicks()
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
