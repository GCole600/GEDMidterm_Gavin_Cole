using Chapter.Command;
using UnityEngine;

namespace Singleton
{
    public class InputHandler : Singleton<InputHandler>
    {
        private PlayerController _playerController;
        private global::Command.Command _buttonA, _buttonD, _buttonW, _buttonS, _buttonSpace;
    
        void Start()
        {
            _playerController = FindObjectOfType<PlayerController>();

            _buttonW = new TurnUp(_playerController);
            _buttonA = new TurnLeft(_playerController);
            _buttonD = new TurnRight(_playerController);
            _buttonS = new TurnDown(_playerController);
            _buttonSpace = new Shoot(_playerController);
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.A)) 
                _buttonA.Execute();
                
            if (Input.GetKeyUp(KeyCode.D)) 
                _buttonD.Execute();  
                
            if (Input.GetKeyUp(KeyCode.W)) 
                _buttonW.Execute();  
        
            if (Input.GetKeyUp(KeyCode.S)) 
                _buttonS.Execute();  
        
            if (Input.GetKeyUp(KeyCode.Space)) 
                _buttonSpace.Execute();  
        }
    }
}