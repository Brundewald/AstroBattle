using System;

namespace Assets.Scripts.Interface
{
    public interface IUserInputProxy
    {
        event Action<float> OnAxisChange;
        void GetAxis();
    }
}