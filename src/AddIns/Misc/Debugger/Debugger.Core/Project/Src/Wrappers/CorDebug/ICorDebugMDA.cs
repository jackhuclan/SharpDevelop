// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public class ICorDebugMDA
	{
		
		private Debugger.Interop.CorDebug.ICorDebugMDA wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugMDA WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugMDA(Debugger.Interop.CorDebug.ICorDebugMDA wrappedObject)
		{
			this.wrappedObject = wrappedObject;
		}
		
		public static ICorDebugMDA Wrap(Debugger.Interop.CorDebug.ICorDebugMDA objectToWrap)
		{
			return new ICorDebugMDA(objectToWrap);
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
		
		public static bool operator ==(ICorDebugMDA o1, ICorDebugMDA o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugMDA o1, ICorDebugMDA o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugMDA casted = o as ICorDebugMDA;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void GetName(uint cchName, out uint pcchName, System.IntPtr szName)
		{
			this.WrappedObject.GetName(cchName, out pcchName, szName);
		}
		
		public void GetDescription(uint cchName, out uint pcchName, System.IntPtr szName)
		{
			this.WrappedObject.GetDescription(cchName, out pcchName, szName);
		}
		
		public void GetXML(uint cchName, out uint pcchName, System.IntPtr szName)
		{
			this.WrappedObject.GetXML(cchName, out pcchName, szName);
		}
		
		public void GetFlags(ref CorDebugMDAFlags pFlags)
		{
			Debugger.Interop.CorDebug.CorDebugMDAFlags ref_pFlags = ((Debugger.Interop.CorDebug.CorDebugMDAFlags)(pFlags));
			this.WrappedObject.GetFlags(ref ref_pFlags);
			pFlags = ((CorDebugMDAFlags)(ref_pFlags));
		}
		
		public void GetOSThreadId(out uint pOsTid)
		{
			this.WrappedObject.GetOSThreadId(out pOsTid);
		}
	}
}
