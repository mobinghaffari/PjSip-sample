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

public class Endpoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Endpoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Endpoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Endpoint() {
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
          pjsua2PINVOKE.delete_Endpoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static Endpoint instance() {
    Endpoint ret = new Endpoint(pjsua2PINVOKE.Endpoint_instance(), false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Endpoint() : this(pjsua2PINVOKE.new_Endpoint(), true) {
    SwigDirectorConnect();
  }

  public Version libVersion() {
    Version ret = new Version(pjsua2PINVOKE.Endpoint_libVersion(swigCPtr), true);
    return ret;
  }

  public void libCreate() {
    pjsua2PINVOKE.Endpoint_libCreate(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public pjsua_state libGetState() {
    pjsua_state ret = (pjsua_state)pjsua2PINVOKE.Endpoint_libGetState(swigCPtr);
    return ret;
  }

  public void libInit(EpConfig prmEpConfig) {
    pjsua2PINVOKE.Endpoint_libInit(swigCPtr, EpConfig.getCPtr(prmEpConfig));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void libStart() {
    pjsua2PINVOKE.Endpoint_libStart(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void libRegisterThread(string name) {
    pjsua2PINVOKE.Endpoint_libRegisterThread(swigCPtr, name);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool libIsThreadRegistered() {
    bool ret = pjsua2PINVOKE.Endpoint_libIsThreadRegistered(swigCPtr);
    return ret;
  }

  public void libStopWorkerThreads() {
    pjsua2PINVOKE.Endpoint_libStopWorkerThreads(swigCPtr);
  }

  public int libHandleEvents(uint msec_timeout) {
    int ret = pjsua2PINVOKE.Endpoint_libHandleEvents(swigCPtr, msec_timeout);
    return ret;
  }

  public void libDestroy(uint prmFlags) {
    pjsua2PINVOKE.Endpoint_libDestroy__SWIG_0(swigCPtr, prmFlags);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void libDestroy() {
    pjsua2PINVOKE.Endpoint_libDestroy__SWIG_1(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public string utilStrError(int prmErr) {
    string ret = pjsua2PINVOKE.Endpoint_utilStrError(swigCPtr, prmErr);
    return ret;
  }

  public void utilLogWrite(int prmLevel, string prmSender, string prmMsg) {
    pjsua2PINVOKE.Endpoint_utilLogWrite__SWIG_0(swigCPtr, prmLevel, prmSender, prmMsg);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void utilLogWrite(LogEntry e) {
    pjsua2PINVOKE.Endpoint_utilLogWrite__SWIG_1(swigCPtr, LogEntry.getCPtr(e));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public int utilVerifySipUri(string prmUri) {
    int ret = pjsua2PINVOKE.Endpoint_utilVerifySipUri(swigCPtr, prmUri);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int utilVerifyUri(string prmUri) {
    int ret = pjsua2PINVOKE.Endpoint_utilVerifyUri(swigCPtr, prmUri);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public System.IntPtr utilTimerSchedule(uint prmMsecDelay, System.IntPtr prmUserData) {
      System.IntPtr cPtr = pjsua2PINVOKE.Endpoint_utilTimerSchedule(swigCPtr, prmMsecDelay, prmUserData);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return cPtr;
  }

  public void utilTimerCancel(System.IntPtr prmToken) {
    pjsua2PINVOKE.Endpoint_utilTimerCancel(swigCPtr, prmToken);
  }

  public void utilAddPendingJob(PendingJob job) {
    pjsua2PINVOKE.Endpoint_utilAddPendingJob(swigCPtr, PendingJob.getCPtr(job));
  }

  public IntVector utilSslGetAvailableCiphers() {
    IntVector ret = new IntVector(pjsua2PINVOKE.Endpoint_utilSslGetAvailableCiphers(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void natDetectType() {
    pjsua2PINVOKE.Endpoint_natDetectType(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public pj_stun_nat_type natGetType() {
    pj_stun_nat_type ret = (pj_stun_nat_type)pjsua2PINVOKE.Endpoint_natGetType(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void natUpdateStunServers(StringVector prmServers, bool prmWait) {
    pjsua2PINVOKE.Endpoint_natUpdateStunServers(swigCPtr, StringVector.getCPtr(prmServers), prmWait);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void natCheckStunServers(StringVector prmServers, bool prmWait, System.IntPtr prmUserData) {
    pjsua2PINVOKE.Endpoint_natCheckStunServers(swigCPtr, StringVector.getCPtr(prmServers), prmWait, prmUserData);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void natCancelCheckStunServers(System.IntPtr token, bool notify_cb) {
    pjsua2PINVOKE.Endpoint_natCancelCheckStunServers__SWIG_0(swigCPtr, token, notify_cb);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void natCancelCheckStunServers(System.IntPtr token) {
    pjsua2PINVOKE.Endpoint_natCancelCheckStunServers__SWIG_1(swigCPtr, token);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public int transportCreate(pjsip_transport_type_e type, TransportConfig cfg) {
    int ret = pjsua2PINVOKE.Endpoint_transportCreate(swigCPtr, (int)type, TransportConfig.getCPtr(cfg));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IntVector transportEnum() {
    IntVector ret = new IntVector(pjsua2PINVOKE.Endpoint_transportEnum(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TransportInfo transportGetInfo(int id) {
    TransportInfo ret = new TransportInfo(pjsua2PINVOKE.Endpoint_transportGetInfo(swigCPtr, id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void transportSetEnable(int id, bool enabled) {
    pjsua2PINVOKE.Endpoint_transportSetEnable(swigCPtr, id, enabled);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void transportClose(int id) {
    pjsua2PINVOKE.Endpoint_transportClose(swigCPtr, id);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void transportShutdown(System.IntPtr tp) {
    pjsua2PINVOKE.Endpoint_transportShutdown(swigCPtr, tp);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void hangupAllCalls() {
    pjsua2PINVOKE.Endpoint_hangupAllCalls(swigCPtr);
  }

  public void mediaAdd(AudioMedia media) {
    pjsua2PINVOKE.Endpoint_mediaAdd(swigCPtr, AudioMedia.getCPtr(media));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void mediaRemove(AudioMedia media) {
    pjsua2PINVOKE.Endpoint_mediaRemove(swigCPtr, AudioMedia.getCPtr(media));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool mediaExists(AudioMedia media) {
    bool ret = pjsua2PINVOKE.Endpoint_mediaExists(swigCPtr, AudioMedia.getCPtr(media));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint mediaMaxPorts() {
    uint ret = pjsua2PINVOKE.Endpoint_mediaMaxPorts(swigCPtr);
    return ret;
  }

  public uint mediaActivePorts() {
    uint ret = pjsua2PINVOKE.Endpoint_mediaActivePorts(swigCPtr);
    return ret;
  }

  public AudioMediaVector2 mediaEnumPorts2() {
    AudioMediaVector2 ret = new AudioMediaVector2(pjsua2PINVOKE.Endpoint_mediaEnumPorts2(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VideoMediaVector mediaEnumVidPorts() {
    VideoMediaVector ret = new VideoMediaVector(pjsua2PINVOKE.Endpoint_mediaEnumVidPorts(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AudDevManager audDevManager() {
    AudDevManager ret = new AudDevManager(pjsua2PINVOKE.Endpoint_audDevManager(swigCPtr), false);
    return ret;
  }

  public VidDevManager vidDevManager() {
    VidDevManager ret = new VidDevManager(pjsua2PINVOKE.Endpoint_vidDevManager(swigCPtr), false);
    return ret;
  }

  public CodecInfoVector2 codecEnum2() {
    CodecInfoVector2 ret = new CodecInfoVector2(pjsua2PINVOKE.Endpoint_codecEnum2(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void codecSetPriority(string codec_id, byte priority) {
    pjsua2PINVOKE.Endpoint_codecSetPriority(swigCPtr, codec_id, priority);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CodecParam codecGetParam(string codec_id) {
    CodecParam ret = new CodecParam(pjsua2PINVOKE.Endpoint_codecGetParam(swigCPtr, codec_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void codecSetParam(string codec_id, CodecParam param) {
    pjsua2PINVOKE.Endpoint_codecSetParam(swigCPtr, codec_id, CodecParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CodecInfoVector2 videoCodecEnum2() {
    CodecInfoVector2 ret = new CodecInfoVector2(pjsua2PINVOKE.Endpoint_videoCodecEnum2(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void videoCodecSetPriority(string codec_id, byte priority) {
    pjsua2PINVOKE.Endpoint_videoCodecSetPriority(swigCPtr, codec_id, priority);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public VidCodecParam getVideoCodecParam(string codec_id) {
    VidCodecParam ret = new VidCodecParam(pjsua2PINVOKE.Endpoint_getVideoCodecParam(swigCPtr, codec_id), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVideoCodecParam(string codec_id, VidCodecParam param) {
    pjsua2PINVOKE.Endpoint_setVideoCodecParam(swigCPtr, codec_id, VidCodecParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void resetVideoCodecParam(string codec_id) {
    pjsua2PINVOKE.Endpoint_resetVideoCodecParam(swigCPtr, codec_id);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector srtpCryptoEnum() {
    StringVector ret = new StringVector(pjsua2PINVOKE.Endpoint_srtpCryptoEnum(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void handleIpChange(IpChangeParam param) {
    pjsua2PINVOKE.Endpoint_handleIpChange(swigCPtr, IpChangeParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onNatDetectionComplete(OnNatDetectionCompleteParam prm) {
    if (SwigDerivedClassHasMethod("onNatDetectionComplete", swigMethodTypes0)) pjsua2PINVOKE.Endpoint_onNatDetectionCompleteSwigExplicitEndpoint(swigCPtr, OnNatDetectionCompleteParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onNatDetectionComplete(swigCPtr, OnNatDetectionCompleteParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onNatCheckStunServersComplete(OnNatCheckStunServersCompleteParam prm) {
    if (SwigDerivedClassHasMethod("onNatCheckStunServersComplete", swigMethodTypes1)) pjsua2PINVOKE.Endpoint_onNatCheckStunServersCompleteSwigExplicitEndpoint(swigCPtr, OnNatCheckStunServersCompleteParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onNatCheckStunServersComplete(swigCPtr, OnNatCheckStunServersCompleteParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onTransportState(OnTransportStateParam prm) {
    if (SwigDerivedClassHasMethod("onTransportState", swigMethodTypes2)) pjsua2PINVOKE.Endpoint_onTransportStateSwigExplicitEndpoint(swigCPtr, OnTransportStateParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onTransportState(swigCPtr, OnTransportStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onTimer(OnTimerParam prm) {
    if (SwigDerivedClassHasMethod("onTimer", swigMethodTypes3)) pjsua2PINVOKE.Endpoint_onTimerSwigExplicitEndpoint(swigCPtr, OnTimerParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onTimer(swigCPtr, OnTimerParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onSelectAccount(OnSelectAccountParam prm) {
    if (SwigDerivedClassHasMethod("onSelectAccount", swigMethodTypes4)) pjsua2PINVOKE.Endpoint_onSelectAccountSwigExplicitEndpoint(swigCPtr, OnSelectAccountParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onSelectAccount(swigCPtr, OnSelectAccountParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onIpChangeProgress(OnIpChangeProgressParam prm) {
    if (SwigDerivedClassHasMethod("onIpChangeProgress", swigMethodTypes5)) pjsua2PINVOKE.Endpoint_onIpChangeProgressSwigExplicitEndpoint(swigCPtr, OnIpChangeProgressParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onIpChangeProgress(swigCPtr, OnIpChangeProgressParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onMediaEvent(OnMediaEventParam prm) {
    if (SwigDerivedClassHasMethod("onMediaEvent", swigMethodTypes6)) pjsua2PINVOKE.Endpoint_onMediaEventSwigExplicitEndpoint(swigCPtr, OnMediaEventParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onMediaEvent(swigCPtr, OnMediaEventParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int onCredAuth(OnCredAuthParam prm) {
    int ret = (SwigDerivedClassHasMethod("onCredAuth", swigMethodTypes7) ? pjsua2PINVOKE.Endpoint_onCredAuthSwigExplicitEndpoint(swigCPtr, OnCredAuthParam.getCPtr(prm)) : pjsua2PINVOKE.Endpoint_onCredAuth(swigCPtr, OnCredAuthParam.getCPtr(prm)));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void onRejectedIncomingCall(OnRejectedIncomingCallParam prm) {
    if (SwigDerivedClassHasMethod("onRejectedIncomingCall", swigMethodTypes8)) pjsua2PINVOKE.Endpoint_onRejectedIncomingCallSwigExplicitEndpoint(swigCPtr, OnRejectedIncomingCallParam.getCPtr(prm)); else pjsua2PINVOKE.Endpoint_onRejectedIncomingCall(swigCPtr, OnRejectedIncomingCallParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onNatDetectionComplete", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateEndpoint_0(SwigDirectorMethodonNatDetectionComplete);
    if (SwigDerivedClassHasMethod("onNatCheckStunServersComplete", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateEndpoint_1(SwigDirectorMethodonNatCheckStunServersComplete);
    if (SwigDerivedClassHasMethod("onTransportState", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateEndpoint_2(SwigDirectorMethodonTransportState);
    if (SwigDerivedClassHasMethod("onTimer", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateEndpoint_3(SwigDirectorMethodonTimer);
    if (SwigDerivedClassHasMethod("onSelectAccount", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateEndpoint_4(SwigDirectorMethodonSelectAccount);
    if (SwigDerivedClassHasMethod("onIpChangeProgress", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateEndpoint_5(SwigDirectorMethodonIpChangeProgress);
    if (SwigDerivedClassHasMethod("onMediaEvent", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateEndpoint_6(SwigDirectorMethodonMediaEvent);
    if (SwigDerivedClassHasMethod("onCredAuth", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateEndpoint_7(SwigDirectorMethodonCredAuth);
    if (SwigDerivedClassHasMethod("onRejectedIncomingCall", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateEndpoint_8(SwigDirectorMethodonRejectedIncomingCall);
    pjsua2PINVOKE.Endpoint_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Endpoint));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodonNatDetectionComplete(global::System.IntPtr prm) {
    onNatDetectionComplete(new OnNatDetectionCompleteParam(prm, false));
  }

  private void SwigDirectorMethodonNatCheckStunServersComplete(global::System.IntPtr prm) {
    onNatCheckStunServersComplete(new OnNatCheckStunServersCompleteParam(prm, false));
  }

  private void SwigDirectorMethodonTransportState(global::System.IntPtr prm) {
    onTransportState(new OnTransportStateParam(prm, false));
  }

  private void SwigDirectorMethodonTimer(global::System.IntPtr prm) {
    onTimer(new OnTimerParam(prm, false));
  }

  private void SwigDirectorMethodonSelectAccount(global::System.IntPtr prm) {
    onSelectAccount(new OnSelectAccountParam(prm, false));
  }

  private void SwigDirectorMethodonIpChangeProgress(global::System.IntPtr prm) {
    onIpChangeProgress(new OnIpChangeProgressParam(prm, false));
  }

  private void SwigDirectorMethodonMediaEvent(global::System.IntPtr prm) {
    onMediaEvent(new OnMediaEventParam(prm, false));
  }

  private int SwigDirectorMethodonCredAuth(global::System.IntPtr prm) {
    return onCredAuth(new OnCredAuthParam(prm, false));
  }

  private void SwigDirectorMethodonRejectedIncomingCall(global::System.IntPtr prm) {
    onRejectedIncomingCall(new OnRejectedIncomingCallParam(prm, false));
  }

  public delegate void SwigDelegateEndpoint_0(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_1(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_2(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_3(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_4(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_5(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_6(global::System.IntPtr prm);
  public delegate int SwigDelegateEndpoint_7(global::System.IntPtr prm);
  public delegate void SwigDelegateEndpoint_8(global::System.IntPtr prm);

  private SwigDelegateEndpoint_0 swigDelegate0;
  private SwigDelegateEndpoint_1 swigDelegate1;
  private SwigDelegateEndpoint_2 swigDelegate2;
  private SwigDelegateEndpoint_3 swigDelegate3;
  private SwigDelegateEndpoint_4 swigDelegate4;
  private SwigDelegateEndpoint_5 swigDelegate5;
  private SwigDelegateEndpoint_6 swigDelegate6;
  private SwigDelegateEndpoint_7 swigDelegate7;
  private SwigDelegateEndpoint_8 swigDelegate8;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(OnNatDetectionCompleteParam) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(OnNatCheckStunServersCompleteParam) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(OnTransportStateParam) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(OnTimerParam) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(OnSelectAccountParam) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(OnIpChangeProgressParam) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(OnMediaEventParam) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(OnCredAuthParam) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(OnRejectedIncomingCallParam) };
}

}
