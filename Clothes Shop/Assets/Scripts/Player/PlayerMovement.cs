using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        
        [SerializeField] float speed = 2f;
    
        void Update()
        {
            CheckInputs();
        }

        private void CheckInputs()
        {
            if (Input.GetKey(KeyCode.W))
                transform.position = new Vector2(transform.position.x, transform.position.y + (speed * Time.deltaTime));
            if (Input.GetKey(KeyCode.S))
                transform.position = new Vector2(transform.position.x, transform.position.y + (-speed * Time.deltaTime));
            if (Input.GetKey(KeyCode.A))
                transform.position = new Vector2(transform.position.x + (-speed * Time.deltaTime), transform.position.y);
            if (Input.GetKey(KeyCode.D))
                transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        }
    }

}
