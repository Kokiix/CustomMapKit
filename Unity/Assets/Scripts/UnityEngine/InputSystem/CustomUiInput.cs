using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	public class CustomUiInput : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		public struct PlayerActions
		{
			private CustomUiInput m_Wrapper;

			public InputAction Move => null;

			public InputAction Look => null;

			public InputAction Fire => null;

			public bool enabled => false;

			public PlayerActions(CustomUiInput wrapper)
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
			private CustomUiInput m_Wrapper;

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

			public UIActions(CustomUiInput wrapper)
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

			void OnLook(InputAction.CallbackContext context);

			void OnFire(InputAction.CallbackContext context);
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

		private readonly InputAction m_Player_Look;

		private readonly InputAction m_Player_Fire;

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
}
