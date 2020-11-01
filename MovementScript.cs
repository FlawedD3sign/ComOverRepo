using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    Animator animator;
    int IsWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("IsWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool(IsWalkingHash); //

        bool forwardPressed = Input.GetKey("w"); //If w is pressed, then forwardPressedis true
        if(!IsWalking && forwardPressed) //if "w" is pressed while "IsWalking" is false
        {
            animator.SetBool(IsWalkingHash, true);/// then "IsWalking" becomes true
        }

        if (IsWalking && !forwardPressed) /// if "w" is not being pressed while "IsWalking is true
        {
            animator.SetBool(IsWalkingHash, false);/// Then "IsWalking becomes False
        }
    }
}
