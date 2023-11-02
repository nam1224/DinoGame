using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour
{
    [SerializeField] [Range(0.1f, 20f)] float speed = 3f;

    [SerializeField] float posValue;

    Vector2 startPos;
    float newPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        newPos = Mathf.Repeat(Time.time * (speed+adjustSpeed(speed)), posValue);
        transform.position = startPos + Vector2.right * newPos;
    }

    public float adjustSpeed(float _speed)
    {
        float second = 10f;
        float w = 0.5f;

        _speed = Time.time / second * w;
        //Debug.Log(_speed);
        return _speed;
    }

}
