using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VamVam.Scripts
{
    public class PlayerFallDamage : MonoBehaviour
    {
        [SerializeField] private float _distanceToDie;
        
        private PlayerControllerBase PCBase;
        
        private bool _death;

        private void Awake() {
            
            PCBase = GetComponent<PlayerControllerBase>();
        }

        private void Update() {
            
            if (PCBase.GetPlayerRB2D().velocity.y <= -10f) {

                _death = true;
            }
        }

        private void OnCollisionEnter2D(Collision2D other) {
            
            if (other.gameObject.CompareTag("Player") && _death) {

                Destroy(other.gameObject);
            }
        }
    }
}
