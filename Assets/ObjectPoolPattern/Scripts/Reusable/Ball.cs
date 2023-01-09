using UnityEngine;
// Using for IObjectPool<T0>, a built-in pool interface.
using UnityEngine.Pool;

public class Ball : MonoBehaviour
{
    // Stats.
    private float _spd = 20f;
    private float _duration = 2.5f;
    private float _timeLeft;
    private float _boundariesX = 9.8f;

    // Pool Reference.
    private IObjectPool<Ball> _ballPool;

    private void OnEnable()
    {
        if (_spd < 0)
        {
            _spd *= -1;
        }

        _timeLeft = _duration;
    }

    private void Update()
    {
        void MovementHandler()
        {
            transform.position += new Vector3(_spd, 0, 0) * Time.deltaTime;

            if (transform.position.x < -_boundariesX)
            {
                transform.position = new Vector2(-_boundariesX, transform.position.y);
                _spd *= -1;
            }
            else if (transform.position.x > _boundariesX)
            {
                transform.position = new Vector2(_boundariesX, transform.position.y);
                _spd *= -1;
            }
        }

        void LifeCycleHandler()
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;
                if (_timeLeft <= 0)
                {
                    _ballPool.Release(this);
                }
            }
        }

        MovementHandler();
        LifeCycleHandler();
    }

    /*
    Sets the reference of the _ballPool from this class. This makes it possible for this
    instance to manipulate the pool it is part of.
    */
    public void SetPool(IObjectPool<Ball> pool)
    {
        _ballPool = pool;
    }
}
