// <file>
//     <owner name="David Srbeck�" email="dsrbecky@post.cz"/>
// </file>

namespace DebuggerLibrary
{
	enum CorCallingConvention: uint
	{
	    IMAGE_CEE_CS_CALLCONV_DEFAULT   = 0x0,  
	
	    IMAGE_CEE_CS_CALLCONV_VARARG    = 0x5,  
	    IMAGE_CEE_CS_CALLCONV_FIELD     = 0x6,  
	    IMAGE_CEE_CS_CALLCONV_LOCAL_SIG = 0x7,
	    IMAGE_CEE_CS_CALLCONV_PROPERTY  = 0x8,
	    IMAGE_CEE_CS_CALLCONV_UNMGD     = 0x9,
	    IMAGE_CEE_CS_CALLCONV_MAX       = 0x10,  // first invalid calling convention    
	
	
	        // The high bits of the calling convention convey additional info   
	    IMAGE_CEE_CS_CALLCONV_MASK      = 0x0f,  // Calling convention is bottom 4 bits 
	    IMAGE_CEE_CS_CALLCONV_HASTHIS   = 0x20,  // Top bit indicates a 'this' parameter    
	    IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS = 0x40,  // This parameter is explicitly in the signature
	}
}
