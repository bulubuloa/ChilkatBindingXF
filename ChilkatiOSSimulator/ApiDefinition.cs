using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    [BaseType(typeof(NSObject))]
    interface CkoCrypt2
    {
        [Export("CryptAlgorithm")]
        string CryptAlgorithm { get; set; }

        [Export("CipherMode")]
        string CipherMode { get; set; }

        [Export("KeyLength", ArgumentSemantic.Copy)]
        NSNumber KeyLength { get; set; }

        [Export("PaddingScheme", ArgumentSemantic.Copy)]
        NSNumber PaddingScheme { get; set; }

        [Export("EncodingMode")]
        string EncodingMode { get; set; }

        [Export("SetEncodedIV:encoding:")]
        void SetEncodedIV(string ivStr, string encoding);

        [Export("SetEncodedKey:encoding:")]
        void SetEncodedKey(string keyStr, string encoding);

        [Export("EncryptStringENC:")]
        string EncryptStringENC(string str);

        [Export("DecryptStringENC:")]
        string DecryptStringENC(string bData);
    }

    [BaseType(typeof(NSObject))]
    interface CkoGlobal
    {
        [Export("Version", ArgumentSemantic.Copy)]
        string Version { get; }

        [Export("UnlockBundle:")]
        bool UnlockBundle(string str);
    }
}