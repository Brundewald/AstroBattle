using System;
using Assets.Scripts.Interface;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class UserInputVertical:IUserInputProxy
    {
        public event Action<float> OnAxisChange = delegate(float f) {  };

        public void GetAxis()
        {
            OnAxisChange.Invoke(Input.GetAxis(AxisManager.Vertical));
        }
    }
}