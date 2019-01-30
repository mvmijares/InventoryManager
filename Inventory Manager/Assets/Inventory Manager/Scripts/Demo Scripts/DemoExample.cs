using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DemoScripts {
    public class DemoExample : MonoBehaviour {

        public Item newItem;

        public float destructionTime;
        [SerializeField] private float currentDestructionTime;

        private void Awake() {
            IStackable stackable = newItem as IStackable;
            if(stackable != null) {
                stackable.stackCount = 1;
            }
        }
        private void Update() {
            if (newItem) {
                DestroyItem();
            }
        }
        void DestroyItem() {
            //Testing if the item implements the destructable interface.
            IDestructable destructable = newItem as IDestructable;

            currentDestructionTime += Time.deltaTime;

            if (destructable != null) {

                if (currentDestructionTime >= destructionTime) {
                    Destroy(newItem.gameObject);
                }
            }
        } 
    }
}
