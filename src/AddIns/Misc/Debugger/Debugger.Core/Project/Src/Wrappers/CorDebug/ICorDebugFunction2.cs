// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public class ICorDebugFunction2
	{
		
		private Debugger.Interop.CorDebug.ICorDebugFunction2 wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugFunction2 WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugFunction2(Debugger.Interop.CorDebug.ICorDebugFunction2 wrappedObject)
		{
			this.wrappedObject = wrappedObject;
		}
		
		public static ICorDebugFunction2 Wrap(Debugger.Interop.CorDebug.ICorDebugFunction2 objectToWrap)
		{
			return new ICorDebugFunction2(objectToWrap);
		}
		
		public bool Is<T>() where T: class
		{
			try {
				CastTo<T>();
				return true;
			} catch {
				return false;
			}
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugFunction2 o1, ICorDebugFunction2 o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugFunction2 o1, ICorDebugFunction2 o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugFunction2 casted = o as ICorDebugFunction2;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void SetJMCStatus(int bIsJustMyCode)
		{
			this.WrappedObject.SetJMCStatus(bIsJustMyCode);
		}
		
		public void GetJMCStatus(out int pbIsJustMyCode)
		{
			this.WrappedObject.GetJMCStatus(out pbIsJustMyCode);
		}
		
		public void EnumerateNativeCode(out ICorDebugCodeEnum ppCodeEnum)
		{
			Debugger.Interop.CorDebug.ICorDebugCodeEnum out_ppCodeEnum;
			this.WrappedObject.EnumerateNativeCode(out out_ppCodeEnum);
			ppCodeEnum = ICorDebugCodeEnum.Wrap(out_ppCodeEnum);
		}
		
		public void GetVersionNumber(out uint pnVersion)
		{
			this.WrappedObject.GetVersionNumber(out pnVersion);
		}
	}
}
