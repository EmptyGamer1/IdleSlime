using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove : MonoBehaviour
{
    [SerializeField] private Transform _slime;
    [SerializeField] private float _speed;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private Animator _slimeAnimation;

    private void Start()
    {
        // StartCoroutine(StartMove());
        //SlimeAnimation();
    }

    private void Move()
    {
        _slime.Translate(_speed * Time.fixedDeltaTime * -transform.right);
    }

    private IEnumerator StartMove()
    {
        float time = _duration;
        while (time > 0)
        {
            time -= Time.fixedDeltaTime;
            Move();
            yield return null;
        }
        yield return new WaitForSeconds(_delay);

        StartCoroutine(StartMove());
    }

    //public void SlimeAnimation()
    //{
    //    _slimeAnimation.Play("Walk");
    //}
}
