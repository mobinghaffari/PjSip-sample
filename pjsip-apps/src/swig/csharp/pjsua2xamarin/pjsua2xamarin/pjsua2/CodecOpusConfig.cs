//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2xamarin.pjsua2 {

public class CodecOpusConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CodecOpusConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CodecOpusConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CodecOpusConfig() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_CodecOpusConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint sample_rate {
    set {
      pjsua2PINVOKE.CodecOpusConfig_sample_rate_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_sample_rate_get(swigCPtr);
      return ret;
    } 
  }

  public uint channel_cnt {
    set {
      pjsua2PINVOKE.CodecOpusConfig_channel_cnt_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_channel_cnt_get(swigCPtr);
      return ret;
    } 
  }

  public uint frm_ptime {
    set {
      pjsua2PINVOKE.CodecOpusConfig_frm_ptime_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_frm_ptime_get(swigCPtr);
      return ret;
    } 
  }

  public uint frm_ptime_denum {
    set {
      pjsua2PINVOKE.CodecOpusConfig_frm_ptime_denum_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_frm_ptime_denum_get(swigCPtr);
      return ret;
    } 
  }

  public uint bit_rate {
    set {
      pjsua2PINVOKE.CodecOpusConfig_bit_rate_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_bit_rate_get(swigCPtr);
      return ret;
    } 
  }

  public uint packet_loss {
    set {
      pjsua2PINVOKE.CodecOpusConfig_packet_loss_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_packet_loss_get(swigCPtr);
      return ret;
    } 
  }

  public uint complexity {
    set {
      pjsua2PINVOKE.CodecOpusConfig_complexity_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CodecOpusConfig_complexity_get(swigCPtr);
      return ret;
    } 
  }

  public bool cbr {
    set {
      pjsua2PINVOKE.CodecOpusConfig_cbr_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.CodecOpusConfig_cbr_get(swigCPtr);
      return ret;
    } 
  }

  public CodecOpusConfig() : this(pjsua2PINVOKE.new_CodecOpusConfig(), true) {
  }

}

}
