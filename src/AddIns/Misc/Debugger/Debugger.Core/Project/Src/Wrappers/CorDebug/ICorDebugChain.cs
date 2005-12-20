// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public class ICorDebugChain
	{
		
		private Debugger.Interop.CorDebug.ICorDebugChain wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugChain WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugChain(Debugger.Interop.CorDebug.ICorDebugChain wrappedObject)
		{
			this.wrappedObject = wrappedObject;
		}
		
		public static ICorDebugChain Wrap(Debugger.Interop.CorDebug.ICorDebugChain objectToWrap)
		{
			return new ICorDebugChain(objectToWrap);
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
		
		public static bool operator ==(ICorDebugChain o1, ICorDebugChain o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugChain o1, ICorDebugChain o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugChain casted = o as ICorDebugChain;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void GetThread(out ICorDebugThread ppThread)
		{
			Debugger.Interop.CorDebug.ICorDebugThread out_ppThread;
			this.WrappedObject.GetThread(out out_ppThread);
			ppThread = ICorDebugThread.Wrap(out_ppThread);
		}
		
		public void GetStackRange(out ulong pStart, out ulong pEnd)
		{
			this.WrappedObject.GetStackRange(out pStart, out pEnd);
		}
		
		public void GetContext(out ICorDebugContext ppContext)
		{
			Debugger.Interop.CorDebug.ICorDebugContext out_ppContext;
			this.WrappedObject.GetContext(out out_ppContext);
			ppContext = ICorDebugContext.Wrap(out_ppContext);
		}
		
		public void GetCaller(out ICorDebugChain ppChain)
		{
			Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
			this.WrappedObject.GetCaller(out out_ppChain);
			ppChain = ICorDebugChain.Wrap(out_ppChain);
		}
		
		public void GetCallee(out ICorDebugChain ppChain)
		{
			Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
			this.WrappedObject.GetCallee(out out_ppChain);
			ppChain = ICorDebugChain.Wrap(out_ppChain);
		}
		
		public void GetPrevious(out ICorDebugChain ppChain)
		{
			Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
			this.WrappedObject.GetPrevious(out out_ppChain);
			ppChain = ICorDebugChain.Wrap(out_ppChain);
		}
		
		public void GetNext(out ICorDebugChain ppChain)
		{
			Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
			this.WrappedObject.GetNext(out out_ppChain);
			ppChain = ICorDebugChain.Wrap(out_ppChain);
		}
		
		public void IsManaged(out int pManaged)
		{
			this.WrappedObject.IsManaged(out pManaged);
		}
		
		public void EnumerateFrames(out ICorDebugFrameEnum ppFrames)
		{
			Debugger.Interop.CorDebug.ICorDebugFrameEnum out_ppFrames;
			this.WrappedObject.EnumerateFrames(out out_ppFrames);
			ppFrames = ICorDebugFrameEnum.Wrap(out_ppFrames);
		}
		
		public void GetActiveFrame(out ICorDebugFrame ppFrame)
		{
			Debugger.Interop.CorDebug.ICorDebugFrame out_ppFrame;
			this.WrappedObject.GetActiveFrame(out out_ppFrame);
			ppFrame = ICorDebugFrame.Wrap(out_ppFrame);
		}
		
		public void GetRegisterSet(out ICorDebugRegisterSet ppRegisters)
		{
			Debugger.Interop.CorDebug.ICorDebugRegisterSet out_ppRegisters;
			this.WrappedObject.GetRegisterSet(out out_ppRegisters);
			ppRegisters = ICorDebugRegisterSet.Wrap(out_ppRegisters);
		}
		
		public void GetReason(out CorDebugChainReason pReason)
		{
			Debugger.Interop.CorDebug.CorDebugChainReason out_pReason;
			this.WrappedObject.GetReason(out out_pReason);
			pReason = ((CorDebugChainReason)(out_pReason));
		}
	}
}
