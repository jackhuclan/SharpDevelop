// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public class ICorDebugAppDomain2
	{
		
		private Debugger.Interop.CorDebug.ICorDebugAppDomain2 wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugAppDomain2 WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugAppDomain2(Debugger.Interop.CorDebug.ICorDebugAppDomain2 wrappedObject)
		{
			this.wrappedObject = wrappedObject;
		}
		
		public static ICorDebugAppDomain2 Wrap(Debugger.Interop.CorDebug.ICorDebugAppDomain2 objectToWrap)
		{
			return new ICorDebugAppDomain2(objectToWrap);
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
		
		public static bool operator ==(ICorDebugAppDomain2 o1, ICorDebugAppDomain2 o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugAppDomain2 o1, ICorDebugAppDomain2 o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugAppDomain2 casted = o as ICorDebugAppDomain2;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void GetArrayOrPointerType(uint elementType, uint nRank, ICorDebugType pTypeArg, out ICorDebugType ppType)
		{
			Debugger.Interop.CorDebug.ICorDebugType out_ppType;
			this.WrappedObject.GetArrayOrPointerType(elementType, nRank, pTypeArg.WrappedObject, out out_ppType);
			ppType = ICorDebugType.Wrap(out_ppType);
		}
		
		public void GetFunctionPointerType(uint nTypeArgs, ref ICorDebugType ppTypeArgs, out ICorDebugType ppType)
		{
			Debugger.Interop.CorDebug.ICorDebugType ref_ppTypeArgs = ppTypeArgs.WrappedObject;
			Debugger.Interop.CorDebug.ICorDebugType out_ppType;
			this.WrappedObject.GetFunctionPointerType(nTypeArgs, ref ref_ppTypeArgs, out out_ppType);
			ppTypeArgs = ICorDebugType.Wrap(ref_ppTypeArgs);
			ppType = ICorDebugType.Wrap(out_ppType);
		}
	}
}
