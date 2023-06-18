using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerAnimationHandler : MonoBehaviour
    {
        [SerializeField] Animator animator;


        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }
        public void SetRun(bool b)
        {
            animator.SetBool("Run", b);

        }
        public void SetWalk(bool b)
        {
            animator.SetBool("Walk", b);
        }
    }
}
