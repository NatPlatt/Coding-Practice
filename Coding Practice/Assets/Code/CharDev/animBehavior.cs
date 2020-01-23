using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animBehavior : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log(stateInfo);
    }
}
