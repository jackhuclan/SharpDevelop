// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public enum CorDebugRegister : int
	{
		
		REGISTER_AMD64_RIP = 0,
		
		REGISTER_X86_EIP = 0,
		
		REGISTER_INSTRUCTION_POINTER = 0,
		
		REGISTER_AMD64_RSP = 1,
		
		REGISTER_STACK_POINTER = 1,
		
		REGISTER_X86_ESP = 1,
		
		REGISTER_IA64_BSP = 2,
		
		REGISTER_AMD64_RBP = 2,
		
		REGISTER_X86_EBP = 2,
		
		REGISTER_FRAME_POINTER = 2,
		
		REGISTER_X86_EAX = 3,
		
		REGISTER_IA64_R0 = 3,
		
		REGISTER_AMD64_RAX = 3,
		
		REGISTER_X86_ECX = 4,
		
		REGISTER_AMD64_RCX = 4,
		
		REGISTER_AMD64_RDX = 5,
		
		REGISTER_X86_EDX = 5,
		
		REGISTER_X86_EBX = 6,
		
		REGISTER_AMD64_RBX = 6,
		
		REGISTER_AMD64_RSI = 7,
		
		REGISTER_X86_ESI = 7,
		
		REGISTER_X86_EDI = 8,
		
		REGISTER_AMD64_RDI = 8,
		
		REGISTER_AMD64_R8 = 9,
		
		REGISTER_X86_FPSTACK_0 = 9,
		
		REGISTER_AMD64_R9 = 10,
		
		REGISTER_X86_FPSTACK_1 = 10,
		
		REGISTER_AMD64_R10 = 11,
		
		REGISTER_X86_FPSTACK_2 = 11,
		
		REGISTER_AMD64_R11 = 12,
		
		REGISTER_X86_FPSTACK_3 = 12,
		
		REGISTER_AMD64_R12 = 13,
		
		REGISTER_X86_FPSTACK_4 = 13,
		
		REGISTER_AMD64_R13 = 14,
		
		REGISTER_X86_FPSTACK_5 = 14,
		
		REGISTER_AMD64_R14 = 15,
		
		REGISTER_X86_FPSTACK_6 = 15,
		
		REGISTER_AMD64_R15 = 16,
		
		REGISTER_X86_FPSTACK_7 = 16,
		
		REGISTER_AMD64_XMM0 = 17,
		
		REGISTER_AMD64_XMM1 = 18,
		
		REGISTER_AMD64_XMM2 = 19,
		
		REGISTER_AMD64_XMM3 = 20,
		
		REGISTER_AMD64_XMM4 = 21,
		
		REGISTER_AMD64_XMM5 = 22,
		
		REGISTER_AMD64_XMM6 = 23,
		
		REGISTER_AMD64_XMM7 = 24,
		
		REGISTER_AMD64_XMM8 = 25,
		
		REGISTER_AMD64_XMM9 = 26,
		
		REGISTER_AMD64_XMM10 = 27,
		
		REGISTER_AMD64_XMM11 = 28,
		
		REGISTER_AMD64_XMM12 = 29,
		
		REGISTER_AMD64_XMM13 = 30,
		
		REGISTER_AMD64_XMM14 = 31,
		
		REGISTER_AMD64_XMM15 = 32,
		
		REGISTER_IA64_F0 = 131,
	}
}
