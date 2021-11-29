namespace Assets.Scripts.Interface
{
    public interface ILateExecute:IController
    {
        void LateExecute(float lateDeltaTime);
    }
}