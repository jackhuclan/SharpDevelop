// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public class ICorDebugManagedCallback
	{
		
		private Debugger.Interop.CorDebug.ICorDebugManagedCallback wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugManagedCallback WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugManagedCallback(Debugger.Interop.CorDebug.ICorDebugManagedCallback wrappedObject)
		{
			this.wrappedObject = wrappedObject;
		}
		
		public static ICorDebugManagedCallback Wrap(Debugger.Interop.CorDebug.ICorDebugManagedCallback objectToWrap)
		{
			return new ICorDebugManagedCallback(objectToWrap);
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
		
		public static bool operator ==(ICorDebugManagedCallback o1, ICorDebugManagedCallback o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugManagedCallback o1, ICorDebugManagedCallback o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugManagedCallback casted = o as ICorDebugManagedCallback;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void Breakpoint(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pBreakpoint)
		{
			this.WrappedObject.Breakpoint(pAppDomain, pThread, pBreakpoint);
		}
		
		public void StepComplete(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pStepper, CorDebugStepReason reason)
		{
			this.WrappedObject.StepComplete(pAppDomain, pThread, pStepper, ((Debugger.Interop.CorDebug.CorDebugStepReason)(reason)));
		}
		
		public void Break(System.IntPtr pAppDomain, System.IntPtr thread)
		{
			this.WrappedObject.Break(pAppDomain, thread);
		}
		
		public void Exception(System.IntPtr pAppDomain, System.IntPtr pThread, int unhandled)
		{
			this.WrappedObject.Exception(pAppDomain, pThread, unhandled);
		}
		
		public void EvalComplete(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pEval)
		{
			this.WrappedObject.EvalComplete(pAppDomain, pThread, pEval);
		}
		
		public void EvalException(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pEval)
		{
			this.WrappedObject.EvalException(pAppDomain, pThread, pEval);
		}
		
		public void CreateProcess(System.IntPtr pProcess)
		{
			this.WrappedObject.CreateProcess(pProcess);
		}
		
		public void ExitProcess(System.IntPtr pProcess)
		{
			this.WrappedObject.ExitProcess(pProcess);
		}
		
		public void CreateThread(System.IntPtr pAppDomain, System.IntPtr thread)
		{
			this.WrappedObject.CreateThread(pAppDomain, thread);
		}
		
		public void ExitThread(System.IntPtr pAppDomain, System.IntPtr thread)
		{
			this.WrappedObject.ExitThread(pAppDomain, thread);
		}
		
		public void LoadModule(System.IntPtr pAppDomain, System.IntPtr pModule)
		{
			this.WrappedObject.LoadModule(pAppDomain, pModule);
		}
		
		public void UnloadModule(System.IntPtr pAppDomain, System.IntPtr pModule)
		{
			this.WrappedObject.UnloadModule(pAppDomain, pModule);
		}
		
		public void LoadClass(System.IntPtr pAppDomain, System.IntPtr c)
		{
			this.WrappedObject.LoadClass(pAppDomain, c);
		}
		
		public void UnloadClass(System.IntPtr pAppDomain, System.IntPtr c)
		{
			this.WrappedObject.UnloadClass(pAppDomain, c);
		}
		
		public void DebuggerError(System.IntPtr pProcess, int errorHR, uint errorCode)
		{
			this.WrappedObject.DebuggerError(pProcess, errorHR, errorCode);
		}
		
		public void LogMessage(System.IntPtr pAppDomain, System.IntPtr pThread, int lLevel, System.IntPtr pLogSwitchName, System.IntPtr pMessage)
		{
			this.WrappedObject.LogMessage(pAppDomain, pThread, lLevel, pLogSwitchName, pMessage);
		}
		
		public void LogSwitch(System.IntPtr pAppDomain, System.IntPtr pThread, int lLevel, uint ulReason, System.IntPtr pLogSwitchName, System.IntPtr pParentName)
		{
			this.WrappedObject.LogSwitch(pAppDomain, pThread, lLevel, ulReason, pLogSwitchName, pParentName);
		}
		
		public void CreateAppDomain(System.IntPtr pProcess, System.IntPtr pAppDomain)
		{
			this.WrappedObject.CreateAppDomain(pProcess, pAppDomain);
		}
		
		public void ExitAppDomain(System.IntPtr pProcess, System.IntPtr pAppDomain)
		{
			this.WrappedObject.ExitAppDomain(pProcess, pAppDomain);
		}
		
		public void LoadAssembly(System.IntPtr pAppDomain, System.IntPtr pAssembly)
		{
			this.WrappedObject.LoadAssembly(pAppDomain, pAssembly);
		}
		
		public void UnloadAssembly(System.IntPtr pAppDomain, System.IntPtr pAssembly)
		{
			this.WrappedObject.UnloadAssembly(pAppDomain, pAssembly);
		}
		
		public void ControlCTrap(System.IntPtr pProcess)
		{
			this.WrappedObject.ControlCTrap(pProcess);
		}
		
		public void NameChange(System.IntPtr pAppDomain, System.IntPtr pThread)
		{
			this.WrappedObject.NameChange(pAppDomain, pThread);
		}
		
		public void UpdateModuleSymbols(System.IntPtr pAppDomain, System.IntPtr pModule, System.IntPtr pSymbolStream)
		{
			this.WrappedObject.UpdateModuleSymbols(pAppDomain, pModule, pSymbolStream);
		}
		
		public void EditAndContinueRemap(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pFunction, int fAccurate)
		{
			this.WrappedObject.EditAndContinueRemap(pAppDomain, pThread, pFunction, fAccurate);
		}
		
		public void BreakpointSetError(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pBreakpoint, uint dwError)
		{
			this.WrappedObject.BreakpointSetError(pAppDomain, pThread, pBreakpoint, dwError);
		}
	}
}
