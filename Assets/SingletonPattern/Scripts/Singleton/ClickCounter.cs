using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private static ClickCounter _instance;
    /*
    Warning: This is where the single-responsibility principle is violated, as now this
    class will be responsible both for enforcing its uniqueness and registering the number
    of clicks.
    */
    private int _clicks;

    /*
    This private constructor prevents further instances from being created after the
    InstanceCheck method in Awake.
    */
    private ClickCounter(){}

    private void Awake()
    {
        void InstanceCheck()
        {
            // If no instances were previously registered...
            if (_instance == null)
            {
                /*
                ...register this instance and don't destroy the gameObject it's attached to
                on load.
                */
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (_instance != this)
            {
                Destroy(gameObject);
            }
        }

        InstanceCheck();
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

    /*
    Warning: This is where potential dependencies on the singleton can be introduced.
    */
    public static int GetClicks()
    {
        return _instance._clicks;
    }
}
