// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public class ICorDebugUnmanagedCallback
	{
		
		private Debugger.Interop.CorDebug.ICorDebugUnmanagedCallback wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugUnmanagedCallback WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugUnmanagedCallback(Debugger.Interop.CorDebug.ICorDebugUnmanagedCallback wrappedObject)
		{
			this.wrappedObject = wrappedObject;
		}
		
		public static ICorDebugUnmanagedCallback Wrap(Debugger.Interop.CorDebug.ICorDebugUnmanagedCallback objectToWrap)
		{
			return new ICorDebugUnmanagedCallback(objectToWrap);
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
		
		public static bool operator ==(ICorDebugUnmanagedCallback o1, ICorDebugUnmanagedCallback o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugUnmanagedCallback o1, ICorDebugUnmanagedCallback o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugUnmanagedCallback casted = o as ICorDebugUnmanagedCallback;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void DebugEvent(uint pDebugEvent, int fOutOfBand)
		{
			this.WrappedObject.DebugEvent(pDebugEvent, fOutOfBand);
		}
	}
}
