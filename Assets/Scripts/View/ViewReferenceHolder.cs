using UnityEngine;

namespace Assets.Scripts.View
{
    public class ViewReferenceHolder
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private EnemyView _enemyView;

        public PlayerView PlayerView => _playerView;
        public EnemyView EnemyView => _enemyView;
    }
}