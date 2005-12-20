// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public enum CorDebugMappingResult : int
	{
		
		MAPPING_PROLOG = 1,
		
		MAPPING_EPILOG = 2,
		
		MAPPING_NO_INFO = 4,
		
		MAPPING_UNMAPPED_ADDRESS = 8,
		
		MAPPING_EXACT = 16,
		
		MAPPING_APPROXIMATE = 32,
	}
}
