// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public enum CorDebugInternalFrameType : int
	{
		
		STUBFRAME_NONE = 0,
		
		STUBFRAME_M2U = 1,
		
		STUBFRAME_U2M = 2,
		
		STUBFRAME_APPDOMAIN_TRANSITION = 3,
		
		STUBFRAME_LIGHTWEIGHT_FUNCTION = 4,
		
		STUBFRAME_FUNC_EVAL = 5,
		
		STUBFRAME_INTERNALCALL = 6,
	}
}
