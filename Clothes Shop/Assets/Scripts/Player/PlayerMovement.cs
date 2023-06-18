using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {

        [SerializeField] float walkingSpeed = 2f;
        [SerializeField] float runningSpeed;

        private float _currentSpeed;
        [SerializeField] Transform _playerTransform;

        [Header("Animation")]
        [SerializeField] PlayerAnimationHandler playerAnimation;
        [SerializeField] bool isWalking = false;
        [SerializeField] bool isRunning = false;

        private void Awake()
        {
            runningSpeed = walkingSpeed * 1.5f;
            _currentSpeed = walkingSpeed;
            playerAnimation = GetComponent<PlayerAnimationHandler>();
            _playerTransform = GameObject.FindGameObjectWithTag("PlayerGameObject").GetComponent<Transform>();
        }
        void Update()
        {
            CheckInputs();
            HandleMovement();
            UpdateAnimations();
        }

        private void HandleMovement()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + (_currentSpeed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + (-_currentSpeed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector2(transform.position.x + (-_currentSpeed * Time.deltaTime), transform.position.y);

                if (_playerTransform.localScale.x > 0)
                {
                    _playerTransform.DOScaleX(-0.2f, 0.3f);
                }

            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector2(transform.position.x + (_currentSpeed * Time.deltaTime), transform.position.y);
                if (_playerTransform.localScale.x < 0)
                {
                    _playerTransform.DOScaleX(0.2f, 0.3f);
                }
            }
        }
        private void CheckInputs()
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRunning = true;
                _currentSpeed = runningSpeed;
            }
            else
            {
                isRunning = false;
                _currentSpeed = walkingSpeed;
            }

            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                isWalking = true;
            }
            else
            {
                isWalking = false;
            }




        }

        private void UpdateAnimations()
        {
            playerAnimation.SetRun(isRunning);
            playerAnimation.SetWalk(isWalking);

        }
    }

}
