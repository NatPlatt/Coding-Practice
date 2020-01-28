using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimBehavior : StateMachineBehaviour
{

    public UnityEvent stateEnterEvent;
  
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stateEnterEvent.Invoke();
    }

    
    
}
