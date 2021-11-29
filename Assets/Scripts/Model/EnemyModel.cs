using UnityEngine;

namespace Assets.Scripts.Model
{
    public class EnemyModel
    {
        [SerializeField] private float _speed;

        public float Speed => _speed;
    }
}