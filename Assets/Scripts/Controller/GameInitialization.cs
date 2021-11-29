using Assets.Scripts.View;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    internal sealed class GameInitialization
    {        
        public GameInitialization(Controllers controllers, ViewReferenceHolder view, ModelReferenceHolder model)
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var cameraController = new CameraController(camera, view.PlayerView);
            var scoreHandler = new ScoreHandler(view.ScoreView, collisionHandler);
            var endGameHandler = new EndGameHandler(collisionHandler, scoreHandler);
            var dropScoreHandler = new DropScoreHandler(scoreHandler, view.CharacterControlView);
            var characterDeathHandler = new CharacterDeathHandler(collisionHandler, dropScoreHandler, view.PlayerView);
            
            controllers.Add(cameraController);
            controllers.Add(inputInitialization);
            controllers.Add(scoreHandler);
            controllers.Add(endGameHandler);
            controllers.Add(dropScoreHandler);
            controllers.Add(characterDeathHandler);
            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new EnemyHandler(view.EnemyView, view.PlayerView, enemyAIHandler, models.LevelModel.EnemyBasePoint, animationHandler, objects.LevelObject));
        }
    }
    }
}