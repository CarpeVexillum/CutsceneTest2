﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : StateMachineBehaviour {
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        animator.transform.parent.gameObject.transform.position = animator.transform.position;
    }
}
