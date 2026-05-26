using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct PlayerActions
	{
		private PlayerControls m_Wrapper;

		public InputAction Move => null;

		public InputAction LeftClick => null;

		public InputAction RightClick => null;

		public InputAction FireHold => null;

		public InputAction Jump => null;

		public InputAction MoveUp => null;

		public InputAction Run => null;

		public InputAction MouseX => null;

		public InputAction MouseY => null;

		public InputAction Zoom => null;

		public InputAction Crouch => null;

		public InputAction Interact => null;

		public InputAction Drop => null;

		public InputAction Reload => null;

		public InputAction LeanRight => null;

		public InputAction LeanLeft => null;

		public InputAction ChangeWeapon => null;

		public InputAction VoiceChat => null;

		public InputAction Any => null;

		public InputAction AnyGamepad => null;

		public bool enabled => false;

		public PlayerActions(PlayerControls wrapper)
		{
			m_Wrapper = null;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(PlayerActions set)
		{
			return null;
		}

		public void SetCallbacks(IPlayerActions instance)
		{
		}
	}

	public struct UIActions
	{
		private PlayerControls m_Wrapper;

		public InputAction Navigate => null;

		public InputAction Submit => null;

		public InputAction Cancel => null;

		public InputAction Point => null;

		public InputAction Click => null;

		public InputAction ScrollWheel => null;

		public InputAction MiddleClick => null;

		public InputAction RightClick => null;

		public InputAction TrackedDevicePosition => null;

		public InputAction TrackedDeviceOrientation => null;

		public bool enabled => false;

		public UIActions(PlayerControls wrapper)
		{
			m_Wrapper = null;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(UIActions set)
		{
			return null;
		}

		public void SetCallbacks(IUIActions instance)
		{
		}
	}

	public interface IPlayerActions
	{
		void OnMove(InputAction.CallbackContext context);

		void OnLeftClick(InputAction.CallbackContext context);

		void OnRightClick(InputAction.CallbackContext context);

		void OnFireHold(InputAction.CallbackContext context);

		void OnJump(InputAction.CallbackContext context);

		void OnMoveUp(InputAction.CallbackContext context);

		void OnRun(InputAction.CallbackContext context);

		void OnMouseX(InputAction.CallbackContext context);

		void OnMouseY(InputAction.CallbackContext context);

		void OnZoom(InputAction.CallbackContext context);

		void OnCrouch(InputAction.CallbackContext context);

		void OnInteract(InputAction.CallbackContext context);

		void OnDrop(InputAction.CallbackContext context);

		void OnReload(InputAction.CallbackContext context);

		void OnLeanRight(InputAction.CallbackContext context);

		void OnLeanLeft(InputAction.CallbackContext context);

		void OnChangeWeapon(InputAction.CallbackContext context);

		void OnVoiceChat(InputAction.CallbackContext context);

		void OnAny(InputAction.CallbackContext context);

		void OnAnyGamepad(InputAction.CallbackContext context);
	}

	public interface IUIActions
	{
		void OnNavigate(InputAction.CallbackContext context);

		void OnSubmit(InputAction.CallbackContext context);

		void OnCancel(InputAction.CallbackContext context);

		void OnPoint(InputAction.CallbackContext context);

		void OnClick(InputAction.CallbackContext context);

		void OnScrollWheel(InputAction.CallbackContext context);

		void OnMiddleClick(InputAction.CallbackContext context);

		void OnRightClick(InputAction.CallbackContext context);

		void OnTrackedDevicePosition(InputAction.CallbackContext context);

		void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
	}

	private readonly InputActionMap m_Player;

	private IPlayerActions m_PlayerActionsCallbackInterface;

	private readonly InputAction m_Player_Move;

	private readonly InputAction m_Player_LeftClick;

	private readonly InputAction m_Player_RightClick;

	private readonly InputAction m_Player_FireHold;

	private readonly InputAction m_Player_Jump;

	private readonly InputAction m_Player_MoveUp;

	private readonly InputAction m_Player_Run;

	private readonly InputAction m_Player_MouseX;

	private readonly InputAction m_Player_MouseY;

	private readonly InputAction m_Player_Zoom;

	private readonly InputAction m_Player_Crouch;

	private readonly InputAction m_Player_Interact;

	private readonly InputAction m_Player_Drop;

	private readonly InputAction m_Player_Reload;

	private readonly InputAction m_Player_LeanRight;

	private readonly InputAction m_Player_LeanLeft;

	private readonly InputAction m_Player_ChangeWeapon;

	private readonly InputAction m_Player_VoiceChat;

	private readonly InputAction m_Player_Any;

	private readonly InputAction m_Player_AnyGamepad;

	private readonly InputActionMap m_UI;

	private IUIActions m_UIActionsCallbackInterface;

	private readonly InputAction m_UI_Navigate;

	private readonly InputAction m_UI_Submit;

	private readonly InputAction m_UI_Cancel;

	private readonly InputAction m_UI_Point;

	private readonly InputAction m_UI_Click;

	private readonly InputAction m_UI_ScrollWheel;

	private readonly InputAction m_UI_MiddleClick;

	private readonly InputAction m_UI_RightClick;

	private readonly InputAction m_UI_TrackedDevicePosition;

	private readonly InputAction m_UI_TrackedDeviceOrientation;

	private int m_KeyboardMouseSchemeIndex;

	private int m_GamepadSchemeIndex;

	private int m_TouchSchemeIndex;

	private int m_JoystickSchemeIndex;

	private int m_XRSchemeIndex;

	public InputActionAsset asset { get; }

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

	public IEnumerable<InputBinding> bindings => null;

	public PlayerActions Player => default(PlayerActions);

	public UIActions UI => default(UIActions);

	public InputControlScheme KeyboardMouseScheme => default(InputControlScheme);

	public InputControlScheme GamepadScheme => default(InputControlScheme);

	public InputControlScheme TouchScheme => default(InputControlScheme);

	public InputControlScheme JoystickScheme => default(InputControlScheme);

	public InputControlScheme XRScheme => default(InputControlScheme);

	public void Dispose()
	{
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		action = null;
		return 0;
	}
}
