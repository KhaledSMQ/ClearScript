// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;

namespace Microsoft.ClearScript.V8
{
    internal abstract class V8IsolateProxy : V8Proxy
    {
        public static V8IsolateProxy Create(string name, V8RuntimeConstraints constraints, V8RuntimeFlags flags, int debugPort)
        {
            return CreateImpl<V8IsolateProxy>(name, constraints, flags, debugPort);
        }

        public abstract UIntPtr MaxHeapSize { get; set; }

        public abstract TimeSpan HeapSizeSampleInterval { get; set; }

        public abstract UIntPtr MaxStackUsage { get; set; }

        public abstract void AwaitDebuggerAndPause();

        public abstract V8Script Compile(DocumentInfo documentInfo, string code);

        public abstract V8Script Compile(DocumentInfo documentInfo, string code, V8CacheKind cacheKind, out byte[] cacheBytes);

        public abstract V8Script Compile(DocumentInfo documentInfo, string code, V8CacheKind cacheKind, byte[] cacheBytes, out bool cacheAccepted);

        public abstract V8RuntimeHeapInfo GetHeapInfo();

        public abstract void CollectGarbage(bool exhaustive);
    }
}
