using Assets.Scripts.Model;
using UnityEngine;

namespace Assets.Scripts.View
{
    
    public class ModelReferenceHolder
    {
        [SerializeField] private PlayerModel _playerModel;
        [SerializeField] private EnemyModel _enemyModel;

        public PlayerModel _PlayerModel => _playerModel;
        public EnemyModel _EnemyModel => _enemyModel;
    }
}