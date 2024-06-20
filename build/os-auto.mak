# build/os-auto.mak.  Generated from os-auto.mak.in by configure.

export OS_CFLAGS   := $(CC_DEF)PJ_AUTOCONF=1  -target aarch64-none-linux-android33 -fdata-sections -ffunction-sections -funwind-tables -no-canonical-prefixes --sysroot /root/android-ndk-r25c/toolchains/llvm/prebuilt/linux-x86_64/sysroot -Wno-invalid-command-line-argument -Wno-unused-command-line-argument -D_FORTIFY_SOURCE=2 -fpic -I/root/android-ndk-r25c/sources/cxx-stl/llvm-libc++/include -I/root/android-ndk-r25c/sources/cxx-stl/llvm-libc++/../llvm-libc++abi/include -Ijni -DANDROID -nostdinc++ -Wformat -Werror=format-security   -DPJ_IS_BIG_ENDIAN=0 -DPJ_IS_LITTLE_ENDIAN=1

export OS_CXXFLAGS := $(CC_DEF)PJ_AUTOCONF=1  -fno-exceptions -fno-rtti -fexceptions -frtti  

export OS_LDFLAGS  :=  /root/android-ndk-r25c/toolchains/llvm/prebuilt/linux-x86_64/lib64/clang/14.0.7/lib/linux/aarch64/libunwind.a -latomic -target aarch64-none-linux-android33 -no-canonical-prefixes -Wl,--gc-sections -Wl,--build-id=sha1 -nostdlib++ -Wl,--no-undefined -Wl,--fatal-warnings -lc -lm   -lmediandk -lm  /root/android-ndk-r25c/toolchains/llvm/prebuilt/linux-x86_64/sysroot/usr/lib/aarch64-linux-android/libc++_shared.so -lOpenSLES -llog -lGLESv2 -lEGL -landroid

export OS_SOURCES  := 


