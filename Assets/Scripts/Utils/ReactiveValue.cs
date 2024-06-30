using System;

namespace GameJamEntry.Scripts.Utils {
	public class ReactiveValue<T> {
		public T Value {
			get => _value;
			set {
				_value = value;
				OnValueChanged?.Invoke(value);
			}
		}

		T _value;

		public event Action<T> OnValueChanged;
	}
}