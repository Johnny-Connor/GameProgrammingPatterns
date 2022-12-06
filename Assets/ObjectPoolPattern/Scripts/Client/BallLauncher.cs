using UnityEngine;
/*
Using for IObjectPool<T0> (built-in pool interface) and ObjectPool<T0> (one of the built-in
pool classes available in this library).
*/
using UnityEngine.Pool;

public class BallLauncher : MonoBehaviour
{
    [SerializeField] Ball _ballPrefab;
    private IObjectPool<Ball> _ballPool;

    private void Awake()
    {
        Ball OnCreateBallInPool()
        {
            Ball ball = Instantiate(_ballPrefab);
            ball.SetPool(_ballPool);
            return ball;
        }

        void OnBallPoolGet(Ball ball)
        {
            ball.gameObject.SetActive(true);
            ball.transform.position = transform.position;
        }

        void OnBallPoolRelease(Ball ball)
        {
            ball.gameObject.SetActive(false);
        }

        void OnDestroyBallFromPool(Ball ball)
        {
            Destroy(ball.gameObject);
        }

        /*
        The constructor of the ObjectPool class has several parameters, with most of them
        being delegates which are called when certain ObjectPool<T0> methods are used.
        The list of these parameters, alongside their respective explanations, is available
        at:
        https://docs.unity3d.com/ScriptReference/Pool.ObjectPool_1-ctor.html
        */
        _ballPool = new ObjectPool<Ball>(
            /*
            createFunc: Called when ObjectPool<T0>.Get is used when the pool is empty.
            */
            OnCreateBallInPool, 
            // actionOnGet: Called when ObjectPool<T0>.Get is used.
            OnBallPoolGet, 
            // actionOnRelease: Called when ObjectPool<T0>.Release is used.
            OnBallPoolRelease,
            /*
            actionOnDestroy: Called for each element stored in the pool when Clear (from
            IObjectPool<T0>) or Dispose (from certain concrete pools) is used or when an
            element could not be returned to the pool due to the pool reaching its maximum
            size.
            */
            OnDestroyBallFromPool
        );
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // M1
        {
            _ballPool.Get();
        }
    }
}
