using UnityEngine;
using FairyGUI;

public class JoystickMain : MonoBehaviour
{
	GComponent _mainView;
	GTextField _text;
	JoystickModule _joystick;
    Animator _playerAnimator;

	void Start()
	{
		Application.targetFrameRate = 60;
		Stage.inst.onKeyDown.Add(OnKeyDown);

		_mainView = this.GetComponent<UIPanel>().ui;

		_text = _mainView.GetChild("n9").asTextField;

		_joystick = new JoystickModule(_mainView);
		_joystick.onMove.Add(__joystickMove);
		_joystick.onEnd.Add(__joystickEnd);


        _playerAnimator= GameObject.Find("testmodel").GetComponent<Animator>();

    }

	void __joystickMove(EventContext context)
	{
		float degree = (float)context.data;
		_text.text = "" + degree;
        //Debug.Log(degree);
        _playerAnimator.SetFloat("degree", degree);
        _playerAnimator.SetBool("is_move", true);


    }

	void __joystickEnd()
	{
		_text.text = "";


        _playerAnimator.SetBool("is_move", false);
    }

	void OnKeyDown(EventContext context)
	{
		if (context.inputEvent.keyCode == KeyCode.Escape)
		{
			Application.Quit();
		}
	}
}