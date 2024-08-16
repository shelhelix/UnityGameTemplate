using System;

namespace Com.Shelinc.Windows {
	public class NoParamsShowRequest<T> : IShowRequest {
		public Type WindowType => typeof(T);
	}
}