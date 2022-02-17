using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Idle()
    {
        Animator.SetInteger("Animation", 1);
    }

    public void Walk()
    {
        Animator.SetInteger("Animation", 2);
    }

    public void StandUp()
    {
        Animator.SetInteger("Animation", 3);
    }

    public void Win()
    {
        Animator.SetInteger("Animation", 4);
    }

    public void Jump()
    {
        Animator.SetInteger("Animation", 5);
    }

    public void FallDown()
    {
        Animator.SetInteger("Animation", 6);
    }

    public void Defeat()
    {
        Animator.SetInteger("Animation", 7);
    }

    public void LookAround()
    {
        Animator.SetInteger("Animation", 8);
    }
}
