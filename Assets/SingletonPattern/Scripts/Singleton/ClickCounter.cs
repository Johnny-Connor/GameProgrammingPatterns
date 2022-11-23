using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    /*
    This variable will store the first instance of this class. Making it public and static
    makes this class accessible from anywhere.
    Warning: This is where potential dependencies (on the singleton) can be introduced.
    */
    public static ClickCounter instance;
    /*
    Warning: This is where the single-responsibility principle is violated, as now this
    class will be responsible for enforcing its uniqueness and registering the number of
    clicks.
    */
    public int totalClicks;

    /*
    This private constructor prevents further instances from being created after the
    InstanceCheck in Awake.
    */
    private ClickCounter()
    {
    }

    private void Awake()
    {
        void InstanceCheck()
        {
            // If no instances were previously registered...
            if (instance == null)
            {
                /*
                ...register this instance and don't destroy the gameObject it's attached to
                on load.
                */
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (instance != this)
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
                totalClicks++;                
            }

            Increment();
        }
    }
}
