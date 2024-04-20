using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrazyChaosSpring2024
{
    public class MouseDrag : MonoBehaviour
    {
        public float zDistance = 10;
        public Camera maincamera;

        private void Awake(){
            this.enabled = false;
            maincamera = Camera.main;
        }

        private void OnEnable(){
            // get the distance between the object and the camera
            zDistance = Vector3.Distance(maincamera.transform.position, transform.position);
        }

        private void Update(){
            //after dragging the object, turn off this script (stop movment)
            if(Input.GetMouseButtonUp(0)){
                this.enabled = false;
            }

            // get the mouse/ object target position
            Vector3 mousePos = Input.mousePosition;
            Vector3 dragPos = maincamera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, zDistance));

            // set the object to the new position
            transform.position = dragPos;
            
        }
    }
}
