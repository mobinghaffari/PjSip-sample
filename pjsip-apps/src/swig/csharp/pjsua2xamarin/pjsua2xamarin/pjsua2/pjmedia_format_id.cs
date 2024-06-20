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

public enum pjmedia_format_id {
  PJMEDIA_FORMAT_L16 = 0,
  PJMEDIA_FORMAT_PCM = PJMEDIA_FORMAT_L16,
  PJMEDIA_FORMAT_PCMA = ((('W' << 24)|('A' << 16))|('L' << 8))|'A',
  PJMEDIA_FORMAT_ALAW = PJMEDIA_FORMAT_PCMA,
  PJMEDIA_FORMAT_PCMU = ((('W' << 24)|('A' << 16))|('L' << 8))|'u',
  PJMEDIA_FORMAT_ULAW = PJMEDIA_FORMAT_PCMU,
  PJMEDIA_FORMAT_AMR = ((('R' << 24)|('M' << 16))|('A' << 8))|' ',
  PJMEDIA_FORMAT_G729 = ((('9' << 24)|('2' << 16))|('7' << 8))|'G',
  PJMEDIA_FORMAT_ILBC = ((('C' << 24)|('B' << 16))|('L' << 8))|'I',
  PJMEDIA_FORMAT_RGB24 = ((('3' << 24)|('B' << 16))|('G' << 8))|'R',
  PJMEDIA_FORMAT_RGBA = ((('A' << 24)|('B' << 16))|('G' << 8))|'R',
  PJMEDIA_FORMAT_BGRA = ((('A' << 24)|('R' << 16))|('G' << 8))|'B',
  PJMEDIA_FORMAT_RGB32 = PJMEDIA_FORMAT_RGBA,
  PJMEDIA_FORMAT_DIB = (((' ' << 24)|('B' << 16))|('I' << 8))|'D',
  PJMEDIA_FORMAT_GBRP = ((('P' << 24)|('R' << 16))|('B' << 8))|'G',
  PJMEDIA_FORMAT_AYUV = ((('V' << 24)|('U' << 16))|('Y' << 8))|'A',
  PJMEDIA_FORMAT_YUY2 = ((('2' << 24)|('Y' << 16))|('U' << 8))|'Y',
  PJMEDIA_FORMAT_UYVY = ((('Y' << 24)|('V' << 16))|('Y' << 8))|'U',
  PJMEDIA_FORMAT_YVYU = ((('U' << 24)|('Y' << 16))|('V' << 8))|'Y',
  PJMEDIA_FORMAT_I420 = ((('0' << 24)|('2' << 16))|('4' << 8))|'I',
  PJMEDIA_FORMAT_IYUV = PJMEDIA_FORMAT_I420,
  PJMEDIA_FORMAT_YV12 = ((('2' << 24)|('1' << 16))|('V' << 8))|'Y',
  PJMEDIA_FORMAT_NV12 = ((('2' << 24)|('1' << 16))|('V' << 8))|'N',
  PJMEDIA_FORMAT_NV21 = ((('1' << 24)|('2' << 16))|('V' << 8))|'N',
  PJMEDIA_FORMAT_I422 = ((('2' << 24)|('2' << 16))|('4' << 8))|'I',
  PJMEDIA_FORMAT_I420JPEG = ((('0' << 24)|('2' << 16))|('4' << 8))|'J',
  PJMEDIA_FORMAT_I422JPEG = ((('2' << 24)|('2' << 16))|('4' << 8))|'J',
  PJMEDIA_FORMAT_H261 = ((('1' << 24)|('6' << 16))|('2' << 8))|'H',
  PJMEDIA_FORMAT_H263 = ((('3' << 24)|('6' << 16))|('2' << 8))|'H',
  PJMEDIA_FORMAT_H263P = ((('3' << 24)|('6' << 16))|('2' << 8))|'P',
  PJMEDIA_FORMAT_H264 = ((('4' << 24)|('6' << 16))|('2' << 8))|'H',
  PJMEDIA_FORMAT_VP8 = ((('0' << 24)|('8' << 16))|('P' << 8))|'V',
  PJMEDIA_FORMAT_VP9 = ((('0' << 24)|('9' << 16))|('P' << 8))|'V',
  PJMEDIA_FORMAT_MJPEG = ((('G' << 24)|('P' << 16))|('J' << 8))|'M',
  PJMEDIA_FORMAT_MPEG1VIDEO = ((('V' << 24)|('1' << 16))|('P' << 8))|'M',
  PJMEDIA_FORMAT_MPEG2VIDEO = ((('V' << 24)|('2' << 16))|('P' << 8))|'M',
  PJMEDIA_FORMAT_MPEG4 = ((('4' << 24)|('G' << 16))|('P' << 8))|'M',
  PJMEDIA_FORMAT_INVALID = 0xFFFFFFF
}

}
