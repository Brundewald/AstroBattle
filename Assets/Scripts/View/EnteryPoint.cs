using Assets.Scripts.Controller;
using Assets.Scripts.View;
using UnityEngine;

public class EnteryPoint : MonoBehaviour
{
    [SerializeField] private ViewReferenceHolder _view;
    [SerializeField] private ModelReferenceHolder _model;

    private Controllers _controllers;
    
    private void Start()
    {
        _controllers = new Controllers();
        new GameInitialization(_controllers, _view, _model);
        _controllers.Initialize();
    }

    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _controllers.Execute(deltaTime);
    }

    private void FixedUpdate()
    {
        var lateDeltaTime = Time.fixedDeltaTime;
        _controllers.LateExecute(lateDeltaTime);
    }

    private void OnDestroy()
    {
        _controllers.Cleanup();
    }
}
